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
    public partial class Wires : Form
    {
        public Wires()
        {
            InitializeComponent();
            WireModule.WiresInModule.Clear();           
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            WireModule.WiresInModule.Add(WireModule.Colors.red);
            reCalculateWireBox();
        }

        private void reCalculateWireBox()
        {
            WireBox.Items.Clear();

            foreach (WireModule.Colors a in WireModule.WiresInModule)
            {
                WireBox.Items.Add(a);
            }
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            WireModule.WiresInModule.Add(WireModule.Colors.white);
            reCalculateWireBox();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            WireModule.WiresInModule.Add(WireModule.Colors.blue);
            reCalculateWireBox();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            
            if (WireModule.WiresInModule.Count == 3)
                SolveThree();
            else if (WireModule.WiresInModule.Count == 4)
                SolveFour();
            else if (WireModule.WiresInModule.Count == 5)
                SolveFive();
            else if (WireModule.WiresInModule.Count == 6)
                SolveSix();
            else
                this.Close(); //TODO: Print Error
        }

        private void SolveThree()
        {
            OutputBox.Items.Clear();
            Boolean redFound = false;
            Boolean solved = false;
            int CutPosition = 99;
            int BlueCount = 0;
            int LastBlueIndex = 0;
            WireModule.Colors CutColor = WireModule.Colors.debug;
            foreach (WireModule.Colors col in WireModule.WiresInModule) //First Rule
            {
                if (col == WireModule.Colors.red)
                    redFound = true;
            }

            if (!redFound)
            {
                solved = true;
                CutPosition = 1;
                CutColor = WireModule.WiresInModule[1];
            }
            if (!solved)
            {
                if (WireModule.WiresInModule[2] == WireModule.Colors.white) //Second Rule
                {
                    CutPosition = 2;
                    CutColor = WireModule.WiresInModule[2];
                    solved = true;
                }
            }
            if (!solved)
            {
                for (int i = 0; i < WireModule.WiresInModule.Count(); i++) //Third Rule
                {
                    if (WireModule.WiresInModule[i] == WireModule.Colors.blue)
                    {
                        BlueCount++;
                        LastBlueIndex = i;
                    }
                }
                if (BlueCount > 1)
                {
                    CutPosition = LastBlueIndex;
                    CutColor = WireModule.WiresInModule[LastBlueIndex];
                    solved = true;
                }
            }
            if (!solved) //Fourth Rule
            {
                CutPosition = 2;
                CutColor = WireModule.WiresInModule[2];
                solved = true;
            }

            OutputBox.Items.Add("Cut " + CutColor + " at Position " + (CutPosition + 1));
        }

        private void SolveFour()
        {
            OutputBox.Items.Clear();
            Boolean solved = false;
            int RedCount = 0;
            int BlueCount = 0;
            int YellowCount = 0;
            int CutPosition = 99;
            int LastRedIndex = 0;

            WireModule.Colors CutColor = WireModule.Colors.debug;

                for (int i = 0; i < WireModule.WiresInModule.Count();i++) //First Rule
                {
                    if (WireModule.WiresInModule[i] == WireModule.Colors.red) //Always looking for reds for second rule
                    {
                        RedCount++;
                        LastRedIndex = i;
                    }
                    if (WireModule.WiresInModule[i] == WireModule.Colors.blue)
                        BlueCount++; //Gaining BlueCount for Third Rule
                    if (WireModule.WiresInModule[i] == WireModule.Colors.yellow)
                        YellowCount++; //Gaining YellowCount for Fourth Rule
                }
                if (RedCount > 1 && Bomb.LastDigitOdd)
                {
                    solved = true;
                    CutPosition = LastRedIndex;
                    CutColor = WireModule.WiresInModule[CutPosition];
                }

            if (!solved)
            {
                if (WireModule.WiresInModule[3] == WireModule.Colors.yellow && RedCount == 0) //Second Rule
                {
                    solved = true;
                    CutPosition = 0;
                    CutColor = WireModule.WiresInModule[CutPosition];
                }
            }
            if (!solved)
            {
                if (BlueCount == 1) //Third Rule
                {
                    solved = true;
                    CutPosition = 0;
                    CutColor = WireModule.WiresInModule[CutPosition];
                }
            }
            if (!solved)
            {
                if (YellowCount > 1) //Fourth Rule
                {
                    solved = true;
                    CutPosition = 3;
                    CutColor = WireModule.WiresInModule[CutPosition];
                }
            }
            if (!solved) //Fifth Rule
            {
                solved = true; 
                CutPosition = 1;
                CutColor = WireModule.WiresInModule[CutPosition];
            }
            OutputBox.Items.Add("Cut " + CutColor + " at Position " + (CutPosition + 1));
        }

        private void SolveFive()
        {
            OutputBox.Items.Clear();
            Boolean solved = false;
            int CutPosition = 99;
            WireModule.Colors CutColor = WireModule.Colors.debug;
            int RedCount = 0;
            int BlackCount = 0;
            int YellowCount = 0;

            for (int i = 0; i < WireModule.WiresInModule.Count();i++) //Do one Loop to gather info
            {
                if (WireModule.WiresInModule[i] == WireModule.Colors.red)
                    RedCount++; //Gaining RedCount for Second Rule
                if (WireModule.WiresInModule[i] == WireModule.Colors.black)
                    BlackCount++; //Gaining BlackCount for Third Rule
                if (WireModule.WiresInModule[i] == WireModule.Colors.yellow)
                    YellowCount++; //Gaining YellowCount for Second Rule
            }

            if (WireModule.WiresInModule[4] == WireModule.Colors.black && Bomb.LastDigitOdd) //First Rule
            {
                solved = true;
                CutPosition = 3;
                CutColor = WireModule.WiresInModule[CutPosition];
            }

            if (!solved) 
            {
                if (RedCount == 1 && YellowCount > 1) //Second Rule
                {
                    solved = true;
                    CutPosition = 0;
                    CutColor = WireModule.WiresInModule[CutPosition];
                }
            }

            if (!solved) 
            {
                if (BlackCount == 0) //Third Rule
                {
                    solved = true;
                    CutPosition = 1;
                    CutColor = WireModule.WiresInModule[CutPosition];
                }
            }
            if (!solved) //Fourth Rule
            {
                solved = true;
                CutPosition = 0;
                CutColor = WireModule.WiresInModule[CutPosition];
            }
            OutputBox.Items.Add("Cut " + CutColor + " at Position " + (CutPosition + 1));
        }

        private void SolveSix()
        {
            OutputBox.Items.Clear();
            Boolean solved = false;
            int CutPosition = 99;
            WireModule.Colors CutColor = WireModule.Colors.debug;

            int YellowCount = 0;
            int WhiteCount = 0;
            int RedCount = 0;

            for (int i = 0; i < WireModule.WiresInModule.Count(); i++) //Do one Loop to gather info
            {
                if (WireModule.WiresInModule[i] == WireModule.Colors.red)
                    RedCount++; //Gaining RedCount for Third Rule
                if (WireModule.WiresInModule[i] == WireModule.Colors.white)
                    WhiteCount++; //Gaining WhiteCount for Second Rule
                if (WireModule.WiresInModule[i] == WireModule.Colors.yellow)
                    YellowCount++; //Gaining YellowCount for First/Second Rule
            }

            if (YellowCount == 0 && Bomb.LastDigitOdd) //First Rule
            {
                solved = true;
                CutPosition = 2;
                CutColor = WireModule.WiresInModule[CutPosition];
            }

            if (!solved)
            {
                if (YellowCount == 1 && WhiteCount > 1) //Second Rule
                {
                    solved = true;
                    CutPosition = 3;
                    CutColor = WireModule.WiresInModule[CutPosition];
                }
            }
            if (!solved)
            {
                if (RedCount == 0) //Third Rule
                {
                    solved = true;
                    CutPosition = 5;
                    CutColor = WireModule.WiresInModule[CutPosition];
                }
            }
            if (!solved)
            {
                solved = true;
                CutPosition = 3;
                CutColor = WireModule.WiresInModule[CutPosition];
            }
            OutputBox.Items.Add("Cut " + CutColor + " at Position " + (CutPosition + 1));
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            WireModule.WiresInModule.Add(WireModule.Colors.yellow);
            reCalculateWireBox();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            WireModule.WiresInModule.Add(WireModule.Colors.black);
            reCalculateWireBox();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            WireModule.WiresInModule.Clear();
            reCalculateWireBox();
        }
    }


    public static class WireModule
    {
        public enum Colors { red, blue, white, yellow, black, debug }

        public static List<Colors> WiresInModule = new List<Colors>();
    }
}
