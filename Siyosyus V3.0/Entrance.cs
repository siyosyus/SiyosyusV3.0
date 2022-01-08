using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AutoItX3Lib;

namespace Siyosyus_V3._0
{
    public partial class Entrance : Form
    {
        Priest pri = new Priest();
        Archer arch = new Archer();
        Pedal pedal = new Pedal();
        public Entrance()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void buttonPriestForm_Click(object sender, EventArgs e)
        {

            pri.Show();
            this.Hide();
        }

        private void buttonArcherForm_Click(object sender, EventArgs e)
        {

            arch.Show();
            this.Hide();
        }

        private void buttonPedalForm_Click(object sender, EventArgs e)
        {
            pedal.Show();
            this.Hide();
        }
    }
    }

