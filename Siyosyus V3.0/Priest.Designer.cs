
namespace Siyosyus_V3._0
{
    partial class Priest
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
            this.buttonPriestFormExit = new System.Windows.Forms.Button();
            this.checkBoxBuff = new System.Windows.Forms.CheckBox();
            this.checkBoxAc = new System.Windows.Forms.CheckBox();
            this.checkBoxHp = new System.Windows.Forms.CheckBox();
            this.trackBarHp = new System.Windows.Forms.TrackBar();
            this.labelHpBar = new System.Windows.Forms.Label();
            this.checkBoxMp = new System.Windows.Forms.CheckBox();
            this.trackBarMp = new System.Windows.Forms.TrackBar();
            this.labelMpBar = new System.Windows.Forms.Label();
            this.timerBuff = new System.Windows.Forms.Timer(this.components);
            this.timerAc = new System.Windows.Forms.Timer(this.components);
            this.timerPriestOnOff = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxHpPot = new System.Windows.Forms.PictureBox();
            this.timerHpPot = new System.Windows.Forms.Timer(this.components);
            this.timerMpPot = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxMpPot = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPriestOnTop = new System.Windows.Forms.CheckBox();
            this.timerHideShow = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPriestDark = new System.Windows.Forms.CheckBox();
            this.timerTAB = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHpPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMpPot)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPriestFormExit
            // 
            this.buttonPriestFormExit.Location = new System.Drawing.Point(258, 245);
            this.buttonPriestFormExit.Name = "buttonPriestFormExit";
            this.buttonPriestFormExit.Size = new System.Drawing.Size(75, 23);
            this.buttonPriestFormExit.TabIndex = 0;
            this.buttonPriestFormExit.Text = "Exit";
            this.buttonPriestFormExit.UseVisualStyleBackColor = true;
            this.buttonPriestFormExit.Click += new System.EventHandler(this.buttonPriestFormBack_Click);
            // 
            // checkBoxBuff
            // 
            this.checkBoxBuff.AutoSize = true;
            this.checkBoxBuff.Location = new System.Drawing.Point(26, 44);
            this.checkBoxBuff.Name = "checkBoxBuff";
            this.checkBoxBuff.Size = new System.Drawing.Size(109, 19);
            this.checkBoxBuff.TabIndex = 1;
            this.checkBoxBuff.Text = "Buff (Skill Bar 1)";
            this.checkBoxBuff.UseVisualStyleBackColor = true;
            // 
            // checkBoxAc
            // 
            this.checkBoxAc.AutoSize = true;
            this.checkBoxAc.Location = new System.Drawing.Point(26, 69);
            this.checkBoxAc.Name = "checkBoxAc";
            this.checkBoxAc.Size = new System.Drawing.Size(101, 19);
            this.checkBoxAc.TabIndex = 2;
            this.checkBoxAc.Text = "Ac (Skill Bar 2)";
            this.checkBoxAc.UseVisualStyleBackColor = true;
            // 
            // checkBoxHp
            // 
            this.checkBoxHp.AutoSize = true;
            this.checkBoxHp.Location = new System.Drawing.Point(26, 105);
            this.checkBoxHp.Name = "checkBoxHp";
            this.checkBoxHp.Size = new System.Drawing.Size(127, 19);
            this.checkBoxHp.TabIndex = 3;
            this.checkBoxHp.Text = "Hp Pot ( Skill bar 9)";
            this.checkBoxHp.UseVisualStyleBackColor = true;
            // 
            // trackBarHp
            // 
            this.trackBarHp.Location = new System.Drawing.Point(23, 130);
            this.trackBarHp.Maximum = 95;
            this.trackBarHp.Name = "trackBarHp";
            this.trackBarHp.Size = new System.Drawing.Size(283, 45);
            this.trackBarHp.TabIndex = 4;
            this.trackBarHp.Scroll += new System.EventHandler(this.trackBarHp_Scroll);
            // 
            // labelHpBar
            // 
            this.labelHpBar.AutoSize = true;
            this.labelHpBar.Location = new System.Drawing.Point(222, 106);
            this.labelHpBar.Name = "labelHpBar";
            this.labelHpBar.Size = new System.Drawing.Size(13, 15);
            this.labelHpBar.TabIndex = 5;
            this.labelHpBar.Text = "0";
            // 
            // checkBoxMp
            // 
            this.checkBoxMp.AutoSize = true;
            this.checkBoxMp.Location = new System.Drawing.Point(26, 165);
            this.checkBoxMp.Name = "checkBoxMp";
            this.checkBoxMp.Size = new System.Drawing.Size(126, 19);
            this.checkBoxMp.TabIndex = 6;
            this.checkBoxMp.Text = "Mp Pot (Skill Bar 0)";
            this.checkBoxMp.UseVisualStyleBackColor = true;
            // 
            // trackBarMp
            // 
            this.trackBarMp.Location = new System.Drawing.Point(26, 189);
            this.trackBarMp.Maximum = 95;
            this.trackBarMp.Name = "trackBarMp";
            this.trackBarMp.Size = new System.Drawing.Size(283, 45);
            this.trackBarMp.TabIndex = 7;
            this.trackBarMp.Scroll += new System.EventHandler(this.trackBarMp_Scroll);
            // 
            // labelMpBar
            // 
            this.labelMpBar.AutoSize = true;
            this.labelMpBar.Location = new System.Drawing.Point(222, 167);
            this.labelMpBar.Name = "labelMpBar";
            this.labelMpBar.Size = new System.Drawing.Size(13, 15);
            this.labelMpBar.TabIndex = 8;
            this.labelMpBar.Text = "0";
            // 
            // timerBuff
            // 
            this.timerBuff.Interval = 1000;
            this.timerBuff.Tick += new System.EventHandler(this.timerBuff_Tick);
            // 
            // timerAc
            // 
            this.timerAc.Interval = 1000;
            this.timerAc.Tick += new System.EventHandler(this.timerAc_Tick);
            // 
            // timerPriestOnOff
            // 
            this.timerPriestOnOff.Interval = 1;
            this.timerPriestOnOff.Tick += new System.EventHandler(this.timerPriestOnOff_Tick);
            // 
            // pictureBoxHpPot
            // 
            this.pictureBoxHpPot.Location = new System.Drawing.Point(284, -2);
            this.pictureBoxHpPot.Name = "pictureBoxHpPot";
            this.pictureBoxHpPot.Size = new System.Drawing.Size(49, 31);
            this.pictureBoxHpPot.TabIndex = 10;
            this.pictureBoxHpPot.TabStop = false;
            this.pictureBoxHpPot.Visible = false;
            // 
            // timerHpPot
            // 
            this.timerHpPot.Tick += new System.EventHandler(this.timerHpPot_Tick);
            // 
            // timerMpPot
            // 
            this.timerMpPot.Tick += new System.EventHandler(this.timerMpPot_Tick);
            // 
            // pictureBoxMpPot
            // 
            this.pictureBoxMpPot.Location = new System.Drawing.Point(284, 22);
            this.pictureBoxMpPot.Name = "pictureBoxMpPot";
            this.pictureBoxMpPot.Size = new System.Drawing.Size(49, 31);
            this.pictureBoxMpPot.TabIndex = 11;
            this.pictureBoxMpPot.TabStop = false;
            this.pictureBoxMpPot.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "%";
            // 
            // checkBoxPriestOnTop
            // 
            this.checkBoxPriestOnTop.AutoSize = true;
            this.checkBoxPriestOnTop.Location = new System.Drawing.Point(0, 0);
            this.checkBoxPriestOnTop.Name = "checkBoxPriestOnTop";
            this.checkBoxPriestOnTop.Size = new System.Drawing.Size(64, 19);
            this.checkBoxPriestOnTop.TabIndex = 14;
            this.checkBoxPriestOnTop.Text = "On Top";
            this.checkBoxPriestOnTop.UseVisualStyleBackColor = true;
            this.checkBoxPriestOnTop.CheckedChanged += new System.EventHandler(this.checkBoxPriestOnTop_CheckedChanged);
            // 
            // timerHideShow
            // 
            this.timerHideShow.Tick += new System.EventHandler(this.timerHideShow_Tick);
            // 
            // checkBoxPriestDark
            // 
            this.checkBoxPriestDark.AutoSize = true;
            this.checkBoxPriestDark.Location = new System.Drawing.Point(286, 0);
            this.checkBoxPriestDark.Name = "checkBoxPriestDark";
            this.checkBoxPriestDark.Size = new System.Drawing.Size(50, 19);
            this.checkBoxPriestDark.TabIndex = 15;
            this.checkBoxPriestDark.Text = "Dark";
            this.checkBoxPriestDark.UseVisualStyleBackColor = true;
            this.checkBoxPriestDark.CheckedChanged += new System.EventHandler(this.checkBoxPriestDark_CheckedChanged);
            // 
            // timerTAB
            // 
            this.timerTAB.Tick += new System.EventHandler(this.timerTAB_Tick);
            // 
            // Priest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 269);
            this.Controls.Add(this.checkBoxPriestDark);
            this.Controls.Add(this.checkBoxPriestOnTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMpPot);
            this.Controls.Add(this.pictureBoxHpPot);
            this.Controls.Add(this.labelMpBar);
            this.Controls.Add(this.trackBarMp);
            this.Controls.Add(this.checkBoxMp);
            this.Controls.Add(this.labelHpBar);
            this.Controls.Add(this.trackBarHp);
            this.Controls.Add(this.checkBoxHp);
            this.Controls.Add(this.checkBoxAc);
            this.Controls.Add(this.checkBoxBuff);
            this.Controls.Add(this.buttonPriestFormExit);
            this.Name = "Priest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Priest";
            this.Load += new System.EventHandler(this.Priest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHpPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMpPot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPriestFormExit;
        private System.Windows.Forms.CheckBox checkBoxBuff;
        private System.Windows.Forms.CheckBox checkBoxAc;
        private System.Windows.Forms.CheckBox checkBoxHp;
        private System.Windows.Forms.TrackBar trackBarHp;
        private System.Windows.Forms.Label labelHpBar;
        private System.Windows.Forms.CheckBox checkBoxMp;
        private System.Windows.Forms.TrackBar trackBarMp;
        private System.Windows.Forms.Label labelMpBar;
        private System.Windows.Forms.Timer timerBuff;
        private System.Windows.Forms.Timer timerAc;
        private System.Windows.Forms.Timer timerPriestOnOff;
        private System.Windows.Forms.PictureBox pictureBoxHpPot;
        private System.Windows.Forms.Timer timerHpPot;
        private System.Windows.Forms.Timer timerMpPot;
        private System.Windows.Forms.PictureBox pictureBoxMpPot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPriestOnTop;
        private System.Windows.Forms.Timer timerHideShow;
        private System.Windows.Forms.CheckBox checkBoxPriestDark;
        private System.Windows.Forms.Timer timerTAB;
    }
}