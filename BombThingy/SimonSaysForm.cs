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
    public partial class SimonSaysForm : Form
    {
       
        public SimonSaysForm()
        {
            InitializeComponent();
            StrikeBox.Text = Bomb.Strikes.ToString();
            OutputBox.Items.Clear();
            SimonSaysModule.StepCounter = 0;
            SimonSaysModule.StageCounter = 1;
            OutputBox.Items.Add("Stage 1:");
            switch (Bomb.Strikes)
            {
                case 0:
                    if (Bomb.HasVowel)
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.VowelNoStrike;
                    else
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.NoVowelNoStrike;
                    break;
                case 1:
                    if (Bomb.HasVowel)
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.Vowel1Strike;
                    else
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.NoVowel1Strike;
                    break;
                case 2:
                    if (Bomb.HasVowel)
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.Vowel2Strike;
                    else
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.NoVowel2Strike;
                    break;
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            AddColor(SimonSaysModule.Colors.Blue);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            AddColor(SimonSaysModule.Colors.Red);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            AddColor(SimonSaysModule.Colors.Green);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            AddColor(SimonSaysModule.Colors.Yellow);
        }

        private void AddColor(SimonSaysModule.Colors ColorIn)
        {

            SimonSaysModule.StepCounter++;
            switch (SimonSaysModule.ActualPattern)
            {
                case SimonSaysModule.Pattern.VowelNoStrike:
                    switch(ColorIn)
                    {
                        case SimonSaysModule.Colors.Red:
                            OutputBox.Items.Add("Blue");
                            break;
                        case SimonSaysModule.Colors.Blue:
                            OutputBox.Items.Add("Red");
                            break;
                        case SimonSaysModule.Colors.Green:
                            OutputBox.Items.Add("Yellow");
                            break;
                        case SimonSaysModule.Colors.Yellow:
                            OutputBox.Items.Add("Green");
                            break;
                        default:
                            break;
                    }
                    break;
                case SimonSaysModule.Pattern.Vowel1Strike:
                    switch (ColorIn)
                    {
                        case SimonSaysModule.Colors.Red:
                            OutputBox.Items.Add("Yellow");
                            break;
                        case SimonSaysModule.Colors.Blue:
                            OutputBox.Items.Add("Green");
                            break;
                        case SimonSaysModule.Colors.Green:
                            OutputBox.Items.Add("Blue");
                            break;
                        case SimonSaysModule.Colors.Yellow:
                            OutputBox.Items.Add("Red");
                            break;
                        default:
                            break;
                    }
                    break;
                case SimonSaysModule.Pattern.Vowel2Strike:
                    switch (ColorIn)
                    {
                        case SimonSaysModule.Colors.Red:
                            OutputBox.Items.Add("Green");
                            break;
                        case SimonSaysModule.Colors.Blue:
                            OutputBox.Items.Add("Red");
                            break;
                        case SimonSaysModule.Colors.Green:
                            OutputBox.Items.Add("Yellow");
                            break;
                        case SimonSaysModule.Colors.Yellow:
                            OutputBox.Items.Add("Blue");
                            break;
                        default:
                            break;
                    }
                    break;
                case SimonSaysModule.Pattern.NoVowelNoStrike:
                    switch (ColorIn)
                    {
                        case SimonSaysModule.Colors.Red:
                            OutputBox.Items.Add("Blue");
                            break;
                        case SimonSaysModule.Colors.Blue:
                            OutputBox.Items.Add("Yellow");
                            break;
                        case SimonSaysModule.Colors.Green:
                            OutputBox.Items.Add("Green");
                            break;
                        case SimonSaysModule.Colors.Yellow:
                            OutputBox.Items.Add("Red");
                            break;
                        default:
                            break;
                    }
                    break;
                case SimonSaysModule.Pattern.NoVowel1Strike:
                    switch (ColorIn)
                    {
                        case SimonSaysModule.Colors.Red:
                            OutputBox.Items.Add("Red");
                            break;
                        case SimonSaysModule.Colors.Blue:
                            OutputBox.Items.Add("Blue");
                            break;
                        case SimonSaysModule.Colors.Green:
                            OutputBox.Items.Add("Yellow");
                            break;
                        case SimonSaysModule.Colors.Yellow:
                            OutputBox.Items.Add("Green");
                            break;
                        default:
                            break;
                    }
                    break;

                case SimonSaysModule.Pattern.NoVowel2Strike:
                    switch (ColorIn)
                    {
                        case SimonSaysModule.Colors.Red:
                            OutputBox.Items.Add("Yellow");
                            break;
                        case SimonSaysModule.Colors.Blue:
                            OutputBox.Items.Add("Green");
                            break;
                        case SimonSaysModule.Colors.Green:
                            OutputBox.Items.Add("Blue");
                            break;
                        case SimonSaysModule.Colors.Yellow:
                            OutputBox.Items.Add("Red");
                            break;
                        default:
                            break;
                    }
                    break;



                default: return;
            }
            if (SimonSaysModule.StepCounter == SimonSaysModule.StageCounter)
            {
                SimonSaysModule.StageCounter++;
                SimonSaysModule.StepCounter = 0;
                OutputBox.Items.Add("Stage " + SimonSaysModule.StageCounter + ":");
            }
        }

        private void btnStrike_Click(object sender, EventArgs e)
        {
            Bomb.Strikes++;
            StrikeBox.Text = Bomb.Strikes.ToString();
            switch (Bomb.Strikes)
            {
                case 0:
                    if (Bomb.HasVowel)
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.VowelNoStrike;
                    else
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.NoVowelNoStrike;
                    break;
                case 1:
                    if (Bomb.HasVowel)
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.Vowel1Strike;
                    else
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.NoVowel1Strike;
                    break;
                case 2:
                    if (Bomb.HasVowel)
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.Vowel2Strike;
                    else
                        SimonSaysModule.ActualPattern = SimonSaysModule.Pattern.NoVowel2Strike;
                    break;
            }
        }
    }

    public static class SimonSaysModule
    {
        public static int StageCounter = 1;
        public static int StepCounter = 0;
        public static Pattern ActualPattern;

        public enum Colors
        { Blue, Red, Green, Yellow }

        public enum Pattern
        { VowelNoStrike, Vowel1Strike, Vowel2Strike, NoVowelNoStrike, NoVowel1Strike, NoVowel2Strike }

    }

}
