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
    public partial class KnobForm : Form
    {
        public KnobForm()
        {
            InitializeComponent();
        }

        private void BoxChanged(object sender, EventArgs e)
        {
            if (Box1.Checked == false && Box2.Checked == false && Box3.Checked == true &&
                Box4.Checked == false && Box5.Checked == true && Box6.Checked == true &&
                Box7.Checked == true && Box8.Checked == true && Box9.Checked == true &&
                Box10.Checked == true && Box11.Checked == false && Box12.Checked == true)
                OutputBox.Text = "Up Position";
            else if (Box1.Checked == true && Box2.Checked == false && Box3.Checked == true &&
                Box4.Checked == false && Box5.Checked == true && Box6.Checked == false &&
                Box7.Checked == false && Box8.Checked == true && Box9.Checked == true &&
                Box10.Checked == false && Box11.Checked == true && Box12.Checked == true)
                OutputBox.Text = "Up Position";
            else if (Box1.Checked == false && Box2.Checked == true && Box3.Checked == true &&
                Box4.Checked == false && Box5.Checked == false && Box6.Checked == true &&
                Box7.Checked == true && Box8.Checked == true && Box9.Checked == true &&
                Box10.Checked == true && Box11.Checked == false && Box12.Checked == true)
                OutputBox.Text = "Down Position";
            else if (Box1.Checked == true && Box2.Checked == false && Box3.Checked == true &&
                Box4.Checked == false && Box5.Checked == true && Box6.Checked == false &&
                Box7.Checked == false && Box8.Checked == true && Box9.Checked == false &&
                Box10.Checked == false && Box11.Checked == false && Box12.Checked == true)
                OutputBox.Text = "Down Position";
            else if (Box1.Checked == false && Box2.Checked == false && Box3.Checked == false &&
                Box4.Checked == false && Box5.Checked == true && Box6.Checked == false &&
                Box7.Checked == true && Box8.Checked == false && Box9.Checked == false &&
                Box10.Checked == true && Box11.Checked == true && Box12.Checked == true)
                OutputBox.Text = "Left Position";
            else if (Box1.Checked == false && Box2.Checked == false && Box3.Checked == false &&
                Box4.Checked == false && Box5.Checked == true && Box6.Checked == false &&
                Box7.Checked == false && Box8.Checked == false && Box9.Checked == false &&
                Box10.Checked == true && Box11.Checked == true && Box12.Checked == false)
                OutputBox.Text = "Left Position";
            else if (Box1.Checked == true && Box2.Checked == false && Box3.Checked == true &&
                Box4.Checked == true && Box5.Checked == true && Box6.Checked == true &&
                Box7.Checked == true && Box8.Checked == true && Box9.Checked == true &&
                Box10.Checked == false && Box11.Checked == true && Box12.Checked == false)
                OutputBox.Text = "Right Position";
            else if (Box1.Checked == true && Box2.Checked == false && Box3.Checked == true &&
                Box4.Checked == true && Box5.Checked == false && Box6.Checked == false &&
                Box7.Checked == true && Box8.Checked == true && Box9.Checked == true &&
                Box10.Checked == false && Box11.Checked == true && Box12.Checked == false)
                OutputBox.Text = "Right Position";
            else
                OutputBox.Text = "Illegal Input";

        }
    }
}
