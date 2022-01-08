using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Drawing.Imaging;

namespace Siyosyus_V3._0
{
    public partial class Archer : Form
    {
        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        Bitmap btmp = new Bitmap(1920, 1080);
        AutoItX3 kmt = new AutoItX3();
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData,
   UIntPtr dwExtraInfo);
        int hpStartCoordinate_X = 27;
        int hpCoordinate_Y = 47;
        int mpStartCoordinate_X = 27;
        int mpCoordinate_Y = 63;
        int bowCoordinate_X = 1556;
        int bowCoordinate_Y = 262;
        int petCoordinate_X=251;
        int petCoordinate_Y=64;
        int invcontrol1_x = 1403;
        int invcontrol1_y = 117;
        int invcontrol2_x = 1531; //inventory
        int invcontrol2_y = 108; //inventory
        int crossbowCoordinate_X = 1452;
        int crossbowCoordinate_Y = 265;
        int daggerX = 1455;
        int daggerY = 261;
        bool shown = true;
        int wolfCounter = 3;
        int def1Counter = 2;
        int def2Counter = 18;
        int trackBarAttackSpeedTimer = 1;
        string hpColor1 = "ffdc0004";
        string hpColor2 = "ff600002";
        string mpColor1 = "ff1e43f0";
        string mpColor2 = "ff0d1d69";
        string posionPurple = "ff954399";
        string posionYellow = "ffb67b20";
        string bowColor = "ff4e0808";
        string inv_control1 = "ff27241f"; //inventory
        string inv_control2 = "ff43746c"; //inventory
        string petColor = "ff9f6716";
        string daggerColor = "ff4e0808";

        public Archer()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
            tabPageAttack.BackColor = Color.LightBlue;
            tabPagePotion.BackColor = Color.LightBlue;
            tabPageSupport.BackColor = Color.LightBlue;
        }

        private void buttonArcherFormBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxArcherOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxArcherOnTop.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void Archer_Load(object sender, EventArgs e)
        {
            timerArcherOnOff.Interval = 1;
            timerArcherOnOff.Enabled = true;
            
        }
        public void captureScreen()
        {
            Graphics gr = Graphics.FromImage(btmp as Image);
            gr.CopyFromScreen(0, 0, 0, 0, btmp.Size, CopyPixelOperation.SourceCopy);

        }

        private void checkBoxArcherDark_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxArcherDark.Checked == true)
            {
                this.BackColor = Color.DarkSlateGray;
                tabPageAttack.BackColor = Color.DarkSlateGray;
                tabPagePotion.BackColor = Color.DarkSlateGray;
                tabPageSupport.BackColor = Color.DarkSlateGray;
            }
            else
            {
                this.BackColor = Color.LightBlue;
                tabPageAttack.BackColor = Color.LightBlue;
                tabPagePotion.BackColor = Color.LightBlue;
                tabPageSupport.BackColor = Color.LightBlue;
            }
        }

        private void trackBarAttackSpeed_Scroll(object sender, EventArgs e)
        {
             trackBarAttackSpeedTimer = trackBarAttackSpeed.Value;
        }

        private void timerChooseMob_Tick(object sender, EventArgs e)
        {
            kmt.Send("zzz");
        }

        private void timerSkill1_Tick(object sender, EventArgs e)
        {
            kmt.Send("111");
        }

        private void timerSkill2_Tick(object sender, EventArgs e)
        {
            kmt.Send("222");
        }

        private void timerSkill3_Tick(object sender, EventArgs e)
        {
            kmt.Send("333");
        }

        private void timerArcherOnOff_Tick(object sender, EventArgs e)
        {
            
            captureScreen();
            /***
            Color pixelBowColor = btmp.GetPixel(Cursor.Position.X, Cursor.Position.Y);
            pictureBoxMagicHammer.BackColor = pixelBowColor;
            string pickedBowColor = pictureBoxMagicHammer.BackColor.Name;

            label4.Text = "x: " + Cursor.Position.X + " y: " + Cursor.Position.Y;
            ***/


            if (GetAsyncKeyState(Keys.NumPad1))
            {
                if (checkBoxChooseMob.Checked == true)
                {
                    timerChooseMob.Interval = trackBarAttackSpeedTimer;
                    timerChooseMob.Start();

                }
                if (checkBoxSkill1.Checked == true)
                {
                    timerSkill1.Interval = trackBarAttackSpeedTimer;
                    timerSkill1.Start();
                }
                if (checkBoxSkill2.Checked == true)
                {
                    timerSkill2.Interval = trackBarAttackSpeedTimer;
                    timerSkill2.Start();
                }
                if (checkBoxSkill3.Checked == true)
                {
                    timerSkill3.Interval = trackBarAttackSpeedTimer;
                    timerSkill3.Start();
                }
                if (checkBoxWolf.Checked == true)
                {
                    timerWolf.Interval = 10;
                    timerWolf.Start();
                    timerWolfCounter.Interval = 1000;
                    timerWolfCounter.Enabled = true;
                }
                if (checkBoxDefence1.Checked == true)
                {
                    timerdef1.Interval = 1000;
                    timerdef1.Start();
                }
                if (checkBoxDefence2.Checked == true)
                {
                    timerdef2.Interval = 1000;
                    timerdef2.Start();
                }
                if (checkBoxHpPot.Checked == true)
                {
                    timerHpPot.Interval = 1;
                    timerHpPot.Start();
                }
                if (checkBoxMpPot.Checked == true)
                {
                    timerMpPot.Interval = 1;
                    timerMpPot.Start();
                }
                if (checkBoxMagicHammer.Checked == true)
                {
                    timerMagicHammer.Interval = 1;
                    timerMagicHammer.Start();
                }
                if (checkBoxPetFeeding.Checked == true)
                {
                    timerPetFeeding.Interval = 750;
                    timerPetFeeding.Start();
                }
            }
            if (GetAsyncKeyState(Keys.F11))
            {
                timerHideShow.Interval = 100;
                timerHideShow.Start();
            }
            if (GetAsyncKeyState(Keys.NumPad0))
            {
                timerChooseMob.Stop();
                timerSkill1.Stop();
                timerSkill2.Stop();
                timerSkill3.Stop();
                timerWolf.Stop();
                timerWolfCounter.Stop();
                timerdef1.Stop();
                timerdef2.Stop();
                timerHpPot.Stop();
                timerMpPot.Stop();
                timerMagicHammer.Stop();
                timerPetFeeding.Stop();
                wolfCounter = 3;
                def1Counter = 2;
                def2Counter = 18;
            }
        }

        private void timerWolf_Tick(object sender, EventArgs e)
        {
            if (wolfCounter == 3)
            {
                if (checkBoxChooseMob.Checked == true)
                {
                    timerChooseMob.Stop();
                }
                if (checkBoxSkill1.Checked == true)
                {
                    timerSkill1.Stop();
                }
                if (checkBoxSkill2.Checked == true)
                {
                    timerSkill2.Stop();
                }
                if (checkBoxSkill3.Checked == true)
                {
                    timerSkill3.Stop();
                }


            }
            else if (wolfCounter == 2)
            {
                kmt.Send("66666");
            }
            else if (wolfCounter == -1)
            {
                wolfCounter = 120;

                if (checkBoxChooseMob.Checked == true)
                {
                    timerChooseMob.Start();
                }
                if (checkBoxSkill1.Checked == true)
                {
                    timerSkill1.Start();
                }
                if (checkBoxSkill2.Checked == true)
                {
                    timerSkill2.Start();
                }
                if (checkBoxSkill3.Checked == true)
                {
                    timerSkill3.Start();
                }
            }
        }

        private void timerdef1_Tick(object sender, EventArgs e)
        {
            def1Counter--;
            if (def1Counter == 0)
            {
                def1Counter = 31;
                kmt.Send("44444");
            }
        }

        private void timerdef2_Tick(object sender, EventArgs e)
        {
            def2Counter--;
            if (def2Counter == 0)
            {
                def2Counter = 31;
                kmt.Send("55555");
            }
        }

        private void trackBarHp_Scroll(object sender, EventArgs e)
        {
            int trackbarHpValue = trackBarHp.Value;
            labelHpBar.Text = Convert.ToString(trackbarHpValue);
        }

        private void trackBarMp_Scroll(object sender, EventArgs e)
        {
            int trackbarMpValue = trackBarMp.Value;
            labelMpBar.Text = Convert.ToString(trackbarMpValue);
        }

        private void timerHpPot_Tick(object sender, EventArgs e)
        {
            Color pixelHpColor = btmp.GetPixel(hpStartCoordinate_X + 2 * Convert.ToInt32(labelHpBar.Text), hpCoordinate_Y);
            pictureBoxHpPot.BackColor = pixelHpColor;
            string pickedHpColor = pictureBoxHpPot.BackColor.Name;
            if (pickedHpColor != hpColor1 && pickedHpColor != hpColor2 && pickedHpColor != posionPurple && pickedHpColor != posionYellow)
            {
                kmt.Send("8");
            }
        }

        private void timerMpPot_Tick(object sender, EventArgs e)
        {
            Color pixelMpColor = btmp.GetPixel(mpStartCoordinate_X + 2 * Convert.ToInt32(labelMpBar.Text), mpCoordinate_Y);
            pictureBoxMpPot.BackColor = pixelMpColor;
            string pickedMpColor = pictureBoxMpPot.BackColor.Name;
            if (pickedMpColor != mpColor1 && pickedMpColor != mpColor2)
            {
                kmt.Send("9");
            }
        }

        private void timerHideShow_Tick(object sender, EventArgs e)
        {
            if (shown == true)
            {
                shown = false;
                this.Hide();
                timerHideShow.Stop();
            }
            else if (shown == false)
            {
                shown = true;
                this.Show();
                timerHideShow.Stop();
            }
        }

        private void timerWolfCounter_Tick(object sender, EventArgs e)
        {
                wolfCounter--;
        }

        private void timerMagicHammer_Tick(object sender, EventArgs e)
        {
            if (checkBoxLeft.Checked == true && checkBoxRight.Checked ==false)
            {
                Color pixelBowColor = btmp.GetPixel(daggerX, daggerY);
                pictureBoxMagicHammer.BackColor = pixelBowColor;
                string pickedBowColor = pictureBoxMagicHammer.BackColor.Name;
                if (pickedBowColor == daggerColor)
                {
                    kmt.Send("7");
                }
            }
            else if (checkBoxRight.Checked == true && checkBoxLeft.Checked==false)
            {
                Color pixelBowColor = btmp.GetPixel(bowCoordinate_X, bowCoordinate_Y);
                pictureBoxMagicHammer.BackColor = pixelBowColor;
                string pickedBowColor = pictureBoxMagicHammer.BackColor.Name;
                if (pickedBowColor == bowColor)
                {
                    kmt.Send("7");
                }
            }
            else if ( checkBoxRight.Checked == true && checkBoxLeft.Checked == true)
            {
                MessageBox.Show("It is not possible to mark two checkbox together!");
                checkBoxLeft.Checked = false;
                checkBoxRight.Checked = false;
            }
            else if(checkBoxRight.Checked==false && checkBoxLeft.Checked == false)
            {
                Color pixelBowColor = btmp.GetPixel(bowCoordinate_X, bowCoordinate_Y);
                pictureBoxMagicHammer.BackColor = pixelBowColor;
                string pickedBowColor = pictureBoxMagicHammer.BackColor.Name;
                if(pickedBowColor == bowColor)
                {
                    kmt.Send("7");
                }
            }   
        }

        private void timerPetFeeding_Tick(object sender, EventArgs e)
        {    
            Color pixelPetColor = btmp.GetPixel(petCoordinate_X,petCoordinate_Y);
            pictureBoxPetFeeding.BackColor = pixelPetColor;
            string pickedPetcolor = pictureBoxPetFeeding.BackColor.Name;

            if (pickedPetcolor != petColor)
            {
                Color pixelInvContorl1Color = btmp.GetPixel(invcontrol1_x, invcontrol1_y);
                pictureInvControl1.BackColor = pixelInvContorl1Color;
                string pickedInvControl1Color = pictureInvControl1.BackColor.Name;
                if(pickedInvControl1Color == inv_control1)
                {
                    kmt.Sleep(1000);
                    kmt.MouseClickDrag("left", 1561, 273, 1547, 160);
                    kmt.Sleep(1000);
                    kmt.MouseMove(1432, 239);
                    kmt.Sleep(1000);
                    kmt.MouseClick("left", 1432, 239, 3);
                    kmt.Sleep(1000);
                    kmt.MouseMove(1350, 874);
                    kmt.Sleep(1000);
                    kmt.MouseClick("Left",1350, 874, 4);
                    kmt.Sleep(1000);
                }else if (pickedInvControl1Color != inv_control1)
                {
                    kmt.Sleep(500);
                    kmt.Send("pp"); kmt.Send("pp");
                    kmt.Sleep(500);
                }

            }       
        }
    }
}
