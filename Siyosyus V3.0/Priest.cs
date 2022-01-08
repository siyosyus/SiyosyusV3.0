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
    public partial class Priest : Form
    {
        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        Bitmap btmp = new Bitmap(1920,1080);
        AutoItX3 kmt = new AutoItX3();
        int hpStartCoordinate_X = 27;
        int hpCoordinate_Y = 47;
        int mpStartCoordinate_X = 27;
        int mpCoordinate_Y = 63;
        bool shown = true;
        string hpColor1 = "ffdc0004";
        string hpColor2 = "ff600002";
        string mpColor1 = "ff1e43f0";
        string mpColor2 = "ff0d1d69";
        public Priest()
        {
            InitializeComponent();
            checkBoxAc.Checked = false;
            checkBoxBuff.Checked = false;
            checkBoxHp.Checked = false;
            checkBoxMp.Checked = false;
            this.BackColor = Color.LightBlue;
        }
        public void captureScreen()
        {
            Graphics gr = Graphics.FromImage(btmp as Image);
            gr.CopyFromScreen(0, 0, 0, 0, btmp.Size, CopyPixelOperation.SourceCopy);
            
        }

        private void Priest_Load(object sender, EventArgs e)
        {
            timerPriestOnOff.Enabled = true;
            timerPriestOnOff.Interval = 1;
        }

        private void buttonPriestFormBack_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void trackBarHp_Scroll(object sender, EventArgs e)
        {
            int trackbarHpValue = trackBarHp.Value;
            labelHpBar.Text =Convert.ToString(trackbarHpValue);
        }

        private void trackBarMp_Scroll(object sender, EventArgs e)
        {
            int trackbarMpValue = trackBarMp.Value;
            labelMpBar.Text = Convert.ToString(trackbarMpValue);
        }

 
        private void timerBuff_Tick(object sender, EventArgs e)
        {
            kmt.Send("{TAB}");
            System.Threading.Thread.Sleep(300);
            kmt.Send("11");
            System.Threading.Thread.Sleep(300);
            kmt.Send("22");
            System.Threading.Thread.Sleep(300);
        }


        private void timerAc_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(150);
            kmt.Send("2");
            System.Threading.Thread.Sleep(150);
        }

        private void timerPriestOnOff_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.NumPad1))
            {
                if(checkBoxBuff.Checked == true)
                {
                    timerBuff.Interval = 1;
                    timerBuff.Start();
                }
                if (checkBoxAc.Checked == true)
                {
                    timerAc.Interval = 1;
                    timerAc.Start();
                }
                if (checkBoxHp.Checked == true)
                {
                    timerHpPot.Interval = 1;
                    timerHpPot.Start();
                }
                if (checkBoxMp.Checked == true)
                {
                    timerMpPot.Interval = 1;
                    timerMpPot.Start();
                }
            }
            if (GetAsyncKeyState(Keys.F11))
            {
                timerHideShow.Interval = 100;
                timerHideShow.Start();
            }

            if (GetAsyncKeyState(Keys.NumPad0))
            {
                timerBuff.Stop();
                timerAc.Stop();
                timerHpPot.Stop();
                timerMpPot.Stop();
                timerTAB.Stop();
            }
        }

        private void timerHpPot_Tick(object sender, EventArgs e)
        {
            captureScreen();
            Color pixelHpColor = btmp.GetPixel(hpStartCoordinate_X + 2*Convert.ToInt32(labelHpBar.Text), hpCoordinate_Y);
            pictureBoxHpPot.BackColor = pixelHpColor;
            string pickedHpColor = pictureBoxHpPot.BackColor.Name;
            if(pickedHpColor != hpColor1 && pickedHpColor != hpColor2)
            {
                    kmt.Send("9");
            }
            
        }

        private void timerMpPot_Tick(object sender, EventArgs e)
        {
            captureScreen();
            Color pixelMpColor = btmp.GetPixel(mpStartCoordinate_X + 2*Convert.ToInt32(labelMpBar.Text), mpCoordinate_Y);
            pictureBoxMpPot.BackColor = pixelMpColor;
            string pickedMpColor = pictureBoxMpPot.BackColor.Name;
            if (pickedMpColor != mpColor1 && pickedMpColor != mpColor2)
            {
                kmt.Send("0");
            }
        }

        private void checkBoxPriestOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPriestOnTop.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void timerHideShow_Tick(object sender, EventArgs e)
        {
            if(shown == true)
            {
                shown = false;
                this.Hide();
                timerHideShow.Stop();
            }else if(shown == false)
            {
                shown = true;
                this.Show();
                timerHideShow.Stop();
            }
        }

        private void checkBoxPriestDark_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPriestDark.Checked == true)
            {
                this.BackColor = Color.DarkSlateGray;
            }
            else
            {
                this.BackColor = Color.LightBlue;
            }
        }

        private void timerTAB_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(150);
            kmt.Send("{TAB}");
            System.Threading.Thread.Sleep(150);
        }
    }
}
