namespace Mohamedfageeh
{
    partial class frmRadio
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radYellow = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rodBlue = new System.Windows.Forms.RadioButton();
            this.rodGreen = new System.Windows.Forms.RadioButton();
            this.rodGreen1 = new System.Windows.Forms.RadioButton();
            this.rodBlue1 = new System.Windows.Forms.RadioButton();
            this.rodRed1 = new System.Windows.Forms.RadioButton();
            this.rodYellow1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(214, 271);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 34);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(460, 349);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radYellow);
            this.groupBox1.Controls.Add(this.rdoRed);
            this.groupBox1.Controls.Add(this.rodBlue);
            this.groupBox1.Controls.Add(this.rodGreen);
            this.groupBox1.Location = new System.Drawing.Point(264, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(203, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio Buttons";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radYellow
            // 
            this.radYellow.AutoSize = true;
            this.radYellow.Location = new System.Drawing.Point(22, 97);
            this.radYellow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radYellow.Name = "radYellow";
            this.radYellow.Size = new System.Drawing.Size(56, 17);
            this.radYellow.TabIndex = 0;
            this.radYellow.TabStop = true;
            this.radYellow.Text = "Yellow";
            this.radYellow.UseVisualStyleBackColor = true;
            this.radYellow.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(22, 31);
            this.rdoRed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 17);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rodBlue
            // 
            this.rodBlue.AutoSize = true;
            this.rodBlue.Location = new System.Drawing.Point(22, 75);
            this.rodBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rodBlue.Name = "rodBlue";
            this.rodBlue.Size = new System.Drawing.Size(46, 17);
            this.rodBlue.TabIndex = 0;
            this.rodBlue.TabStop = true;
            this.rodBlue.Text = "Blue";
            this.rodBlue.UseVisualStyleBackColor = true;
            this.rodBlue.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rodGreen
            // 
            this.rodGreen.AutoSize = true;
            this.rodGreen.Location = new System.Drawing.Point(22, 53);
            this.rodGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rodGreen.Name = "rodGreen";
            this.rodGreen.Size = new System.Drawing.Size(54, 17);
            this.rodGreen.TabIndex = 0;
            this.rodGreen.TabStop = true;
            this.rodGreen.Text = "Green";
            this.rodGreen.UseVisualStyleBackColor = true;
            this.rodGreen.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rodGreen1
            // 
            this.rodGreen1.AutoSize = true;
            this.rodGreen1.Location = new System.Drawing.Point(120, 119);
            this.rodGreen1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rodGreen1.Name = "rodGreen1";
            this.rodGreen1.Size = new System.Drawing.Size(54, 17);
            this.rodGreen1.TabIndex = 0;
            this.rodGreen1.TabStop = true;
            this.rodGreen1.Text = "Green";
            this.rodGreen1.UseVisualStyleBackColor = true;
            this.rodGreen1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rodBlue1
            // 
            this.rodBlue1.AutoSize = true;
            this.rodBlue1.Location = new System.Drawing.Point(120, 97);
            this.rodBlue1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rodBlue1.Name = "rodBlue1";
            this.rodBlue1.Size = new System.Drawing.Size(46, 17);
            this.rodBlue1.TabIndex = 0;
            this.rodBlue1.TabStop = true;
            this.rodBlue1.Text = "Blue";
            this.rodBlue1.UseVisualStyleBackColor = true;
            this.rodBlue1.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rodRed1
            // 
            this.rodRed1.AutoSize = true;
            this.rodRed1.Location = new System.Drawing.Point(120, 141);
            this.rodRed1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rodRed1.Name = "rodRed1";
            this.rodRed1.Size = new System.Drawing.Size(45, 17);
            this.rodRed1.TabIndex = 0;
            this.rodRed1.TabStop = true;
            this.rodRed1.Text = "Red";
            this.rodRed1.UseVisualStyleBackColor = true;
            this.rodRed1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rodYellow1
            // 
            this.rodYellow1.AutoSize = true;
            this.rodYellow1.Location = new System.Drawing.Point(120, 162);
            this.rodYellow1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rodYellow1.Name = "rodYellow1";
            this.rodYellow1.Size = new System.Drawing.Size(56, 17);
            this.rodYellow1.TabIndex = 0;
            this.rodYellow1.TabStop = true;
            this.rodYellow1.Text = "Yellow";
            this.rodYellow1.UseVisualStyleBackColor = true;
            this.rodYellow1.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(580, 410);
            this.Controls.Add(this.rodYellow1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rodBlue1);
            this.Controls.Add(this.rodRed1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rodGreen1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRadio";
            this.Text = "Radio";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radYellow;
        private System.Windows.Forms.RadioButton rodBlue;
        private System.Windows.Forms.RadioButton rodGreen;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rodYellow1;
        private System.Windows.Forms.RadioButton rodRed1;
        private System.Windows.Forms.RadioButton rodBlue1;
        private System.Windows.Forms.RadioButton rodGreen1;
    }
}