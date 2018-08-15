using DiashowPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diashow
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void b_additem_Click(object sender, EventArgs e)
        {
            Form_Dialog_AddItem.ShowModal(dGV_diashowitems);
            dGV_diashowitems.AutoResizeColumn(2);
        }

        private void dGV_diashowitems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewCell cell in dGV_diashowitems.SelectedCells)
            {
                dGV_diashowitems.Rows[cell.RowIndex].Selected = true;
            }
        }

        private void dGV_diashowitems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.GetType().Equals(typeof(RepeationSetting)))
            {
                e.Value = (e.Value as RepeationSetting).ToString();
                e.FormattingApplied = true;
            }
        }

        private void b_play_Click(object sender, EventArgs e)
        {
            var diashow = new DiashowPlayer.Diashow()
            {
                GlobalInterval = Decimal.ToInt32(nUD_interval.Value),
            };
            foreach(DataGridViewRow row in dGV_diashowitems.Rows)
            {
                if((row.Cells[2].Value as string).StartsWith("Image"))
                    diashow.Medias.Add(new Media(row.Cells[1].Value as string, row.Cells[3].Value as RepeationSetting, MediaType.STILLIMAGE));
                else
                    diashow.Medias.Add(new Media(row.Cells[1].Value as string, row.Cells[3].Value as RepeationSetting, MediaType.VIDEO));
            }

            (new DiashowPlayer.DiashowPlayer(diashow, rB_useVLC.Checked)).play();
        }

        private void b_removeitem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGV_diashowitems.SelectedRows)
            {
                dGV_diashowitems.Rows.Remove(row);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog();
        }

        private void b_edititem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dGV_diashowitems.SelectedRows)
            {
                var editfrom = new Form_Edit_Item();
                editfrom.pictureBox1.Image = row.Cells[0].Value as Image;
                editfrom.nUD_interval.Value = (row.Cells[3].Value as RepeationSetting).Interval;
                if((row.Cells[3].Value as RepeationSetting).Weight != 1)
                {
                    editfrom.rB_weight.Checked = true;
                    editfrom.nUD_repeat.Value = (row.Cells[3].Value as RepeationSetting).Weight;
                }
                else
                {
                    editfrom.rB_garanteed.Checked = true;
                    editfrom.nUD_repeat.Value = (row.Cells[3].Value as RepeationSetting).GaranteedEvery;
                }

                if(editfrom.ShowDialog() == DialogResult.OK)
                {
                    RepeationSetting newRepeationSetting = new RepeationSetting();
                    if(editfrom.nUD_interval.Value != nUD_interval.Value)
                    {
                        newRepeationSetting.Interval = Decimal.ToInt32(editfrom.nUD_interval.Value);
                    }
                    else
                    {
                        newRepeationSetting.Interval = 0;
                    }
                    if(editfrom.rB_weight.Checked)
                    {
                        newRepeationSetting.GaranteedEvery = 0;
                        newRepeationSetting.Weight = Decimal.ToInt32(editfrom.nUD_repeat.Value);
                    }
                    else
                    {
                        newRepeationSetting.Weight = 1;
                        newRepeationSetting.GaranteedEvery = Decimal.ToInt32(editfrom.nUD_repeat.Value);
                    }
                    row.Cells[3].Value = newRepeationSetting;
                }
            }
        }

        private void saveDiashowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
