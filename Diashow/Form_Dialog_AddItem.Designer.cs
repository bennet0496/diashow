namespace Diashow
{
    partial class Form_Dialog_AddItem
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tB_Files = new System.Windows.Forms.TextBox();
            this.b_browse = new System.Windows.Forms.Button();
            this.l_files = new System.Windows.Forms.Label();
            this.nUD_interval = new System.Windows.Forms.NumericUpDown();
            this.l_interval = new System.Windows.Forms.Label();
            this.nUD_weight = new System.Windows.Forms.NumericUpDown();
            this.l_weight = new System.Windows.Forms.Label();
            this.l_msec = new System.Windows.Forms.Label();
            this.b_wighthelp = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.tiff;*.gif|Videos|*.mp4;*.m4v;*.avi;*.webm;*.wm" +
    "v;*.mov;*.mkv";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tB_Files
            // 
            this.tB_Files.Location = new System.Drawing.Point(12, 27);
            this.tB_Files.Name = "tB_Files";
            this.tB_Files.Size = new System.Drawing.Size(347, 20);
            this.tB_Files.TabIndex = 0;
            // 
            // b_browse
            // 
            this.b_browse.Location = new System.Drawing.Point(365, 25);
            this.b_browse.Name = "b_browse";
            this.b_browse.Size = new System.Drawing.Size(36, 23);
            this.b_browse.TabIndex = 1;
            this.b_browse.Text = "...";
            this.b_browse.UseVisualStyleBackColor = true;
            this.b_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_files
            // 
            this.l_files.AutoSize = true;
            this.l_files.Location = new System.Drawing.Point(12, 9);
            this.l_files.Name = "l_files";
            this.l_files.Size = new System.Drawing.Size(28, 13);
            this.l_files.TabIndex = 2;
            this.l_files.Text = "Files";
            // 
            // nUD_interval
            // 
            this.nUD_interval.Location = new System.Drawing.Point(115, 81);
            this.nUD_interval.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.nUD_interval.Name = "nUD_interval";
            this.nUD_interval.Size = new System.Drawing.Size(91, 20);
            this.nUD_interval.TabIndex = 4;
            this.nUD_interval.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // l_interval
            // 
            this.l_interval.AutoSize = true;
            this.l_interval.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_interval.Location = new System.Drawing.Point(12, 83);
            this.l_interval.Name = "l_interval";
            this.l_interval.Size = new System.Drawing.Size(64, 13);
            this.l_interval.TabIndex = 3;
            this.l_interval.Text = "Item interval";
            // 
            // nUD_weight
            // 
            this.nUD_weight.Location = new System.Drawing.Point(115, 111);
            this.nUD_weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_weight.Name = "nUD_weight";
            this.nUD_weight.Size = new System.Drawing.Size(91, 20);
            this.nUD_weight.TabIndex = 6;
            this.nUD_weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // l_weight
            // 
            this.l_weight.AutoSize = true;
            this.l_weight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_weight.Location = new System.Drawing.Point(12, 113);
            this.l_weight.Name = "l_weight";
            this.l_weight.Size = new System.Drawing.Size(64, 13);
            this.l_weight.TabIndex = 5;
            this.l_weight.Text = "Item Weight";
            // 
            // l_msec
            // 
            this.l_msec.AutoSize = true;
            this.l_msec.Location = new System.Drawing.Point(212, 83);
            this.l_msec.Name = "l_msec";
            this.l_msec.Size = new System.Drawing.Size(32, 13);
            this.l_msec.TabIndex = 8;
            this.l_msec.Text = "msec";
            // 
            // b_wighthelp
            // 
            this.b_wighthelp.BackColor = System.Drawing.Color.RoyalBlue;
            this.b_wighthelp.FlatAppearance.BorderSize = 0;
            this.b_wighthelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_wighthelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_wighthelp.Location = new System.Drawing.Point(215, 111);
            this.b_wighthelp.Name = "b_wighthelp";
            this.b_wighthelp.Size = new System.Drawing.Size(23, 22);
            this.b_wighthelp.TabIndex = 9;
            this.b_wighthelp.Text = "?";
            this.b_wighthelp.UseVisualStyleBackColor = false;
            this.b_wighthelp.Click += new System.EventHandler(this.button2_Click);
            this.b_wighthelp.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(326, 108);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 10;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 156);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(423, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // Form_Dialog_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 178);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_wighthelp);
            this.Controls.Add(this.l_msec);
            this.Controls.Add(this.nUD_weight);
            this.Controls.Add(this.l_weight);
            this.Controls.Add(this.nUD_interval);
            this.Controls.Add(this.l_interval);
            this.Controls.Add(this.l_files);
            this.Controls.Add(this.b_browse);
            this.Controls.Add(this.tB_Files);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Dialog_AddItem";
            this.Text = "Add Item ...";
            ((System.ComponentModel.ISupportInitialize)(this.nUD_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tB_Files;
        private System.Windows.Forms.Button b_browse;
        private System.Windows.Forms.Label l_files;
        private System.Windows.Forms.NumericUpDown nUD_interval;
        private System.Windows.Forms.Label l_interval;
        private System.Windows.Forms.NumericUpDown nUD_weight;
        private System.Windows.Forms.Label l_weight;
        private System.Windows.Forms.Label l_msec;
        private System.Windows.Forms.Button b_wighthelp;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}