namespace Siyosyus_V3._0
{
    partial class Pedal
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
            this.components = new System.ComponentModel.Container();
            this.checkBoxMinor = new System.Windows.Forms.CheckBox();
            this.checkBoxMana = new System.Windows.Forms.CheckBox();
            this.checkBoxHpMp = new System.Windows.Forms.CheckBox();
            this.checkBoxOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxDark = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timerMinor = new System.Windows.Forms.Timer(this.components);
            this.timerMana = new System.Windows.Forms.Timer(this.components);
            this.timer2Mp1Hp = new System.Windows.Forms.Timer(this.components);
            this.timerPedalOnOff = new System.Windows.Forms.Timer(this.components);
            this.checkBoxRCombo = new System.Windows.Forms.CheckBox();
            this.timerRCombo = new System.Windows.Forms.Timer(this.components);
            this.timerSkills = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // checkBoxMinor
            // 
            this.checkBoxMinor.AutoSize = true;
            this.checkBoxMinor.Location = new System.Drawing.Point(12, 48);
            this.checkBoxMinor.Name = "checkBoxMinor";
            this.checkBoxMinor.Size = new System.Drawing.Size(58, 19);
            this.checkBoxMinor.TabIndex = 0;
            this.checkBoxMinor.Text = "Minor";
            this.checkBoxMinor.UseVisualStyleBackColor = true;
            // 
            // checkBoxMana
            // 
            this.checkBoxMana.AutoSize = true;
            this.checkBoxMana.Location = new System.Drawing.Point(12, 73);
            this.checkBoxMana.Name = "checkBoxMana";
            this.checkBoxMana.Size = new System.Drawing.Size(94, 19);
            this.checkBoxMana.TabIndex = 1;
            this.checkBoxMana.Text = "Mana Potion";
            this.checkBoxMana.UseVisualStyleBackColor = true;
            // 
            // checkBoxHpMp
            // 
            this.checkBoxHpMp.AutoSize = true;
            this.checkBoxHpMp.Location = new System.Drawing.Point(12, 98);
            this.checkBoxHpMp.Name = "checkBoxHpMp";
            this.checkBoxHpMp.Size = new System.Drawing.Size(75, 19);
            this.checkBoxHpMp.TabIndex = 2;
            this.checkBoxHpMp.Text = "2Mp 1Hp";
            this.checkBoxHpMp.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnTop
            // 
            this.checkBoxOnTop.AutoSize = true;
            this.checkBoxOnTop.Location = new System.Drawing.Point(12, 3);
            this.checkBoxOnTop.Name = "checkBoxOnTop";
            this.checkBoxOnTop.Size = new System.Drawing.Size(64, 19);
            this.checkBoxOnTop.TabIndex = 3;
            this.checkBoxOnTop.Text = "On Top";
            this.checkBoxOnTop.UseVisualStyleBackColor = true;
            this.checkBoxOnTop.CheckedChanged += new System.EventHandler(this.checkBoxOnTop_CheckedChanged);
            // 
            // checkBoxDark
            // 
            this.checkBoxDark.AutoSize = true;
            this.checkBoxDark.Location = new System.Drawing.Point(212, 3);
            this.checkBoxDark.Name = "checkBoxDark";
            this.checkBoxDark.Size = new System.Drawing.Size(50, 19);
            this.checkBoxDark.TabIndex = 4;
            this.checkBoxDark.Text = "Dark";
            this.checkBoxDark.UseVisualStyleBackColor = true;
            this.checkBoxDark.CheckedChanged += new System.EventHandler(this.checkBoxDark_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(193, 98);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timerMinor
            // 
            this.timerMinor.Tick += new System.EventHandler(this.timerMinor_Tick);
            // 
            // timerMana
            // 
            this.timerMana.Tick += new System.EventHandler(this.timerMana_Tick);
            // 
            // timer2Mp1Hp
            // 
            this.timer2Mp1Hp.Tick += new System.EventHandler(this.timer2Mp1Hp_Tick);
            // 
            // timerPedalOnOff
            // 
            this.timerPedalOnOff.Tick += new System.EventHandler(this.timerPedalOnOff_Tick);
            // 
            // checkBoxRCombo
            // 
            this.checkBoxRCombo.AutoSize = true;
            this.checkBoxRCombo.Location = new System.Drawing.Point(186, 28);
            this.checkBoxRCombo.Name = "checkBoxRCombo";
            this.checkBoxRCombo.Size = new System.Drawing.Size(76, 19);
            this.checkBoxRCombo.TabIndex = 6;
            this.checkBoxRCombo.Text = "R Combo";
            this.checkBoxRCombo.UseVisualStyleBackColor = true;
            // 
            // timerRCombo
            // 
            this.timerRCombo.Tick += new System.EventHandler(this.timerRCombo_Tick);
            // 
            // Pedal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(274, 129);
            this.Controls.Add(this.checkBoxRCombo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.checkBoxDark);
            this.Controls.Add(this.checkBoxOnTop);
            this.Controls.Add(this.checkBoxHpMp);
            this.Controls.Add(this.checkBoxMana);
            this.Controls.Add(this.checkBoxMinor);
            this.Name = "Pedal";
            this.Text = "Pedal";
            this.Load += new System.EventHandler(this.Pedal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMinor;
        private System.Windows.Forms.CheckBox checkBoxMana;
        private System.Windows.Forms.CheckBox checkBoxHpMp;
        private System.Windows.Forms.CheckBox checkBoxOnTop;
        private System.Windows.Forms.CheckBox checkBoxDark;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timerMinor;
        private System.Windows.Forms.Timer timerMana;
        private System.Windows.Forms.Timer timer2Mp1Hp;
        private System.Windows.Forms.Timer timerPedalOnOff;
        private System.Windows.Forms.CheckBox checkBoxRCombo;
        private System.Windows.Forms.Timer timerRCombo;
        private System.Windows.Forms.Timer timerSkills;
    }
}