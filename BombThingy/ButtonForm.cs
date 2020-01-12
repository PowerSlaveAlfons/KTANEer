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
    public partial class ButtonForm : Form
    {
        public ButtonForm()
        {
            InitializeComponent();
            ButtonModule.ButtonColor = ButtonModule.Colors.debug;
            ButtonModule.ButtonText = ButtonModule.Texts.debug;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            ButtonModule.ButtonColor = ButtonModule.Colors.blue;
            reCalculateStatusBox();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            ButtonModule.ButtonColor = ButtonModule.Colors.white;
            reCalculateStatusBox();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            ButtonModule.ButtonColor = ButtonModule.Colors.yellow;
            reCalculateStatusBox();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            ButtonModule.ButtonColor = ButtonModule.Colors.red;
            reCalculateStatusBox();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            ButtonModule.ButtonText = ButtonModule.Texts.abort;
            reCalculateStatusBox();
        }

        private void btnDetonate_Click(object sender, EventArgs e)
        {
            ButtonModule.ButtonText = ButtonModule.Texts.detonate;
            reCalculateStatusBox();
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            ButtonModule.ButtonText = ButtonModule.Texts.hold;
            reCalculateStatusBox();

        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            ButtonModule.ButtonText = ButtonModule.Texts.press;
            reCalculateStatusBox();
        }

        private void reCalculateStatusBox()
        {
            ButtonStatusBox.Items.Clear();
            if (ButtonModule.ButtonColor == ButtonModule.Colors.debug || ButtonModule.ButtonText == ButtonModule.Texts.debug)
                return;
            ButtonStatusBox.Items.Add(ButtonModule.ButtonColor + " " + ButtonModule.ButtonText);
            SolveButton();
        }

        private void SolveButton()
        {
            Boolean solved = false;
            ButtonModule.Solutions Solution = ButtonModule.Solutions.debug;
            OutputBox.Clear();
            if (ButtonModule.ButtonColor == ButtonModule.Colors.blue && ButtonModule.ButtonText == ButtonModule.Texts.abort) //1.
            {
                solved = true;
                Solution = ButtonModule.Solutions.hold;
            }
            if (!solved)
            {
                if (Bomb.Batteries > 1 && ButtonModule.ButtonText == ButtonModule.Texts.detonate) //2.
                {
                    solved = true;
                    Solution = ButtonModule.Solutions.tap;
                }
            }
            if (!solved)
            {
                if (ButtonModule.ButtonColor == ButtonModule.Colors.white && Bomb.Indicators.Contains(Tuple.Create("CAR", true))) //3.
                {
                    solved = true;
                    Solution = ButtonModule.Solutions.hold;
                }
            }
            if (!solved)
            {
                if (Bomb.Batteries > 2 && Bomb.Indicators.Contains(Tuple.Create("FRK", true))) //4.
                {
                    solved = true;
                    Solution = ButtonModule.Solutions.tap;
                }
            }
            if (!solved)
            {
                if (ButtonModule.ButtonColor == ButtonModule.Colors.yellow) //5.
                {
                    solved = true;
                    Solution = ButtonModule.Solutions.hold;
                }
            }
            if (!solved)
            {
                if (ButtonModule.ButtonColor == ButtonModule.Colors.red && ButtonModule.ButtonText == ButtonModule.Texts.hold) //6.
                {
                    solved = true;
                    Solution = ButtonModule.Solutions.tap;
                }
            }
            if (!solved) //7.
            {
                solved = true;
                Solution = ButtonModule.Solutions.hold;
            }
            if (Solution == ButtonModule.Solutions.tap)
            {
                OutputBox.Text += "Press and immediately release the button.";
                return;
            }
            else if (Solution == ButtonModule.Solutions.hold)
            {
                OutputBox.AppendText("Hold the Button and check Strip color.");
                btnBlueStrip.Visible = true;
                btnWhiteStrip.Visible = true;
                btnYellowStrip.Visible = true;
                btnOtherStrip.Visible = true;
            }
            else
            {
                Close(); //TODO: Error Message
            }
        }

        private void btnBlueStrip_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
            OutputBox.AppendText("Hold the Button and check Strip color.\r\n");
            OutputBox.AppendText("Release when the countdown timer has a 4 in any position.");
        }

        private void btnWhiteStrip_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
            OutputBox.AppendText("Hold the Button and check Strip color.\r\n");
            OutputBox.AppendText("Release when the countdown timer has a 1 in any position.");
        }

        private void btnYellowStrip_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
            OutputBox.AppendText("Hold the Button and check Strip color.\r\n");
            OutputBox.AppendText("Release when the countdown timer has a 5 in any position.");
        }

        private void btnOtherStrip_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
            OutputBox.AppendText("Hold the Button and check Strip color.\r\n");
            OutputBox.AppendText("Release when the countdown timer has a 1 in any position.");
        }
    }

    public static class ButtonModule
    {
        public enum Colors { blue, white, yellow, red, debug }
        public enum Texts { abort, detonate, hold, press, debug }
        public enum Solutions { hold, tap, debug }
        public static Colors ButtonColor = ButtonModule.Colors.debug;
        public static Texts ButtonText = ButtonModule.Texts.debug;
    }
}
