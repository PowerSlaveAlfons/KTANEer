using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANEer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            new InitForm().Show();
        }

        private void btnWires_Click(object sender, EventArgs e)
        {
            new Wires().Show();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            new ButtonForm().Show();
        }

        private void btnKeypad_Click(object sender, EventArgs e)
        {
            new KeyPadForm().Show();
        }

        private void btnSimonSays_Click(object sender, EventArgs e)
        {
            new SimonSaysForm().Show();
        }

        private void btnWhosOnFirst_Click(object sender, EventArgs e)
        {
            new WhosOnFirstForm().Show();
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            new MemoryForm().Show();
        }

        private void btnMorse_Click(object sender, EventArgs e)
        {
            new MorseForm().Show();
        }

        private void btnComplicatedWires_Click(object sender, EventArgs e)
        {
            new ComplicatedWiresForm().Show();
        }

        private void btnSequenceWires_Click(object sender, EventArgs e)
        {
            new SequenceWiresForm().Show();
        }

        private void btnMaze_Click(object sender, EventArgs e)
        {
            new MazeForm().Show();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            new PasswordForm().Show();
        }

        private void btnSkewedSlots_Click(object sender, EventArgs e)
        {
            new SkewedSlotsForm().Show();
        }

        private void btnKnob_Click(object sender, EventArgs e)
        {
            new KnobForm().Show();
        }

        private void btnBlindAlley_Click(object sender, EventArgs e)
        {
            new BlindAlleyForm().Show();
        }
    }

    public static class Bomb
    {
        public static String Serial { get; set; }
        public static int Batteries { get; set; }
        public static int Holders { get; set; }
        public enum Ports { dvi, parallel, ps2, rj45, serial, stereorca }
        public static List<Ports> PortsOnBomb = new List<Ports>();
        public static int PortPlates { get; set; }
        public static List<Tuple<String, Boolean>> Indicators = new List<Tuple<String, Boolean>>();
        public static Boolean Init = false;
        public static Boolean LastDigitOdd = false; //4,5,6 wires     
        public static Boolean HasVowel = false; //Simon Says
        public static int Strikes = 0;
        public static int GetRightmostSerialDigit()
        {
            for (int i = 5; i >= 0; i--)
            {
                if (Char.IsDigit(Bomb.Serial[i]))
                    return Convert.ToInt32(Bomb.Serial[i].ToString());
            }
            return -1;
        }
        public static int GetLargestSerialDigit()
        {
            List<int> Digits = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                if (Char.IsDigit(Bomb.Serial[i]))
                    Digits.Add(Convert.ToInt32(Bomb.Serial[i].ToString()));
            }
            return Digits.Max();
        }

        public static bool HasEvenDigit()
        {
            for (int i = 0; i < 6; i++)
            {
                if (Char.IsDigit(Bomb.Serial[i]))
                {
                    if ((Convert.ToInt32(Bomb.Serial[i].ToString())) % 2 == 0)
                        return true;
                }
            }
            return false;
        }
    }

}
