using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Siyosyus_V3._0
{
    public partial class Pedal : Form
    {
        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        AutoItX3 kmt = new AutoItX3();
        int mpCount = 0;
        public Pedal()
        {
            InitializeComponent();
            checkBoxHpMp.Checked = false;
            checkBoxMana.Checked = false;
            checkBoxMinor.Checked = false;
            checkBoxDark.Checked = false;
            checkBoxOnTop.Checked = false;
            this.BackColor = Color.LightBlue;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxDark_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDark.Checked == true)
            {
                this.BackColor = Color.DarkSlateGray;
            }
            else
            {
                this.BackColor = Color.LightBlue;
            }
        }

        private void checkBoxOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnTop.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void timerPedalOnOff_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.NumPad1))
            {
                if (checkBoxMinor.Checked == true)
                {
                    timerMinor.Enabled = true;
                    timerMinor.Interval = 3;
                }
                if (checkBoxMana.Checked == true)
                {
                    timerMana.Enabled = true;
                    timerMana.Interval = 200;

                }
                if (checkBoxHpMp.Checked == true)
                {
                    timer2Mp1Hp.Enabled = true;
                    timer2Mp1Hp.Interval = 1400;
                }
                if (checkBoxRCombo.Checked == true)
                {
                    timerRCombo.Enabled = true;
                    timerRCombo.Interval = 100;
                }
                if (checkBoxHpMp.Checked == true && checkBoxMana.Checked == true)
                {

                    MessageBox.Show("It is not allowed to run Mana potion Mode and 2Mana potion 1 Health potion together!!!");
                }
            }
            else if (GetAsyncKeyState(Keys.NumPad0))
            {
                mpCount = 0;
                timerMinor.Stop();
                timerMana.Stop();
                timer2Mp1Hp.Stop();
                timerRCombo.Stop();
            }
        }

        private void Pedal_Load(object sender, EventArgs e)
        {
            timerPedalOnOff.Enabled = true;
            timerPedalOnOff.Interval = 1;
        }

        private void timerMinor_Tick(object sender, EventArgs e)
        {
            kmt.Send("000");
        }

        private void timerMana_Tick(object sender, EventArgs e)
        {

            kmt.Send("99");
        }

        private void timer2Mp1Hp_Tick(object sender, EventArgs e)
        {
            if (mpCount == 0)
            {
                timerMinor.Interval = 1;
                kmt.Send("99999");
                mpCount++;
            }
            else if (mpCount == 1)
            {
                timerMinor.Interval = 150;
                kmt.Send("99999");
                mpCount++;
            }
            else if (mpCount == 2)
            {
                kmt.Send("88888");
                mpCount = 0;
            }
        }

        private void timerRCombo_Tick(object sender, EventArgs e)
        {
            kmt.Send("rrrr");
        }
    }
}
