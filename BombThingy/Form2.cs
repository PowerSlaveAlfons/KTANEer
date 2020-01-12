using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KTANEer.Bomb;

namespace KTANEer
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Bomb.Serial = SerialBox.Text.ToLower();
            if (Bomb.Serial.Length != 6)
            {
                MessageBox.Show("Your Serial Number does not consist of 6 digits", "Serial Number Length Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                return;
            }
            if (string.IsNullOrWhiteSpace(BatteryBox.Text))
                Bomb.Batteries = 0;
            else
                Bomb.Batteries = int.Parse(BatteryBox.Text);
            if (string.IsNullOrWhiteSpace(HolderBox.Text))
                Bomb.Holders = 0;
            else
                Bomb.Holders = int.Parse(HolderBox.Text);
            Bomb.Init = true;
            if ((Char.GetNumericValue(Bomb.Serial[Bomb.Serial.Length - 1]) % 2) == 1)
                Bomb.LastDigitOdd = true;
            else
                Bomb.LastDigitOdd = false;
            foreach (char c in Serial)
            {
                if ("aeiouAEIOU".Contains(c))
                    Bomb.HasVowel = true;
            }
            this.Close();
        }

        private void btnAddPlate_Click(object sender, EventArgs e)
        {
            Bomb.PortPlates++;
            PlateLabel.Text = Bomb.PortPlates.ToString();
        }

        private void btnDVID_Click(object sender, EventArgs e)
        {
            Bomb.PortsOnBomb.Add(Ports.dvi);
            reCalculatePortBox();
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            Bomb.PortsOnBomb.Add(Ports.parallel);
            reCalculatePortBox();
        }

       

        private void btnPS2_Click(object sender, EventArgs e)
        {
            Bomb.PortsOnBomb.Add(Ports.ps2);
            reCalculatePortBox();
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            Bomb.PortsOnBomb.Add(Ports.serial);
            reCalculatePortBox();
        }

        private void btnRJ45_Click(object sender, EventArgs e)
        {
            Bomb.PortsOnBomb.Add(Ports.rj45);
            reCalculatePortBox();
        }

        private void btnStereoRCA_Click(object sender, EventArgs e)
        {
            Bomb.PortsOnBomb.Add(Ports.stereorca);
            reCalculatePortBox();
        }

        private void reCalculatePortBox()
        {
            PortsBox.Items.Clear();

            foreach (Ports a in Bomb.PortsOnBomb)
            {
                PortsBox.Items.Add(a);
            }
        }

        private void reCalculateIndBox()
        {
            IndicatorBox.Items.Clear();

            foreach (Tuple<String, Boolean> a in Bomb.Indicators)
            {
                IndicatorBox.Items.Add(a);
            }
        }

        private void btnAddLit_Click(object sender, EventArgs e)
        {
            Bomb.Indicators.Add(Tuple.Create(IndicatorTextBox.Text.ToLower(), true));
            reCalculateIndBox();
            IndicatorTextBox.Clear();
        }

        private void btnAddUnlit_Click(object sender, EventArgs e)
        {
            Bomb.Indicators.Add(Tuple.Create(IndicatorTextBox.Text.ToLower(), false));
            reCalculateIndBox();
            IndicatorTextBox.Clear();
        }
    }
}
