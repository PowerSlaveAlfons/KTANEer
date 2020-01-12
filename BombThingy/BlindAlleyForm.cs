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
    public partial class BlindAlleyForm : Form
    {
        public BlindAlleyForm()
        {
            InitializeComponent();
            BlindAlleyModule.Calculate();
            int MaxScore = BlindAlleyModule.Score.Max();
            List<int> Indexes = new List<int>();
            for(int i = 0; i < 8; i++)
            {
                if (BlindAlleyModule.Score[i] == MaxScore)
                    Indexes.Add(i);
            }

            if (Indexes.Contains(0))
                btnTopLeft.Text = "PUSH";
            if (Indexes.Contains(1))
                btnTopMiddle.Text = "PUSH";
            if (Indexes.Contains(2))
                btnMiddleLeft.Text = "PUSH";
            if (Indexes.Contains(3))
                btnMiddle.Text = "PUSH";
            if (Indexes.Contains(4))
                btnMiddleRight.Text = "PUSH";
            if (Indexes.Contains(5))
                btnBottomLeft.Text = "PUSH";
            if (Indexes.Contains(6))
                btnBottomMiddle.Text = "PUSH";
            if (Indexes.Contains(7))
                btnBottomRight.Text = "PUSH";
        }
    }

    public static class BlindAlleyModule
    {
        public static int[] Score = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] Calculate() 
        {
            Score[0] = CalculateTopLeft();
            Score[1] = CalculateTopMiddle();
            Score[2] = CalculateMiddleLeft();
            Score[3] = CalculateMiddle();
            Score[4] = CalculateMiddleRight();
            Score[5] = CalculateBottomLeft();
            Score[6] = CalculateBottomMiddle();
            Score[7] = CalculateBottomRight();
            return Score;
        }

        public static int CalculateTopLeft()
        {
            int Result = 0;
            if (Bomb.Indicators.Contains(Tuple.Create("bob", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("car", true)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("ind", true)))
                Result++;
            if ((Bomb.Holders % 2) == 0)
                Result++;
            Console.WriteLine("TopLeft Score: " + Result);
            return Result;
        }

        public static int CalculateTopMiddle()
        {
            int Result = 0;
            if (Bomb.Indicators.Contains(Tuple.Create("car", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("nsa", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("frk", true)))
                Result++;
            if (Bomb.PortsOnBomb.Contains(Bomb.Ports.rj45))
                Result++;
            Console.WriteLine("TopMiddle Score: " + Result);
            return Result;
        }

        public static int CalculateMiddleLeft()
        {
            int Result = 0;
            if (Bomb.Indicators.Contains(Tuple.Create("frq", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("ind", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("trn", false)))
                Result++;
            if (Bomb.PortsOnBomb.Contains(Bomb.Ports.dvi))
                Result++;
            Console.WriteLine("MiddleLeft Score: " + Result);
            return Result;
        }

        public static int CalculateMiddle()
        {
            int Result = 0;
            if (Bomb.Indicators.Contains(Tuple.Create("sig", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("snd", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("nsa", true)))
                Result++;
            if ((Bomb.Batteries % 2) == 0)
                Result++;
            Console.WriteLine("Middle Score: " + Result);
            return Result;
        }

        public static int CalculateMiddleRight()
        {
            int Result = 0;
            if (Bomb.Indicators.Contains(Tuple.Create("bob", true)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("clr", true)))
                Result++;
            if (Bomb.PortsOnBomb.Contains(Bomb.Ports.ps2))
                Result++;
            if (Bomb.PortsOnBomb.Contains(Bomb.Ports.serial))
                Result++;
            Console.WriteLine("MiddleRight Score: " + Result);
            return Result;
        }

        public static int CalculateBottomLeft()
        {
            int Result = 0;
            if (Bomb.Indicators.Contains(Tuple.Create("frq", true)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("sig", true)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("trn", true)))
                Result++;
            if (Bomb.HasEvenDigit())
                Result++;
            Console.WriteLine("BottomLeft Score: " + Result);
            return Result;
        }

        public static int CalculateBottomMiddle()
        {
            int Result = 0;
            if (Bomb.Indicators.Contains(Tuple.Create("frk", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("msa", true)))
                Result++;
            if (Bomb.PortsOnBomb.Contains(Bomb.Ports.parallel))
                Result++;
            if (Bomb.HasVowel)
                Result++;
            Console.WriteLine("BottomMiddle Score: " + Result);
            return Result;
        }

        public static int CalculateBottomRight()
        {
            int Result = 0;
            if (Bomb.Indicators.Contains(Tuple.Create("clr", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("msa", false)))
                Result++;
            if (Bomb.Indicators.Contains(Tuple.Create("snd", true)))
                Result++;
            if (Bomb.PortsOnBomb.Contains(Bomb.Ports.stereorca))
                Result++;
            Console.WriteLine("BottomRight Score: " + Result);
            return Result;
        }
    }
}
