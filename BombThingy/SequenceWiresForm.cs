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
    public partial class SequenceWiresForm : Form
    {
        public SequenceWiresForm()
        {
            InitializeComponent();
            SequenceWireModule.Reset();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            SequenceWireModule.RedCount++;
            SequenceWireModule.TempColor = SequenceWireModule.Color.Red;
            ShowLetters();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            SequenceWireModule.BlueCount++;
            SequenceWireModule.TempColor = SequenceWireModule.Color.Blue;
            ShowLetters();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            SequenceWireModule.BlackCount++;
            SequenceWireModule.TempColor = SequenceWireModule.Color.Black;
            ShowLetters();
        }

        private void ShowLetters()
        {
            btnRed.Visible = false;
            btnBlue.Visible = false;
            btnBlack.Visible = false;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
        }

        private void ShowColors()
        {
            btnRed.Visible = true;
            btnBlue.Visible = true;
            btnBlack.Visible = true;
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            switch (SequenceWireModule.TempColor)
            {
                case SequenceWireModule.Color.Red:
                    GetNextRed(SequenceWireModule.Letters.A);
                    break;
                case SequenceWireModule.Color.Blue:
                    GetNextBlue(SequenceWireModule.Letters.A);
                    break;
                case SequenceWireModule.Color.Black:
                    GetNextBlack(SequenceWireModule.Letters.A);
                    break;
                case SequenceWireModule.Color.Debug:
                    break;
                default:
                    break;
            }
            ShowColors();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            switch (SequenceWireModule.TempColor)
            {
                case SequenceWireModule.Color.Red:
                    GetNextRed(SequenceWireModule.Letters.B);
                    break;
                case SequenceWireModule.Color.Blue:
                    GetNextBlue(SequenceWireModule.Letters.B);
                    break;
                case SequenceWireModule.Color.Black:
                    GetNextBlack(SequenceWireModule.Letters.B);
                    break;
                case SequenceWireModule.Color.Debug:
                    break;
                default:
                    break;
            }
            ShowColors();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            switch (SequenceWireModule.TempColor)
            {
                case SequenceWireModule.Color.Red:
                    GetNextRed(SequenceWireModule.Letters.C);
                    break;
                case SequenceWireModule.Color.Blue:
                    GetNextBlue(SequenceWireModule.Letters.C);
                    break;
                case SequenceWireModule.Color.Black:
                    GetNextBlack(SequenceWireModule.Letters.C);
                    break;
                case SequenceWireModule.Color.Debug:
                    break;
                default:
                    break;
            }
            ShowColors();
        }

        private void GetNextRed(SequenceWireModule.Letters Input)
        {
            switch (SequenceWireModule.RedCount)
            {
                case 1:
                    if (Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 2:
                    if (Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 3:
                    if (Input == SequenceWireModule.Letters.A)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 4:
                    if (Input == SequenceWireModule.Letters.A || Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 5:
                    if (Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 6:
                    if (Input == SequenceWireModule.Letters.A || Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 7:
                    OutputBox.Text = "Cut";
                    break;
                case 8:
                    if (Input == SequenceWireModule.Letters.A || Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 9:
                    if (Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;

                default:
                    break;
            }
        }

        private void GetNextBlue(SequenceWireModule.Letters Input)
        {
            switch (SequenceWireModule.BlueCount)
            {
                case 1:
                    if (Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 2:
                    if (Input == SequenceWireModule.Letters.A || Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 3:
                    if (Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 4:
                    if (Input == SequenceWireModule.Letters.A)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 5:
                    if (Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 6:
                    if (Input == SequenceWireModule.Letters.B || Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 7:
                    if (Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 8:
                    if (Input == SequenceWireModule.Letters.A || Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 9:
                    if (Input == SequenceWireModule.Letters.A)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                default:
                    break;
            }
        }

        private void GetNextBlack(SequenceWireModule.Letters Input)
        {
            switch (SequenceWireModule.BlackCount)
            {
                case 1:
                    OutputBox.Text = "Cut";
                    break;
                case 2:
                    if (Input == SequenceWireModule.Letters.A || Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 3:
                    if (Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 4:
                    if (Input == SequenceWireModule.Letters.A || Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 5:
                    if (Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 6:
                    if (Input == SequenceWireModule.Letters.B || Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 7:
                    if (Input == SequenceWireModule.Letters.A || Input == SequenceWireModule.Letters.B)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 8:
                    if (Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                case 9:
                    if (Input == SequenceWireModule.Letters.C)
                        OutputBox.Text = "Cut";
                    else
                        OutputBox.Text = "Don't Cut";
                    break;
                default:
                    break;
            }
        }


    }

    public static class SequenceWireModule
    {
        public static int RedCount = 0;
        public static int BlueCount = 0;
        public static int BlackCount = 0;
        public enum Color { Red, Blue, Black, Debug }
        public enum Letters { A, B, C }
        public static Color TempColor = Color.Debug;

        public static void Reset()
        {
            RedCount = 0;
            BlueCount = 0;
            BlackCount = 0;
            TempColor = Color.Debug;
        }
    }
}
