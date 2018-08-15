namespace Diashow
{
    partial class Form_Edit_Item
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nUD_interval = new System.Windows.Forms.NumericUpDown();
            this.l_interval = new System.Windows.Forms.Label();
            this.nUD_repeat = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.rB_weight = new System.Windows.Forms.RadioButton();
            this.rB_garanteed = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_repeat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nUD_interval
            // 
            this.nUD_interval.Location = new System.Drawing.Point(120, 161);
            this.nUD_interval.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.nUD_interval.Name = "nUD_interval";
            this.nUD_interval.Size = new System.Drawing.Size(91, 20);
            this.nUD_interval.TabIndex = 3;
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
            this.l_interval.Location = new System.Drawing.Point(9, 163);
            this.l_interval.Name = "l_interval";
            this.l_interval.Size = new System.Drawing.Size(98, 13);
            this.l_interval.TabIndex = 2;
            this.l_interval.Text = "Item interval (msec)";
            // 
            // nUD_repeat
            // 
            this.nUD_repeat.Location = new System.Drawing.Point(120, 205);
            this.nUD_repeat.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.nUD_repeat.Name = "nUD_repeat";
            this.nUD_repeat.Size = new System.Drawing.Size(91, 20);
            this.nUD_repeat.TabIndex = 5;
            this.nUD_repeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rB_weight
            // 
            this.rB_weight.AutoSize = true;
            this.rB_weight.Location = new System.Drawing.Point(12, 195);
            this.rB_weight.Name = "rB_weight";
            this.rB_weight.Size = new System.Drawing.Size(79, 17);
            this.rB_weight.TabIndex = 9;
            this.rB_weight.TabStop = true;
            this.rB_weight.Text = "Item weight";
            this.rB_weight.UseVisualStyleBackColor = true;
            // 
            // rB_garanteed
            // 
            this.rB_garanteed.AutoSize = true;
            this.rB_garanteed.Location = new System.Drawing.Point(12, 218);
            this.rB_garanteed.Name = "rB_garanteed";
            this.rB_garanteed.Size = new System.Drawing.Size(102, 17);
            this.rB_garanteed.TabIndex = 10;
            this.rB_garanteed.TabStop = true;
            this.rB_garanteed.Text = "garanteed every";
            this.rB_garanteed.UseVisualStyleBackColor = true;
            // 
            // Form_Edit_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 293);
            this.Controls.Add(this.rB_garanteed);
            this.Controls.Add(this.rB_weight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nUD_repeat);
            this.Controls.Add(this.nUD_interval);
            this.Controls.Add(this.l_interval);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Edit_Item";
            this.Text = "Edit Item";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_repeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_interval;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.NumericUpDown nUD_interval;
        internal System.Windows.Forms.NumericUpDown nUD_repeat;
        internal System.Windows.Forms.RadioButton rB_weight;
        internal System.Windows.Forms.RadioButton rB_garanteed;
    }
}