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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            SolutionBox.Items.Clear();
            PasswordModule.PossiblePasswords = PasswordModule.CorrectPasswords;
            foreach (string a in PasswordModule.PossiblePasswords)
                SolutionBox.Items.Add(a);
        }

        private void Letter1Box1_TextChanged(object sender, EventArgs e)
        {
            Letter1Box1.Enabled = false;
        }

        private void Letter1Box2_TextChanged(object sender, EventArgs e)
        {
            Letter1Box2.Enabled = false;
        }

        private void Letter1Box3_TextChanged(object sender, EventArgs e)
        {
            Letter1Box3.Enabled = false;
        }

        private void Letter1Box4_TextChanged(object sender, EventArgs e)
        {
            Letter1Box4.Enabled = false;
        }

        private void Letter1Box5_TextChanged(object sender, EventArgs e)
        {
            Letter1Box5.Enabled = false;
        }

        private void Letter1Box6_TextChanged(object sender, EventArgs e)
        {
            Letter1Box6.Enabled = false;
            UpdateLetter(1);

        }

        private void Letter2Box1_TextChanged(object sender, EventArgs e)
        {
            Letter2Box1.Enabled = false;
        }

        private void Letter2Box2_TextChanged(object sender, EventArgs e)
        {
            Letter2Box2.Enabled = false;
        }

        private void Letter2Box3_TextChanged(object sender, EventArgs e)
        {
            Letter2Box3.Enabled = false;
        }

        private void Letter2Box4_TextChanged(object sender, EventArgs e)
        {
            Letter2Box4.Enabled = false;
        }

        private void Letter2Box5_TextChanged(object sender, EventArgs e)
        {
            Letter2Box5.Enabled = false;
        }

        private void Letter2Box6_TextChanged(object sender, EventArgs e)
        {
            Letter2Box6.Enabled = false;
            UpdateLetter(2);
        }

        private void Letter3Box1_TextChanged(object sender, EventArgs e)
        {
            Letter3Box1.Enabled = false;
        }

        private void Letter3Box2_TextChanged(object sender, EventArgs e)
        {
            Letter3Box2.Enabled = false;
        }

        private void Letter3Box3_TextChanged(object sender, EventArgs e)
        {
            Letter3Box3.Enabled = false;
        }

        private void Letter3Box4_TextChanged(object sender, EventArgs e)
        {
            Letter3Box4.Enabled = false;
        }

        private void Letter3Box5_TextChanged(object sender, EventArgs e)
        {
            Letter3Box5.Enabled = false;
        }

        private void Letter3Box6_TextChanged(object sender, EventArgs e)
        {
            Letter3Box6.Enabled = false;
            UpdateLetter(3);
        }

        private void Letter4Box1_TextChanged(object sender, EventArgs e)
        {
            Letter4Box1.Enabled = false;
        }

        private void Letter4Box2_TextChanged(object sender, EventArgs e)
        {
            Letter4Box2.Enabled = false;
        }

        private void Letter4Box3_TextChanged(object sender, EventArgs e)
        {
            Letter4Box3.Enabled = false;
        }

        private void Letter4Box4_TextChanged(object sender, EventArgs e)
        {
            Letter4Box4.Enabled = false;
        }

        private void Letter4Box5_TextChanged(object sender, EventArgs e)
        {
            Letter4Box5.Enabled = false;
        }

        private void Letter4Box6_TextChanged(object sender, EventArgs e)
        {
            Letter4Box6.Enabled = false;
            UpdateLetter(4);
        }

        private void Letter5Box1_TextChanged(object sender, EventArgs e)
        {
            Letter5Box1.Enabled = false;
        }

        private void Letter5Box2_TextChanged(object sender, EventArgs e)
        {
            Letter5Box2.Enabled = false;
        }

        private void Letter5Box3_TextChanged(object sender, EventArgs e)
        {
            Letter5Box3.Enabled = false;
        }

        private void Letter5Box4_TextChanged(object sender, EventArgs e)
        {
            Letter5Box4.Enabled = false;
        }

        private void Letter5Box5_TextChanged(object sender, EventArgs e)
        {
            Letter5Box5.Enabled = false;
        }

        private void Letter5Box6_TextChanged(object sender, EventArgs e)
        {
            Letter5Box6.Enabled = false;
            UpdateLetter(5);
        }


        private void UpdateLetter(int Position)
        {
            List<char> LetterList;
            switch (Position)
            {
                case 1:
                    LetterList = new List<char>() { Letter1Box1.Text[0], Letter1Box2.Text[0], Letter1Box3.Text[0], Letter1Box4.Text[0],
                Letter1Box5.Text[0], Letter1Box6.Text[0] };
                    break;
                case 2:
                    LetterList = new List<char>() { Letter2Box1.Text[0], Letter2Box2.Text[0], Letter2Box3.Text[0], Letter2Box4.Text[0],
                Letter2Box5.Text[0], Letter2Box6.Text[0] };
                    break;
                case 3:
                    LetterList = new List<char>() { Letter3Box1.Text[0], Letter3Box2.Text[0], Letter3Box3.Text[0], Letter3Box4.Text[0],
                Letter3Box5.Text[0], Letter3Box6.Text[0] };
                    break;
                case 4:
                    LetterList = new List<char>() { Letter4Box1.Text[0], Letter4Box2.Text[0], Letter4Box3.Text[0], Letter4Box4.Text[0],
                Letter4Box5.Text[0], Letter4Box6.Text[0] };
                    break;
                case 5:
                    LetterList = new List<char>() { Letter5Box1.Text[0], Letter5Box2.Text[0], Letter5Box3.Text[0], Letter5Box4.Text[0],
                Letter5Box5.Text[0], Letter5Box6.Text[0] };
                    break;

                default:
                    return;
            }
            for (int i = 0; i < 6; i++)
            {
                foreach (string a in PasswordModule.PossiblePasswords.ToList()) //mutating the list itself while doing a foreach on it is no bueno
                {
                    if (!LetterList.Contains(a[Position - 1]) && PasswordModule.PossiblePasswords.Contains(a))
                    {
                        PasswordModule.PossiblePasswords.Remove(a);
                    }
                }
            }

            SolutionBox.Items.Clear();
            foreach (var s in PasswordModule.PossiblePasswords)
                SolutionBox.Items.Add(s);
        }
    }


    public static class PasswordModule
    {

        public static List<string> CorrectPasswords = new List<string>() { "about", "after", "again", "below", 
            "could", "every", "first", "found", "great", "house", "large", "learn", "never", "other", "place", 
            "plant", "point", "right", "small", "sound", "spell", "still", "study","their", "there", 
            "these", "thing", "think", "three", "water", "where", "which", "world", "would", "write" };

        public static List<string> PossiblePasswords = new List<string>(){ "about", "after", "again", "below",
            "could", "every", "first", "found", "great", "house", "large", "learn", "never", "other", "place",
            "plant", "point", "right", "small", "sound", "spell", "still", "study","their", "there",
            "these", "thing", "think", "three", "water", "where", "which", "world", "would", "write" };


    }
}
