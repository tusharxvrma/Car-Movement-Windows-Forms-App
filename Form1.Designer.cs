namespace prg455Assignment2
{
    partial class Form1
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
            this.radBtnLength = new System.Windows.Forms.RadioButton();
            this.radBtnMass = new System.Windows.Forms.RadioButton();
            this.radBtnTemp = new System.Windows.Forms.RadioButton();
            this.grpBoxUnits = new System.Windows.Forms.GroupBox();
            this.grpBoxFrom = new System.Windows.Forms.GroupBox();
            this.grpBoxTo = new System.Windows.Forms.GroupBox();
            this.comBoxFrom = new System.Windows.Forms.ComboBox();
            this.comBoxTo = new System.Windows.Forms.ComboBox();
            this.txtBoxFrom = new System.Windows.Forms.TextBox();
            this.txtBoxTo = new System.Windows.Forms.TextBox();
            this.menuStripResetExit = new System.Windows.Forms.MenuStrip();
            this.resetMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxUnits.SuspendLayout();
            this.grpBoxFrom.SuspendLayout();
            this.grpBoxTo.SuspendLayout();
            this.menuStripResetExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // radBtnLength
            // 
            this.radBtnLength.AutoSize = true;
            this.radBtnLength.Location = new System.Drawing.Point(43, 44);
            this.radBtnLength.Name = "radBtnLength";
            this.radBtnLength.Size = new System.Drawing.Size(58, 17);
            this.radBtnLength.TabIndex = 0;
            this.radBtnLength.TabStop = true;
            this.radBtnLength.Text = "Length";
            this.radBtnLength.UseVisualStyleBackColor = true;
            this.radBtnLength.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radBtnMass
            // 
            this.radBtnMass.AutoSize = true;
            this.radBtnMass.Location = new System.Drawing.Point(43, 81);
            this.radBtnMass.Name = "radBtnMass";
            this.radBtnMass.Size = new System.Drawing.Size(50, 17);
            this.radBtnMass.TabIndex = 1;
            this.radBtnMass.TabStop = true;
            this.radBtnMass.Text = "Mass";
            this.radBtnMass.UseVisualStyleBackColor = true;
            this.radBtnMass.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radBtnTemp
            // 
            this.radBtnTemp.AutoSize = true;
            this.radBtnTemp.Location = new System.Drawing.Point(43, 117);
            this.radBtnTemp.Name = "radBtnTemp";
            this.radBtnTemp.Size = new System.Drawing.Size(79, 17);
            this.radBtnTemp.TabIndex = 2;
            this.radBtnTemp.TabStop = true;
            this.radBtnTemp.Text = "Temprature";
            this.radBtnTemp.UseVisualStyleBackColor = true;
            this.radBtnTemp.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // grpBoxUnits
            // 
            this.grpBoxUnits.BackColor = System.Drawing.Color.Silver;
            this.grpBoxUnits.Controls.Add(this.radBtnLength);
            this.grpBoxUnits.Controls.Add(this.radBtnTemp);
            this.grpBoxUnits.Controls.Add(this.radBtnMass);
            this.grpBoxUnits.Location = new System.Drawing.Point(53, 145);
            this.grpBoxUnits.Name = "grpBoxUnits";
            this.grpBoxUnits.Size = new System.Drawing.Size(256, 168);
            this.grpBoxUnits.TabIndex = 3;
            this.grpBoxUnits.TabStop = false;
            this.grpBoxUnits.Text = "Select Units:";
            this.grpBoxUnits.Enter += new System.EventHandler(this.grpBoxUnits_Enter);
            // 
            // grpBoxFrom
            // 
            this.grpBoxFrom.BackColor = System.Drawing.Color.Silver;
            this.grpBoxFrom.Controls.Add(this.comBoxFrom);
            this.grpBoxFrom.Controls.Add(this.txtBoxFrom);
            this.grpBoxFrom.Location = new System.Drawing.Point(353, 106);
            this.grpBoxFrom.Name = "grpBoxFrom";
            this.grpBoxFrom.Size = new System.Drawing.Size(376, 100);
            this.grpBoxFrom.TabIndex = 3;
            this.grpBoxFrom.TabStop = false;
            this.grpBoxFrom.Text = "Convert From";
            this.grpBoxFrom.Enter += new System.EventHandler(this.grpBoxFrom_Enter);
            // 
            // grpBoxTo
            // 
            this.grpBoxTo.BackColor = System.Drawing.Color.Silver;
            this.grpBoxTo.Controls.Add(this.txtBoxTo);
            this.grpBoxTo.Controls.Add(this.comBoxTo);
            this.grpBoxTo.Location = new System.Drawing.Point(353, 262);
            this.grpBoxTo.Name = "grpBoxTo";
            this.grpBoxTo.Size = new System.Drawing.Size(376, 100);
            this.grpBoxTo.TabIndex = 0;
            this.grpBoxTo.TabStop = false;
            this.grpBoxTo.Text = "Convert To";
            this.grpBoxTo.Enter += new System.EventHandler(this.grpBoxTo_Enter);
            // 
            // comBoxFrom
            // 
            this.comBoxFrom.FormattingEnabled = true;
            this.comBoxFrom.Location = new System.Drawing.Point(41, 39);
            this.comBoxFrom.Name = "comBoxFrom";
            this.comBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comBoxFrom.TabIndex = 4;
            this.comBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comBoxFrom_SelectedIndexChanged);
            // 
            // comBoxTo
            // 
            this.comBoxTo.FormattingEnabled = true;
            this.comBoxTo.Location = new System.Drawing.Point(41, 42);
            this.comBoxTo.Name = "comBoxTo";
            this.comBoxTo.Size = new System.Drawing.Size(121, 21);
            this.comBoxTo.TabIndex = 5;
            this.comBoxTo.SelectedIndexChanged += new System.EventHandler(this.comBoxTo_SelectedIndexChanged);
            // 
            // txtBoxFrom
            // 
            this.txtBoxFrom.Location = new System.Drawing.Point(219, 40);
            this.txtBoxFrom.Name = "txtBoxFrom";
            this.txtBoxFrom.Size = new System.Drawing.Size(121, 20);
            this.txtBoxFrom.TabIndex = 6;
            this.txtBoxFrom.TextChanged += new System.EventHandler(this.txtBoxFrom_TextChanged);
            // 
            // txtBoxTo
            // 
            this.txtBoxTo.Location = new System.Drawing.Point(219, 43);
            this.txtBoxTo.Name = "txtBoxTo";
            this.txtBoxTo.Size = new System.Drawing.Size(121, 20);
            this.txtBoxTo.TabIndex = 7;
            this.txtBoxTo.TextChanged += new System.EventHandler(this.txtBoxTo_TextChanged);
            // 
            // menuStripResetExit
            // 
            this.menuStripResetExit.BackColor = System.Drawing.Color.Silver;
            this.menuStripResetExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMenuStrip,
            this.exitMenuStrip});
            this.menuStripResetExit.Location = new System.Drawing.Point(0, 0);
            this.menuStripResetExit.Name = "menuStripResetExit";
            this.menuStripResetExit.Size = new System.Drawing.Size(800, 24);
            this.menuStripResetExit.TabIndex = 4;
            this.menuStripResetExit.Text = "menuStrip1";
            // 
            // resetMenuStrip
            // 
            this.resetMenuStrip.Name = "resetMenuStrip";
            this.resetMenuStrip.Size = new System.Drawing.Size(47, 20);
            this.resetMenuStrip.Text = "Reset";
            this.resetMenuStrip.Click += new System.EventHandler(this.resetMenuStrip_Click);
            // 
            // exitMenuStrip
            // 
            this.exitMenuStrip.Name = "exitMenuStrip";
            this.exitMenuStrip.Size = new System.Drawing.Size(38, 20);
            this.exitMenuStrip.Text = "Exit";
            this.exitMenuStrip.Click += new System.EventHandler(this.exitMenuStrip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxFrom);
            this.Controls.Add(this.grpBoxTo);
            this.Controls.Add(this.grpBoxUnits);
            this.Controls.Add(this.menuStripResetExit);
            this.MainMenuStrip = this.menuStripResetExit;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxUnits.ResumeLayout(false);
            this.grpBoxUnits.PerformLayout();
            this.grpBoxFrom.ResumeLayout(false);
            this.grpBoxFrom.PerformLayout();
            this.grpBoxTo.ResumeLayout(false);
            this.grpBoxTo.PerformLayout();
            this.menuStripResetExit.ResumeLayout(false);
            this.menuStripResetExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnLength;
        private System.Windows.Forms.RadioButton radBtnMass;
        private System.Windows.Forms.RadioButton radBtnTemp;
        private System.Windows.Forms.GroupBox grpBoxUnits;
        private System.Windows.Forms.GroupBox grpBoxFrom;
        private System.Windows.Forms.ComboBox comBoxFrom;
        private System.Windows.Forms.TextBox txtBoxFrom;
        private System.Windows.Forms.GroupBox grpBoxTo;
        private System.Windows.Forms.TextBox txtBoxTo;
        private System.Windows.Forms.ComboBox comBoxTo;
        private System.Windows.Forms.MenuStrip menuStripResetExit;
        private System.Windows.Forms.ToolStripMenuItem resetMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitMenuStrip;
    }
}

