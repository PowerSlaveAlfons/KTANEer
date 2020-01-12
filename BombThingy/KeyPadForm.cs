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
    public partial class KeyPadForm : Form
    {
        public KeyPadForm()
        {
            InitializeComponent();
            KeyPadModule.InputList.Clear();
        }

        private void btn3R_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.R3);
            reCalculateBox();
        }

        private void btn3Snake_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Snake3);
            reCalculateBox();
        }

        private void btnae_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.ae);
            reCalculateBox();
        }

        private void btnAT_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.AT);
            reCalculateBox();
        }

        private void btnBoobies_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Boobies);
            reCalculateBox();
        }

        private void btnbWithT_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.bWithT);
            reCalculateBox();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Cat);
            reCalculateBox();
        }

        private void btnCDot_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.CDot);
            reCalculateBox();
        }

        private void btnCopyright_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Copyright);
            reCalculateBox();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Euro);
            reCalculateBox();
        }

        private void btnHHandWritten_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.HHandWritten);
            reCalculateBox();
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Lambda);
            reCalculateBox();
        }

        private void btnMirroredCDot_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.MirroredCDot);
            reCalculateBox();
        }

        private void btnNReverse_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.NReverse);
            reCalculateBox();
        }

        private void btnNTilted_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.NTilted);
            reCalculateBox();
        }

        private void btnOmega_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Omega);
            reCalculateBox();
        }

        private void btnParagraph_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Paragraph);
            reCalculateBox();
        }

        private void btnQHandWritten_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.QHandWritten);
            reCalculateBox();
        }

        private void btnQStraight_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.QStraight);
            reCalculateBox();
        }

        private void btnQuestionMark_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.QuestionMark);
            reCalculateBox();
        }

        private void btnSigma_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Sigma);
            reCalculateBox();
        }

        private void btnSlantedH_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.SlantedH);
            reCalculateBox();
        }

        private void btnSmiley_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Smiley);
            reCalculateBox();
        }

        private void btnStarEmpty_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.StarEmpty);
            reCalculateBox();
        }

        private void btnStarFilled_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.StarFilled);
            reCalculateBox();
        }

        private void btnTrident_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.Trident);
            reCalculateBox();
        }

        private void btnXKI_Click(object sender, EventArgs e)
        {
            KeyPadModule.InputList.Add(KeyPadModule.Keys.XKI);
            reCalculateBox();
        }

        private void reCalculateBox()
        {
            KeyPadBox.Items.Clear();
            foreach (KeyPadModule.Keys a in KeyPadModule.InputList)
            {
                KeyPadBox.Items.Add(a);
            }
            if (KeyPadModule.InputList.Count() == 4)
            {
                Solve();
            }
        }

        private void Solve()
        {
            HideAll();
            List<Boolean> KeysFound = new List<Boolean>();
            List<KeyPadModule.Keys> SolutionOrder = new List<KeyPadModule.Keys>();
            Boolean ListFound = false;
            int ListIndex = 99;
            int Iterator = 0;
            List<int> SolutionIndices = new List<int>();
            for (int i = 0; i < KeyPadModule.SolutionLists.Count(); i++) //iterates over all possible lists
            {
                if (ListFound == true)
                    break;
                SolutionIndices.Clear();
                KeysFound.Clear();
                KeysFound.Add(false);
                KeysFound.Add(false);
                KeysFound.Add(false);
                KeysFound.Add(false);
                Iterator = 0;

                foreach (var Keypad in KeyPadModule.SolutionLists[i]) //iterates over all symbols in list
                {
                    for (int j = 0; j < 4; j++) //compares all 4 input symbols to symbol in list
                    {
                        if (Keypad == KeyPadModule.InputList[j]) 
                        {
                            SolutionIndices.Add(Iterator);
                            KeysFound[j] = true;
                        }
                    }
                    if (!KeysFound.Contains(false)) //if all symbols have been found, escape loop
                    {
                        ListFound = true;
                        ListIndex = i; //save index of correct list for solving
                        break;
                    }
                    Iterator++;
                }
            }
            if (!ListFound || (SolutionIndices.Count() < 4) || (ListIndex > 5) || (SolutionIndices.Count() != SolutionIndices.Distinct().Count()))
            {
                Close(); //TODO: Add Error
                return;
            }
            SolutionIndices.Sort(); //Sorts index of found symbols
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(ListIndex);
                Console.WriteLine(SolutionIndices[i]);
                Console.WriteLine(i);
                SolutionOrder.Add(KeyPadModule.SolutionLists[ListIndex][SolutionIndices[i]]);
            }
            Button btn1 = new Button();
            Button btn2 = new Button();
            Button btn3 = new Button();
            Button btn4 = new Button();
            Button btnClose = new Button();

            btn1.Location = new System.Drawing.Point(324, 12);
            btn2.Location = new System.Drawing.Point(324, 85);
            btn3.Location = new System.Drawing.Point(324, 158);
            btn4.Location = new System.Drawing.Point(324, 231);
            btnClose.Location = new System.Drawing.Point(324, 350);
            btn1.Size = new System.Drawing.Size(72, 67);
            btn2.Size = new System.Drawing.Size(72, 67);
            btn3.Size = new System.Drawing.Size(72, 67);
            btn4.Size = new System.Drawing.Size(72, 67);
            btnClose.Size = new System.Drawing.Size(72, 30);

            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btnClose.Visible = true;

            btn1.BackgroundImage = GetBackground(SolutionOrder[0]);
            btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn2.BackgroundImage = GetBackground(SolutionOrder[1]);
            btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn3.BackgroundImage = GetBackground(SolutionOrder[2]);
            btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn4.BackgroundImage = GetBackground(SolutionOrder[3]);
            btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnClose.Text = "Close";
            btnClose.Click += new System.EventHandler(Closer);

            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            this.Controls.Add(btnClose);
        }

        private void HideAll()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Visible = false;
            }
        }

        private void Closer(object sender, EventArgs e)
        {
            Close();
        }

        System.Drawing.Bitmap GetBackground(KeyPadModule.Keys Input)
        {
            switch(Input)
            {
                case KeyPadModule.Keys.R3:
                    return Properties.Resources._3R;
                case KeyPadModule.Keys.Snake3:
                    return Properties.Resources._3Snake;
                case KeyPadModule.Keys.ae:
                    return Properties.Resources.ae;
                case KeyPadModule.Keys.AT:
                    return Properties.Resources.AT;
                case KeyPadModule.Keys.Boobies:
                    return Properties.Resources.Boobies;
                case KeyPadModule.Keys.bWithT:
                    return Properties.Resources.bWithT;
                case KeyPadModule.Keys.Cat:
                    return Properties.Resources.Cat;
                case KeyPadModule.Keys.CDot:
                    return Properties.Resources.CDot;
                case KeyPadModule.Keys.Copyright:
                    return Properties.Resources.Copyright;
                case KeyPadModule.Keys.Euro:
                    return Properties.Resources.Euro;
                case KeyPadModule.Keys.HHandWritten:
                    return Properties.Resources.HHandWritten;
                case KeyPadModule.Keys.Lambda:
                    return Properties.Resources.Lambda;
                case KeyPadModule.Keys.MirroredCDot:
                    return Properties.Resources.MirroredCDot;
                case KeyPadModule.Keys.NReverse:
                    return Properties.Resources.NReverse;
                case KeyPadModule.Keys.NTilted:
                    return Properties.Resources.NTilted;
                case KeyPadModule.Keys.Omega:
                    return Properties.Resources.Omega;
                case KeyPadModule.Keys.Paragraph:
                    return Properties.Resources.Paragraph;
                case KeyPadModule.Keys.QHandWritten:
                    return Properties.Resources.QHandWritten;
                case KeyPadModule.Keys.QStraight:
                    return Properties.Resources.QStraight;
                case KeyPadModule.Keys.QuestionMark:
                    return Properties.Resources.QuestionMark;
                case KeyPadModule.Keys.Sigma:
                    return Properties.Resources.Sigma;
                case KeyPadModule.Keys.SlantedH:
                    return Properties.Resources.SlantedH;
                case KeyPadModule.Keys.Smiley:
                    return Properties.Resources.Smiley;
                case KeyPadModule.Keys.StarEmpty:
                    return Properties.Resources.StarEmpty;
                case KeyPadModule.Keys.StarFilled:
                    return Properties.Resources.StarFilled;
                case KeyPadModule.Keys.Trident:
                    return Properties.Resources.Trident;
                case KeyPadModule.Keys.XKI:
                    return Properties.Resources.XKI;


                default:
                    return null;
            }
        }
    }

    public class KeyPadModule
    {
        public enum Keys { R3, Snake3, ae, AT, Boobies, bWithT, Cat, CDot, Copyright, Euro, HHandWritten, 
            Lambda, MirroredCDot, NReverse, NTilted, Omega, Paragraph, QHandWritten, QStraight, QuestionMark, 
            Sigma, SlantedH, Smiley, StarEmpty, StarFilled, Trident, XKI }

        public static List<List<Keys>> SolutionLists = new List<List<Keys>> 
        {   (new List<Keys> { Keys.QStraight, Keys.AT, Keys.Lambda, Keys.NTilted,
            Keys.Cat, Keys.HHandWritten, Keys.MirroredCDot }),
            (new List<Keys> { Keys.Euro, Keys.QStraight, Keys.MirroredCDot,
            Keys.QHandWritten, Keys.StarEmpty, Keys.HHandWritten, Keys.QuestionMark }), 
            (new List<Keys> { Keys.Copyright, Keys.Boobies, Keys.QHandWritten,
            Keys.XKI, Keys.R3, Keys.Lambda, Keys.StarEmpty }), 
            (new List<Keys> { Keys.Sigma, Keys.Paragraph, Keys.bWithT,
            Keys.Cat, Keys.XKI, Keys.QuestionMark, Keys.Smiley }),
            (new List<Keys> { Keys.Trident, Keys.Smiley, Keys.bWithT, Keys.CDot,
            Keys.Paragraph, Keys.Snake3, Keys.StarFilled }), 
            (new List<Keys> { Keys.Sigma, Keys.Euro, Keys.SlantedH, Keys.ae,
            Keys.Trident, Keys.NReverse, Keys.Omega }) };

        public static List<Keys> InputList = new List<Keys>();
    }
}
