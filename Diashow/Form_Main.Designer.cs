namespace Diashow
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.dGV_diashowitems = new System.Windows.Forms.DataGridView();
            this.dgv_col_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_col_filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_col_repetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDiashowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDiashowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadFacebookAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_additem = new System.Windows.Forms.Button();
            this.b_removeitem = new System.Windows.Forms.Button();
            this.b_edititem = new System.Windows.Forms.Button();
            this.gB_globalsettings = new System.Windows.Forms.GroupBox();
            this.rB_useVLC = new System.Windows.Forms.RadioButton();
            this.rB_useWMP = new System.Windows.Forms.RadioButton();
            this.nUD_interval = new System.Windows.Forms.NumericUpDown();
            this.l_interval = new System.Windows.Forms.Label();
            this.b_play = new System.Windows.Forms.Button();
            this.l_diashowitems = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_diashowitems)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.gB_globalsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_diashowitems
            // 
            this.dGV_diashowitems.AllowUserToAddRows = false;
            this.dGV_diashowitems.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dGV_diashowitems, "dGV_diashowitems");
            this.dGV_diashowitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_diashowitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_col_image,
            this.dgv_col_filename,
            this.dgv_col_type,
            this.dgv_col_repetition});
            this.dGV_diashowitems.Name = "dGV_diashowitems";
            this.dGV_diashowitems.ReadOnly = true;
            this.dGV_diashowitems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_diashowitems_CellClick);
            this.dGV_diashowitems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGV_diashowitems_CellFormatting);
            // 
            // dgv_col_image
            // 
            this.dgv_col_image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgv_col_image.Frozen = true;
            resources.ApplyResources(this.dgv_col_image, "dgv_col_image");
            this.dgv_col_image.Name = "dgv_col_image";
            this.dgv_col_image.ReadOnly = true;
            this.dgv_col_image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgv_col_filename
            // 
            resources.ApplyResources(this.dgv_col_filename, "dgv_col_filename");
            this.dgv_col_filename.Name = "dgv_col_filename";
            this.dgv_col_filename.ReadOnly = true;
            // 
            // dgv_col_type
            // 
            resources.ApplyResources(this.dgv_col_type, "dgv_col_type");
            this.dgv_col_type.Name = "dgv_col_type";
            this.dgv_col_type.ReadOnly = true;
            this.dgv_col_type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgv_col_repetition
            // 
            this.dgv_col_repetition.DataPropertyName = "Setting";
            resources.ApplyResources(this.dgv_col_repetition, "dgv_col_repetition");
            this.dgv_col_repetition.Name = "dgv_col_repetition";
            this.dgv_col_repetition.ReadOnly = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDiashowToolStripMenuItem,
            this.openDiashowToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // saveDiashowToolStripMenuItem
            // 
            this.saveDiashowToolStripMenuItem.Name = "saveDiashowToolStripMenuItem";
            resources.ApplyResources(this.saveDiashowToolStripMenuItem, "saveDiashowToolStripMenuItem");
            this.saveDiashowToolStripMenuItem.Click += new System.EventHandler(this.saveDiashowToolStripMenuItem_Click);
            // 
            // openDiashowToolStripMenuItem
            // 
            this.openDiashowToolStripMenuItem.Name = "openDiashowToolStripMenuItem";
            resources.ApplyResources(this.openDiashowToolStripMenuItem, "openDiashowToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator2,
            this.downloadFacebookAlbumToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            resources.ApplyResources(this.undoToolStripMenuItem, "undoToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // downloadFacebookAlbumToolStripMenuItem
            // 
            this.downloadFacebookAlbumToolStripMenuItem.Name = "downloadFacebookAlbumToolStripMenuItem";
            resources.ApplyResources(this.downloadFacebookAlbumToolStripMenuItem, "downloadFacebookAlbumToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // b_additem
            // 
            resources.ApplyResources(this.b_additem, "b_additem");
            this.b_additem.Name = "b_additem";
            this.b_additem.UseVisualStyleBackColor = true;
            this.b_additem.Click += new System.EventHandler(this.b_additem_Click);
            // 
            // b_removeitem
            // 
            resources.ApplyResources(this.b_removeitem, "b_removeitem");
            this.b_removeitem.Name = "b_removeitem";
            this.b_removeitem.UseVisualStyleBackColor = true;
            this.b_removeitem.Click += new System.EventHandler(this.b_removeitem_Click);
            // 
            // b_edititem
            // 
            resources.ApplyResources(this.b_edititem, "b_edititem");
            this.b_edititem.Name = "b_edititem";
            this.b_edititem.UseVisualStyleBackColor = true;
            this.b_edititem.Click += new System.EventHandler(this.b_edititem_Click);
            // 
            // gB_globalsettings
            // 
            this.gB_globalsettings.Controls.Add(this.rB_useVLC);
            this.gB_globalsettings.Controls.Add(this.rB_useWMP);
            this.gB_globalsettings.Controls.Add(this.nUD_interval);
            this.gB_globalsettings.Controls.Add(this.l_interval);
            resources.ApplyResources(this.gB_globalsettings, "gB_globalsettings");
            this.gB_globalsettings.Name = "gB_globalsettings";
            this.gB_globalsettings.TabStop = false;
            // 
            // rB_useVLC
            // 
            resources.ApplyResources(this.rB_useVLC, "rB_useVLC");
            this.rB_useVLC.Name = "rB_useVLC";
            this.rB_useVLC.UseVisualStyleBackColor = true;
            // 
            // rB_useWMP
            // 
            resources.ApplyResources(this.rB_useWMP, "rB_useWMP");
            this.rB_useWMP.Checked = true;
            this.rB_useWMP.Name = "rB_useWMP";
            this.rB_useWMP.TabStop = true;
            this.rB_useWMP.UseVisualStyleBackColor = true;
            // 
            // nUD_interval
            // 
            resources.ApplyResources(this.nUD_interval, "nUD_interval");
            this.nUD_interval.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.nUD_interval.Name = "nUD_interval";
            this.nUD_interval.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // l_interval
            // 
            resources.ApplyResources(this.l_interval, "l_interval");
            this.l_interval.Name = "l_interval";
            // 
            // b_play
            // 
            resources.ApplyResources(this.b_play, "b_play");
            this.b_play.Name = "b_play";
            this.b_play.UseVisualStyleBackColor = true;
            this.b_play.Click += new System.EventHandler(this.b_play_Click);
            // 
            // l_diashowitems
            // 
            resources.ApplyResources(this.l_diashowitems, "l_diashowitems");
            this.l_diashowitems.Name = "l_diashowitems";
            // 
            // Form_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l_diashowitems);
            this.Controls.Add(this.b_play);
            this.Controls.Add(this.gB_globalsettings);
            this.Controls.Add(this.b_edititem);
            this.Controls.Add(this.b_removeitem);
            this.Controls.Add(this.b_additem);
            this.Controls.Add(this.dGV_diashowitems);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form_Main";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_diashowitems)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gB_globalsettings.ResumeLayout(false);
            this.gB_globalsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_diashowitems;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDiashowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDiashowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem downloadFacebookAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button b_additem;
        private System.Windows.Forms.Button b_removeitem;
        private System.Windows.Forms.Button b_edititem;
        private System.Windows.Forms.GroupBox gB_globalsettings;
        private System.Windows.Forms.NumericUpDown nUD_interval;
        private System.Windows.Forms.Label l_interval;
        private System.Windows.Forms.Button b_play;
        private System.Windows.Forms.Label l_diashowitems;
        private System.Windows.Forms.DataGridViewImageColumn dgv_col_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_col_filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_col_repetition;
        private System.Windows.Forms.RadioButton rB_useVLC;
        private System.Windows.Forms.RadioButton rB_useWMP;
    }
}

