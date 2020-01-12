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
    public partial class MorseForm : Form
    {
        public MorseForm()
        {
            InitializeComponent();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            MorseModule.Buffer += ".";
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            MorseModule.Buffer += "-";
        }

        private void btnSpace_Click(object sender, EventArgs e) //TODO: Error Handling
        {
            MorseModule.Word += MorseModule.morseAlphabetDictionary[MorseModule.Buffer];
            MorseModule.Buffer = "";
            OutputBox.Text = MorseModule.Word;
            if (MorseModule.Solutions.ContainsKey(MorseModule.Word)) 
            {
                SolutionBox.Text = MorseModule.Solutions[MorseModule.Word];
                btnDash.Visible = false;
                btnDot.Visible = false;
                btnSpace.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MorseModule.Word = "";
            OutputBox.Text = MorseModule.Word;
        }
    }
}

public static class MorseModule //TODO: Add possibility to enter letters directly
{
    public static Dictionary<string, char> morseAlphabetDictionary = new Dictionary<string, char>()
                                   {
                                       {".-", 'a'},
                                       {"-...", 'b'},
                                       {"-.-.", 'c'},
                                       {"-..", 'd'},
                                       {".", 'e'},
                                       {"..-.", 'f'},
                                       {"--.", 'g'},
                                       {"....", 'h'},
                                       {"..", 'i'},
                                       {".---", 'j'},
                                       {"-.-", 'k'},
                                       {".-..", 'l'},
                                       {"--", 'm'},
                                       {"-.", 'n'},
                                       {"---", 'o'},
                                       {".--.", 'p'},
                                       {"--.-", 'q'},
                                       {".-.", 'r'},
                                       {"...", 's'},
                                       {"-", 't'},
                                       {"..-", 'u'},
                                       {"...-", 'v'},
                                       {".--", 'w'},
                                       {"-..-", 'x'},
                                       {"-.--", 'y'},
                                       {"--..", 'z'},
                                       {"-----", '0'},
                                       {".----", '1'},
                                       {"..---", '2'},
                                       {"...--", '3'},
                                       {"....-", '4'},
                                       {".....", '5'},
                                       {"-....", '6'},
                                       {"--...", '7'},
                                       {"---..", '8'},
                                       {"----.", '9'}
                                   };

    public static Dictionary<string, string> Solutions = new Dictionary<string, string>()
    {
        { "shell", "3.505" },
        { "halls", "3.515" },
        { "slick", "3.522" },
        { "trick", "3.532" },
        { "boxes", "3.535" },
        { "leaks", "3.542" },
        { "strobe", "3.545" },
        { "bistro", "3.552" },
        { "flick", "3.555" },
        { "bombs", "3.565" },
        { "break", "3.572" },
        { "brick", "3.575" },
        { "steak", "3.582" },
        { "sting", "3.592" },
        { "vector", "3.595" },
        { "beats", "3.600" }
    };

    public static string Buffer;
    public static string Word;
}

