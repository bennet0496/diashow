using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiashowPlayer
{
    public class DiashowPlayer
    {
        private Diashow diashow;
        private Form_Diashow player;
        private Dictionary<Media, long> priorityMediaLastTick = new Dictionary<Media, long>();
        public DiashowPlayer(Diashow diashow, bool preferVLC = false)
        {
            this.diashow = diashow;

            diashow.PriorityMedia.ForEach((m) => priorityMediaLastTick.Add(m, 0));

            player = new Form_Diashow(preferVLC);
            player.timer.Interval = diashow.IntervalTicks;
            player.timer.Tick += timertick;
        }

        private long tickcounter = 0;
        private Random rnd = new Random();

        private void timertick(object sender, EventArgs e)
        {
            int interval = player.CurrentMedia.RepeationSetting.Interval == 0 ? diashow.GlobalInterval : player.CurrentMedia.RepeationSetting.Interval;
            Media mediaToPlay;
            if (tickcounter % interval == 0)
            {
                //We have to cycle media
                var pmPastDue = (from pm in priorityMediaLastTick
                                 where (tickcounter - pm.Value) >= pm.Key.RepeationSetting.GaranteedEvery
                                 select pm.Key);
                if(pmPastDue.Count() > 0)
                {
                    mediaToPlay = pmPastDue.ElementAt(rnd.Next(pmPastDue.Count()));
                    priorityMediaLastTick[mediaToPlay] = tickcounter;
                }
                else
                {
                    mediaToPlay = diashow.WeightedElementAt(rnd.Next(diashow.WeightedCount));
                }

                player.play(mediaToPlay);
            }
            tickcounter++;
        }

        public void play()
        {
            player.ShowDialog();
        }
    }
}
