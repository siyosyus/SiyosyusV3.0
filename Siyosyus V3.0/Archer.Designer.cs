
namespace Siyosyus_V3._0
{
    partial class Archer
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
            this.buttonArcherFormExit = new System.Windows.Forms.Button();
            this.checkBoxArcherOnTop = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAttack = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarAttackSpeed = new System.Windows.Forms.TrackBar();
            this.labelAttackSpeed = new System.Windows.Forms.Label();
            this.checkBoxSkill3 = new System.Windows.Forms.CheckBox();
            this.checkBoxSkill2 = new System.Windows.Forms.CheckBox();
            this.checkBoxSkill1 = new System.Windows.Forms.CheckBox();
            this.checkBoxChooseMob = new System.Windows.Forms.CheckBox();
            this.tabPageSupport = new System.Windows.Forms.TabPage();
            this.checkBoxRight = new System.Windows.Forms.CheckBox();
            this.checkBoxLeft = new System.Windows.Forms.CheckBox();
            this.pictureInvControl2 = new System.Windows.Forms.PictureBox();
            this.pictureInvControl1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxPetFeeding = new System.Windows.Forms.PictureBox();
            this.pictureBoxMagicHammer = new System.Windows.Forms.PictureBox();
            this.checkBoxPetFeeding = new System.Windows.Forms.CheckBox();
            this.checkBoxMagicHammer = new System.Windows.Forms.CheckBox();
            this.checkBoxDefence2 = new System.Windows.Forms.CheckBox();
            this.checkBoxDefence1 = new System.Windows.Forms.CheckBox();
            this.checkBoxWolf = new System.Windows.Forms.CheckBox();
            this.tabPagePotion = new System.Windows.Forms.TabPage();
            this.pictureBoxMpPot = new System.Windows.Forms.PictureBox();
            this.pictureBoxHpPot = new System.Windows.Forms.PictureBox();
            this.trackBarMp = new System.Windows.Forms.TrackBar();
            this.labelMpBar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxMpPot = new System.Windows.Forms.CheckBox();
            this.trackBarHp = new System.Windows.Forms.TrackBar();
            this.labelHpBar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxHpPot = new System.Windows.Forms.CheckBox();
            this.checkBoxArcherDark = new System.Windows.Forms.CheckBox();
            this.timerChooseMob = new System.Windows.Forms.Timer(this.components);
            this.timerSkill1 = new System.Windows.Forms.Timer(this.components);
            this.timerSkill2 = new System.Windows.Forms.Timer(this.components);
            this.timerSkill3 = new System.Windows.Forms.Timer(this.components);
            this.timerArcherOnOff = new System.Windows.Forms.Timer(this.components);
            this.timerWolf = new System.Windows.Forms.Timer(this.components);
            this.timerdef1 = new System.Windows.Forms.Timer(this.components);
            this.timerdef2 = new System.Windows.Forms.Timer(this.components);
            this.timerHpPot = new System.Windows.Forms.Timer(this.components);
            this.timerMpPot = new System.Windows.Forms.Timer(this.components);
            this.timerHideShow = new System.Windows.Forms.Timer(this.components);
            this.timerWolfCounter = new System.Windows.Forms.Timer(this.components);
            this.timerMagicHammer = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timerPetFeeding = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAttack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAttackSpeed)).BeginInit();
            this.tabPageSupport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInvControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInvControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetFeeding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagicHammer)).BeginInit();
            this.tabPagePotion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMpPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHpPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonArcherFormExit
            // 
            this.buttonArcherFormExit.Location = new System.Drawing.Point(308, 288);
            this.buttonArcherFormExit.Name = "buttonArcherFormExit";
            this.buttonArcherFormExit.Size = new System.Drawing.Size(75, 23);
            this.buttonArcherFormExit.TabIndex = 0;
            this.buttonArcherFormExit.Text = "Exit";
            this.buttonArcherFormExit.UseVisualStyleBackColor = true;
            this.buttonArcherFormExit.Click += new System.EventHandler(this.buttonArcherFormBack_Click);
            // 
            // checkBoxArcherOnTop
            // 
            this.checkBoxArcherOnTop.AutoSize = true;
            this.checkBoxArcherOnTop.Location = new System.Drawing.Point(1, 2);
            this.checkBoxArcherOnTop.Name = "checkBoxArcherOnTop";
            this.checkBoxArcherOnTop.Size = new System.Drawing.Size(64, 19);
            this.checkBoxArcherOnTop.TabIndex = 1;
            this.checkBoxArcherOnTop.Text = "On Top";
            this.checkBoxArcherOnTop.UseVisualStyleBackColor = true;
            this.checkBoxArcherOnTop.CheckedChanged += new System.EventHandler(this.checkBoxArcherOnTop_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAttack);
            this.tabControl1.Controls.Add(this.tabPageSupport);
            this.tabControl1.Controls.Add(this.tabPagePotion);
            this.tabControl1.Location = new System.Drawing.Point(1, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 261);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageAttack
            // 
            this.tabPageAttack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageAttack.Controls.Add(this.label2);
            this.tabPageAttack.Controls.Add(this.label1);
            this.tabPageAttack.Controls.Add(this.trackBarAttackSpeed);
            this.tabPageAttack.Controls.Add(this.labelAttackSpeed);
            this.tabPageAttack.Controls.Add(this.checkBoxSkill3);
            this.tabPageAttack.Controls.Add(this.checkBoxSkill2);
            this.tabPageAttack.Controls.Add(this.checkBoxSkill1);
            this.tabPageAttack.Controls.Add(this.checkBoxChooseMob);
            this.tabPageAttack.Location = new System.Drawing.Point(4, 24);
            this.tabPageAttack.Name = "tabPageAttack";
            this.tabPageAttack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAttack.Size = new System.Drawing.Size(378, 233);
            this.tabPageAttack.TabIndex = 0;
            this.tabPageAttack.Text = "Attack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "(Slowest)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "(Fastest)";
            // 
            // trackBarAttackSpeed
            // 
            this.trackBarAttackSpeed.LargeChange = 500;
            this.trackBarAttackSpeed.Location = new System.Drawing.Point(8, 155);
            this.trackBarAttackSpeed.Maximum = 1000;
            this.trackBarAttackSpeed.Minimum = 2;
            this.trackBarAttackSpeed.Name = "trackBarAttackSpeed";
            this.trackBarAttackSpeed.Size = new System.Drawing.Size(364, 45);
            this.trackBarAttackSpeed.SmallChange = 500;
            this.trackBarAttackSpeed.TabIndex = 3;
            this.trackBarAttackSpeed.Value = 2;
            this.trackBarAttackSpeed.Scroll += new System.EventHandler(this.trackBarAttackSpeed_Scroll);
            // 
            // labelAttackSpeed
            // 
            this.labelAttackSpeed.AutoSize = true;
            this.labelAttackSpeed.Location = new System.Drawing.Point(7, 125);
            this.labelAttackSpeed.Name = "labelAttackSpeed";
            this.labelAttackSpeed.Size = new System.Drawing.Size(76, 15);
            this.labelAttackSpeed.TabIndex = 4;
            this.labelAttackSpeed.Text = "Attack Speed";
            // 
            // checkBoxSkill3
            // 
            this.checkBoxSkill3.AutoSize = true;
            this.checkBoxSkill3.Location = new System.Drawing.Point(7, 85);
            this.checkBoxSkill3.Name = "checkBoxSkill3";
            this.checkBoxSkill3.Size = new System.Drawing.Size(76, 19);
            this.checkBoxSkill3.TabIndex = 3;
            this.checkBoxSkill3.Text = "Skill Bar 3";
            this.checkBoxSkill3.UseVisualStyleBackColor = true;
            // 
            // checkBoxSkill2
            // 
            this.checkBoxSkill2.AutoSize = true;
            this.checkBoxSkill2.Location = new System.Drawing.Point(7, 59);
            this.checkBoxSkill2.Name = "checkBoxSkill2";
            this.checkBoxSkill2.Size = new System.Drawing.Size(76, 19);
            this.checkBoxSkill2.TabIndex = 2;
            this.checkBoxSkill2.Text = "Skill Bar 2";
            this.checkBoxSkill2.UseVisualStyleBackColor = true;
            // 
            // checkBoxSkill1
            // 
            this.checkBoxSkill1.AutoSize = true;
            this.checkBoxSkill1.Location = new System.Drawing.Point(7, 33);
            this.checkBoxSkill1.Name = "checkBoxSkill1";
            this.checkBoxSkill1.Size = new System.Drawing.Size(76, 19);
            this.checkBoxSkill1.TabIndex = 1;
            this.checkBoxSkill1.Text = "Skill Bar 1";
            this.checkBoxSkill1.UseVisualStyleBackColor = true;
            // 
            // checkBoxChooseMob
            // 
            this.checkBoxChooseMob.AutoSize = true;
            this.checkBoxChooseMob.Location = new System.Drawing.Point(7, 7);
            this.checkBoxChooseMob.Name = "checkBoxChooseMob";
            this.checkBoxChooseMob.Size = new System.Drawing.Size(94, 19);
            this.checkBoxChooseMob.TabIndex = 0;
            this.checkBoxChooseMob.Text = "Choose Mob";
            this.checkBoxChooseMob.UseVisualStyleBackColor = true;
            // 
            // tabPageSupport
            // 
            this.tabPageSupport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageSupport.Controls.Add(this.checkBoxRight);
            this.tabPageSupport.Controls.Add(this.checkBoxLeft);
            this.tabPageSupport.Controls.Add(this.pictureInvControl2);
            this.tabPageSupport.Controls.Add(this.pictureInvControl1);
            this.tabPageSupport.Controls.Add(this.label4);
            this.tabPageSupport.Controls.Add(this.pictureBoxPetFeeding);
            this.tabPageSupport.Controls.Add(this.pictureBoxMagicHammer);
            this.tabPageSupport.Controls.Add(this.checkBoxPetFeeding);
            this.tabPageSupport.Controls.Add(this.checkBoxMagicHammer);
            this.tabPageSupport.Controls.Add(this.checkBoxDefence2);
            this.tabPageSupport.Controls.Add(this.checkBoxDefence1);
            this.tabPageSupport.Controls.Add(this.checkBoxWolf);
            this.tabPageSupport.Location = new System.Drawing.Point(4, 24);
            this.tabPageSupport.Name = "tabPageSupport";
            this.tabPageSupport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupport.Size = new System.Drawing.Size(378, 233);
            this.tabPageSupport.TabIndex = 1;
            this.tabPageSupport.Text = "Support";
            // 
            // checkBoxRight
            // 
            this.checkBoxRight.AutoSize = true;
            this.checkBoxRight.Location = new System.Drawing.Point(162, 126);
            this.checkBoxRight.Name = "checkBoxRight";
            this.checkBoxRight.Size = new System.Drawing.Size(54, 19);
            this.checkBoxRight.TabIndex = 11;
            this.checkBoxRight.Text = "Right";
            this.checkBoxRight.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeft
            // 
            this.checkBoxLeft.AutoSize = true;
            this.checkBoxLeft.Location = new System.Drawing.Point(110, 126);
            this.checkBoxLeft.Name = "checkBoxLeft";
            this.checkBoxLeft.Size = new System.Drawing.Size(46, 19);
            this.checkBoxLeft.TabIndex = 10;
            this.checkBoxLeft.Text = "Left";
            this.checkBoxLeft.UseVisualStyleBackColor = true;
            // 
            // pictureInvControl2
            // 
            this.pictureInvControl2.Location = new System.Drawing.Point(179, 201);
            this.pictureInvControl2.Name = "pictureInvControl2";
            this.pictureInvControl2.Size = new System.Drawing.Size(44, 32);
            this.pictureInvControl2.TabIndex = 9;
            this.pictureInvControl2.TabStop = false;
            this.pictureInvControl2.Visible = false;
            // 
            // pictureInvControl1
            // 
            this.pictureInvControl1.Location = new System.Drawing.Point(229, 202);
            this.pictureInvControl1.Name = "pictureInvControl1";
            this.pictureInvControl1.Size = new System.Drawing.Size(44, 32);
            this.pictureInvControl1.TabIndex = 8;
            this.pictureInvControl1.TabStop = false;
            this.pictureInvControl1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // pictureBoxPetFeeding
            // 
            this.pictureBoxPetFeeding.Location = new System.Drawing.Point(0, 201);
            this.pictureBoxPetFeeding.Name = "pictureBoxPetFeeding";
            this.pictureBoxPetFeeding.Size = new System.Drawing.Size(44, 32);
            this.pictureBoxPetFeeding.TabIndex = 6;
            this.pictureBoxPetFeeding.TabStop = false;
            this.pictureBoxPetFeeding.Visible = false;
            // 
            // pictureBoxMagicHammer
            // 
            this.pictureBoxMagicHammer.Location = new System.Drawing.Point(0, 201);
            this.pictureBoxMagicHammer.Name = "pictureBoxMagicHammer";
            this.pictureBoxMagicHammer.Size = new System.Drawing.Size(44, 32);
            this.pictureBoxMagicHammer.TabIndex = 0;
            this.pictureBoxMagicHammer.TabStop = false;
            this.pictureBoxMagicHammer.Visible = false;
            // 
            // checkBoxPetFeeding
            // 
            this.checkBoxPetFeeding.AutoSize = true;
            this.checkBoxPetFeeding.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPetFeeding.Location = new System.Drawing.Point(1, 83);
            this.checkBoxPetFeeding.Name = "checkBoxPetFeeding";
            this.checkBoxPetFeeding.Size = new System.Drawing.Size(369, 17);
            this.checkBoxPetFeeding.TabIndex = 4;
            this.checkBoxPetFeeding.Text = "Pet Feeding (The leaf should be located at the top right in the inv.)";
            this.checkBoxPetFeeding.UseVisualStyleBackColor = true;
            // 
            // checkBoxMagicHammer
            // 
            this.checkBoxMagicHammer.AutoSize = true;
            this.checkBoxMagicHammer.Location = new System.Drawing.Point(0, 108);
            this.checkBoxMagicHammer.Name = "checkBoxMagicHammer";
            this.checkBoxMagicHammer.Size = new System.Drawing.Size(170, 19);
            this.checkBoxMagicHammer.TabIndex = 3;
            this.checkBoxMagicHammer.Text = "Magic Hammer (Skill Bar 7)";
            this.checkBoxMagicHammer.UseVisualStyleBackColor = true;
            // 
            // checkBoxDefence2
            // 
            this.checkBoxDefence2.AutoSize = true;
            this.checkBoxDefence2.Location = new System.Drawing.Point(0, 58);
            this.checkBoxDefence2.Name = "checkBoxDefence2";
            this.checkBoxDefence2.Size = new System.Drawing.Size(141, 19);
            this.checkBoxDefence2.TabIndex = 2;
            this.checkBoxDefence2.Text = "Defence-2 (Skill Bar 5)";
            this.checkBoxDefence2.UseVisualStyleBackColor = true;
            // 
            // checkBoxDefence1
            // 
            this.checkBoxDefence1.AutoSize = true;
            this.checkBoxDefence1.Location = new System.Drawing.Point(1, 32);
            this.checkBoxDefence1.Name = "checkBoxDefence1";
            this.checkBoxDefence1.Size = new System.Drawing.Size(141, 19);
            this.checkBoxDefence1.TabIndex = 1;
            this.checkBoxDefence1.Text = "Defence-1 (Skill Bar 4)";
            this.checkBoxDefence1.UseVisualStyleBackColor = true;
            // 
            // checkBoxWolf
            // 
            this.checkBoxWolf.AutoSize = true;
            this.checkBoxWolf.Location = new System.Drawing.Point(1, 6);
            this.checkBoxWolf.Name = "checkBoxWolf";
            this.checkBoxWolf.Size = new System.Drawing.Size(112, 19);
            this.checkBoxWolf.TabIndex = 0;
            this.checkBoxWolf.Text = "Wolf( Skill Bar 6)";
            this.checkBoxWolf.UseVisualStyleBackColor = true;
            // 
            // tabPagePotion
            // 
            this.tabPagePotion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPagePotion.Controls.Add(this.pictureBoxMpPot);
            this.tabPagePotion.Controls.Add(this.pictureBoxHpPot);
            this.tabPagePotion.Controls.Add(this.trackBarMp);
            this.tabPagePotion.Controls.Add(this.labelMpBar);
            this.tabPagePotion.Controls.Add(this.label5);
            this.tabPagePotion.Controls.Add(this.checkBoxMpPot);
            this.tabPagePotion.Controls.Add(this.trackBarHp);
            this.tabPagePotion.Controls.Add(this.labelHpBar);
            this.tabPagePotion.Controls.Add(this.label3);
            this.tabPagePotion.Controls.Add(this.checkBoxHpPot);
            this.tabPagePotion.Location = new System.Drawing.Point(4, 24);
            this.tabPagePotion.Name = "tabPagePotion";
            this.tabPagePotion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePotion.Size = new System.Drawing.Size(378, 233);
            this.tabPagePotion.TabIndex = 2;
            this.tabPagePotion.Text = "Potion";
            // 
            // pictureBoxMpPot
            // 
            this.pictureBoxMpPot.Location = new System.Drawing.Point(0, 201);
            this.pictureBoxMpPot.Name = "pictureBoxMpPot";
            this.pictureBoxMpPot.Size = new System.Drawing.Size(44, 32);
            this.pictureBoxMpPot.TabIndex = 9;
            this.pictureBoxMpPot.TabStop = false;
            this.pictureBoxMpPot.Visible = false;
            // 
            // pictureBoxHpPot
            // 
            this.pictureBoxHpPot.Location = new System.Drawing.Point(0, 201);
            this.pictureBoxHpPot.Name = "pictureBoxHpPot";
            this.pictureBoxHpPot.Size = new System.Drawing.Size(44, 32);
            this.pictureBoxHpPot.TabIndex = 8;
            this.pictureBoxHpPot.TabStop = false;
            this.pictureBoxHpPot.Visible = false;
            // 
            // trackBarMp
            // 
            this.trackBarMp.Location = new System.Drawing.Point(7, 106);
            this.trackBarMp.Maximum = 95;
            this.trackBarMp.Name = "trackBarMp";
            this.trackBarMp.Size = new System.Drawing.Size(295, 45);
            this.trackBarMp.TabIndex = 7;
            this.trackBarMp.Scroll += new System.EventHandler(this.trackBarMp_Scroll);
            // 
            // labelMpBar
            // 
            this.labelMpBar.AutoSize = true;
            this.labelMpBar.Location = new System.Drawing.Point(211, 84);
            this.labelMpBar.Name = "labelMpBar";
            this.labelMpBar.Size = new System.Drawing.Size(13, 15);
            this.labelMpBar.TabIndex = 6;
            this.labelMpBar.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "%";
            // 
            // checkBoxMpPot
            // 
            this.checkBoxMpPot.AutoSize = true;
            this.checkBoxMpPot.Location = new System.Drawing.Point(3, 81);
            this.checkBoxMpPot.Name = "checkBoxMpPot";
            this.checkBoxMpPot.Size = new System.Drawing.Size(126, 19);
            this.checkBoxMpPot.TabIndex = 4;
            this.checkBoxMpPot.Text = "Mp Pot (Skill Bar 9)";
            this.checkBoxMpPot.UseVisualStyleBackColor = true;
            // 
            // trackBarHp
            // 
            this.trackBarHp.Location = new System.Drawing.Point(7, 31);
            this.trackBarHp.Maximum = 95;
            this.trackBarHp.Name = "trackBarHp";
            this.trackBarHp.Size = new System.Drawing.Size(295, 45);
            this.trackBarHp.TabIndex = 3;
            this.trackBarHp.Scroll += new System.EventHandler(this.trackBarHp_Scroll);
            // 
            // labelHpBar
            // 
            this.labelHpBar.AutoSize = true;
            this.labelHpBar.Location = new System.Drawing.Point(211, 9);
            this.labelHpBar.Name = "labelHpBar";
            this.labelHpBar.Size = new System.Drawing.Size(13, 15);
            this.labelHpBar.TabIndex = 2;
            this.labelHpBar.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "%";
            // 
            // checkBoxHpPot
            // 
            this.checkBoxHpPot.AutoSize = true;
            this.checkBoxHpPot.Location = new System.Drawing.Point(3, 6);
            this.checkBoxHpPot.Name = "checkBoxHpPot";
            this.checkBoxHpPot.Size = new System.Drawing.Size(124, 19);
            this.checkBoxHpPot.TabIndex = 0;
            this.checkBoxHpPot.Text = "Hp Pot (Skill Bar 8)";
            this.checkBoxHpPot.UseVisualStyleBackColor = true;
            // 
            // checkBoxArcherDark
            // 
            this.checkBoxArcherDark.AutoSize = true;
            this.checkBoxArcherDark.Location = new System.Drawing.Point(333, 2);
            this.checkBoxArcherDark.Name = "checkBoxArcherDark";
            this.checkBoxArcherDark.Size = new System.Drawing.Size(50, 19);
            this.checkBoxArcherDark.TabIndex = 3;
            this.checkBoxArcherDark.Text = "Dark";
            this.checkBoxArcherDark.UseVisualStyleBackColor = true;
            this.checkBoxArcherDark.CheckedChanged += new System.EventHandler(this.checkBoxArcherDark_CheckedChanged);
            // 
            // timerChooseMob
            // 
            this.timerChooseMob.Tick += new System.EventHandler(this.timerChooseMob_Tick);
            // 
            // timerSkill1
            // 
            this.timerSkill1.Tick += new System.EventHandler(this.timerSkill1_Tick);
            // 
            // timerSkill2
            // 
            this.timerSkill2.Tick += new System.EventHandler(this.timerSkill2_Tick);
            // 
            // timerSkill3
            // 
            this.timerSkill3.Tick += new System.EventHandler(this.timerSkill3_Tick);
            // 
            // timerArcherOnOff
            // 
            this.timerArcherOnOff.Tick += new System.EventHandler(this.timerArcherOnOff_Tick);
            // 
            // timerWolf
            // 
            this.timerWolf.Tick += new System.EventHandler(this.timerWolf_Tick);
            // 
            // timerdef1
            // 
            this.timerdef1.Tick += new System.EventHandler(this.timerdef1_Tick);
            // 
            // timerdef2
            // 
            this.timerdef2.Tick += new System.EventHandler(this.timerdef2_Tick);
            // 
            // timerHpPot
            // 
            this.timerHpPot.Tick += new System.EventHandler(this.timerHpPot_Tick);
            // 
            // timerMpPot
            // 
            this.timerMpPot.Tick += new System.EventHandler(this.timerMpPot_Tick);
            // 
            // timerHideShow
            // 
            this.timerHideShow.Tick += new System.EventHandler(this.timerHideShow_Tick);
            // 
            // timerWolfCounter
            // 
            this.timerWolfCounter.Interval = 1000;
            this.timerWolfCounter.Tick += new System.EventHandler(this.timerWolfCounter_Tick);
            // 
            // timerMagicHammer
            // 
            this.timerMagicHammer.Tick += new System.EventHandler(this.timerMagicHammer_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timerPetFeeding
            // 
            this.timerPetFeeding.Tick += new System.EventHandler(this.timerPetFeeding_Tick);
            // 
            // Archer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 311);
            this.Controls.Add(this.checkBoxArcherDark);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkBoxArcherOnTop);
            this.Controls.Add(this.buttonArcherFormExit);
            this.Name = "Archer";
            this.Text = "Archer";
            this.Load += new System.EventHandler(this.Archer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAttack.ResumeLayout(false);
            this.tabPageAttack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAttackSpeed)).EndInit();
            this.tabPageSupport.ResumeLayout(false);
            this.tabPageSupport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInvControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInvControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetFeeding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagicHammer)).EndInit();
            this.tabPagePotion.ResumeLayout(false);
            this.tabPagePotion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMpPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHpPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArcherFormExit;
        private System.Windows.Forms.CheckBox checkBoxArcherOnTop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAttack;
        private System.Windows.Forms.TabPage tabPageSupport;
        private System.Windows.Forms.TabPage tabPagePotion;
        private System.Windows.Forms.CheckBox checkBoxArcherDark;
        private System.Windows.Forms.CheckBox checkBoxChooseMob;
        private System.Windows.Forms.TrackBar trackBarAttackSpeed;
        private System.Windows.Forms.Label labelAttackSpeed;
        private System.Windows.Forms.CheckBox checkBoxSkill3;
        private System.Windows.Forms.CheckBox checkBoxSkill2;
        private System.Windows.Forms.CheckBox checkBoxSkill1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerChooseMob;
        private System.Windows.Forms.Timer timerSkill1;
        private System.Windows.Forms.Timer timerSkill2;
        private System.Windows.Forms.Timer timerSkill3;
        private System.Windows.Forms.Timer timerArcherOnOff;
        private System.Windows.Forms.CheckBox checkBoxDefence2;
        private System.Windows.Forms.CheckBox checkBoxDefence1;
        private System.Windows.Forms.CheckBox checkBoxWolf;
        private System.Windows.Forms.Timer timerWolf;
        private System.Windows.Forms.Timer timerdef1;
        private System.Windows.Forms.Timer timerdef2;
        private System.Windows.Forms.Label labelHpBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxHpPot;
        private System.Windows.Forms.TrackBar trackBarHp;
        private System.Windows.Forms.TrackBar trackBarMp;
        private System.Windows.Forms.Label labelMpBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxMpPot;
        private System.Windows.Forms.Timer timerHpPot;
        private System.Windows.Forms.Timer timerMpPot;
        private System.Windows.Forms.PictureBox pictureBoxHpPot;
        private System.Windows.Forms.PictureBox pictureBoxMpPot;
        private System.Windows.Forms.Timer timerHideShow;
        private System.Windows.Forms.Timer timerWolfCounter;
        private System.Windows.Forms.Timer timerMagicHammer;
        private System.Windows.Forms.CheckBox checkBoxPetFeeding;
        private System.Windows.Forms.CheckBox checkBoxMagicHammer;
        private System.Windows.Forms.PictureBox pictureBoxMagicHammer;
        private System.Windows.Forms.PictureBox pictureBoxPetFeeding;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timerPetFeeding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureInvControl2;
        private System.Windows.Forms.PictureBox pictureInvControl1;
        private System.Windows.Forms.CheckBox checkBoxRight;
        private System.Windows.Forms.CheckBox checkBoxLeft;
    }
}