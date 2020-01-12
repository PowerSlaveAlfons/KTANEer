using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombThingy
{
    public partial class ComplicatedWiresForm : Form
    {
        public ComplicatedWiresForm()
        {
            InitializeComponent();
            UpdateWires();
        }

        private void BoxRed_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWires();
        }

        private void BoxBlue_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWires();
        }

        private void BoxStar_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWires();
        }

        private void BoxLED_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWires();
        }

        private void UpdateWires()
        {
            if (BoxRed.Checked == false && BoxBlue.Checked == false && BoxStar.Checked == false && BoxLED.Checked == false)
                SolutionBox.Text = "Cut"; //0000
            if (BoxRed.Checked == false && BoxBlue.Checked == false && BoxStar.Checked == false && BoxLED.Checked == true)
                SolutionBox.Text = "Don't Cut"; //0001
            if (BoxRed.Checked == false && BoxBlue.Checked == false && BoxStar.Checked == true && BoxLED.Checked == false)
                SolutionBox.Text = "Cut"; //0010
            if (BoxRed.Checked == false && BoxBlue.Checked == false && BoxStar.Checked == true && BoxLED.Checked == true)
                BatteryRule(); //0011
            if (BoxRed.Checked == false && BoxBlue.Checked == true && BoxStar.Checked == false && BoxLED.Checked == false)
                SerialRule(); //0100
            if (BoxRed.Checked == false && BoxBlue.Checked == true && BoxStar.Checked == false && BoxLED.Checked == true)
                ParallelRule(); //0101
            if (BoxRed.Checked == false && BoxBlue.Checked == true && BoxStar.Checked == true && BoxLED.Checked == false)
                SolutionBox.Text = "Don't Cut"; //0110
            if (BoxRed.Checked == false && BoxBlue.Checked == true && BoxStar.Checked == true && BoxLED.Checked == true)
                ParallelRule(); //0111
            if (BoxRed.Checked == true && BoxBlue.Checked == false && BoxStar.Checked == false && BoxLED.Checked == false)
                SerialRule(); //1000
            if (BoxRed.Checked == true && BoxBlue.Checked == false && BoxStar.Checked == false && BoxLED.Checked == true)
                BatteryRule(); //1001
            if (BoxRed.Checked == true && BoxBlue.Checked == false && BoxStar.Checked == true && BoxLED.Checked == false)
                SolutionBox.Text = "Cut"; //1010
            if (BoxRed.Checked == true && BoxBlue.Checked == false && BoxStar.Checked == true && BoxLED.Checked == true)
                BatteryRule(); //1011
            if (BoxRed.Checked == true && BoxBlue.Checked == true && BoxStar.Checked == false && BoxLED.Checked == false)
                SerialRule(); //1100
            if (BoxRed.Checked == true && BoxBlue.Checked == true && BoxStar.Checked == false && BoxLED.Checked == true)
                SerialRule(); //1101
            if (BoxRed.Checked == true && BoxBlue.Checked == true && BoxStar.Checked == true && BoxLED.Checked == false)
                ParallelRule(); //1110
            if (BoxRed.Checked == true && BoxBlue.Checked == true && BoxStar.Checked == true && BoxLED.Checked == true)
                SolutionBox.Text = "Don't Cut"; //1111
        }

        private void BatteryRule()
        {
            if (Bomb.Batteries >= 2)
                SolutionBox.Text = "Cut (Batteries)";
            else
                SolutionBox.Text = "Don't Cut (Batteries)";
        }

        private void SerialRule()
        {
            if (Bomb.LastDigitOdd == false)
                SolutionBox.Text = "Cut (Serial)";
            else
                SolutionBox.Text = "Don't Cut (Serial)";
        }

        private void ParallelRule()
        {
            if (Bomb.PortsOnBomb.Contains(Bomb.Ports.parallel))
                SolutionBox.Text = "Cut (Parallel)";
            else
                SolutionBox.Text = "Don't Cut (Parallel)";
        }
    }
}
