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
    public partial class SkewedSlotsForm : Form
    {
        public SkewedSlotsForm()
        {
            InitializeComponent();
            SkewedSlotsModule.Original1 = -1;
            SkewedSlotsModule.Original2 = -1;
            SkewedSlotsModule.Original3 = -1;
        }

        private void InputBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InputBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InputBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputBox3.Text))
                return;
            SkewedSlotsModule.Original3 = Convert.ToInt32(InputBox3.Text);
            SkewedSlotsModule.Solution3 = ProcessFirstPart(SkewedSlotsModule.Original3);
            SkewedSlotsModule.Solution3 = ProcessThirdDigit(SkewedSlotsModule.Solution3);
            while (SkewedSlotsModule.Solution3 > 9)
                SkewedSlotsModule.Solution3 -= 10;
            while (SkewedSlotsModule.Solution3 < 0)
                SkewedSlotsModule.Solution3 += 10;
            OutputBox3.Text = SkewedSlotsModule.Solution3.ToString();
            if (string.IsNullOrWhiteSpace(InputBox2.Text))
                return;
            SkewedSlotsModule.Original2 = Convert.ToInt32(InputBox2.Text);
            SkewedSlotsModule.Solution2 = ProcessFirstPart(SkewedSlotsModule.Original2);
            SkewedSlotsModule.Solution2 = ProcessSecondDigit(SkewedSlotsModule.Solution2);
            while (SkewedSlotsModule.Solution2 > 9)
                SkewedSlotsModule.Solution2 -= 10;
            while (SkewedSlotsModule.Solution2 < 0)
                SkewedSlotsModule.Solution2 += 10;
            OutputBox2.Text = SkewedSlotsModule.Solution2.ToString();
            if (string.IsNullOrWhiteSpace(InputBox1.Text))
                return;
            SkewedSlotsModule.Original1 = Convert.ToInt32(InputBox1.Text);
            SkewedSlotsModule.Solution1 = ProcessFirstPart(SkewedSlotsModule.Original1);
            SkewedSlotsModule.Solution1 = ProcessFirstDigit(SkewedSlotsModule.Solution1);
            while (SkewedSlotsModule.Solution1 > 9)
                SkewedSlotsModule.Solution1 -= 10;
            while (SkewedSlotsModule.Solution1 < 0)
                SkewedSlotsModule.Solution1 += 10;
            OutputBox1.Text = SkewedSlotsModule.Solution1.ToString();
        }

        private int ProcessFirstPart(int Input)
        {
            int Original = Input;
            if (Input == 2) //Replace 2 with 5 and 7 with 0
                Input = 5;
            if (Input == 7)
                Input = 0;
            foreach (var Ind in Bomb.Indicators) //For each lit indicator, add 1, for each unlit, subtract 1
            {
                if (Ind.Item2 == true)
                    Input++;
                if (Ind.Item2 == false)
                    Input--;
            }

            if (Input % 3 == 0)
                return Input + 4;
            else if (Input > 7)
                return Input * 2;
            else if (Input < 3 && (Input % 2 == 0))
                return Input / 2;
            else if (Bomb.PortsOnBomb.Contains(Bomb.Ports.stereorca) || Bomb.PortsOnBomb.Contains(Bomb.Ports.rj45))
                return Input;
            else
                return Original + Bomb.Batteries;
            
        }

        private int ProcessFirstDigit(int Input)
        {
            if ((Input % 2 == 0) && Input > 5)
                return Input / 2;
            else if (SkewedSlotsModule.Primes.Contains(Input))
                return Input + Bomb.GetRightmostSerialDigit();
            else if (Bomb.PortsOnBomb.Contains(Bomb.Ports.parallel))
                return Input * (-1);
            else if ((SkewedSlotsModule.Original2 % 2) == 1)
                return Input;
            else
                return Input - 2;

        }

        private int ProcessSecondDigit(int Input)
        {
            if (Bomb.Indicators.Contains(Tuple.Create("bob", false)))
                return Input;
            else if (Input == 0)
                return Input + SkewedSlotsModule.Original2;
            else if (SkewedSlotsModule.Fibonacci.Contains(Input))
            {
                int Index = SkewedSlotsModule.Fibonacci.IndexOf(Input);
                return SkewedSlotsModule.Fibonacci[Index + 2];
            }
            else if (Input >= 7)
                return Input + 4;
            else
                return Input * 3;
        }

        private int ProcessThirdDigit(int Input)
        {
            if (Bomb.PortsOnBomb.Contains(Bomb.Ports.serial))
                return Input + Bomb.GetLargestSerialDigit();
            else if ((SkewedSlotsModule.Original3 == SkewedSlotsModule.Original1) ||
                (SkewedSlotsModule.Original3 == SkewedSlotsModule.Original2))
                return Input;
            else if (Input >= 5)
                return SkewedSlotsModule.GetBinaryAddition(SkewedSlotsModule.Original3);
            else
                return Input + 1;

        }
    }

    public static class SkewedSlotsModule
    {
        public static int Original1;
        public static int Original2;
        public static int Original3;

        public static int Solution1;
        public static int Solution2;
        public static int Solution3;

        public static List<int> Primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }; //this should be faster than a dedicated isPrime function, but is very naive
        public static List<int> Fibonacci = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

        public static int GetBinaryAddition(int Input)
        {
            if (Input == 0)
                return 0;
            else if (Input == 1 || Input == 2 || Input == 4 || Input == 8)
                return 1;
            else if (Input == 3 || Input == 5 || Input == 6 || Input == 9)
                return 2;
            else if (Input == 7)
                return 3;
            else
                return -1;
        }

        public static bool Initialized()
        {
            if (Original1 == -1 || Original2 == -1 || Original3 == -1)
                return false;
            else
                return true;
        }
    }

}


