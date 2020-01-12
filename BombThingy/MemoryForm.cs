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
    public partial class MemoryForm : Form
    {
        public MemoryForm()
        {
            InitializeComponent();
            OutputBox.Text = "Enter number on Display: ";
            MemoryModule.Stage = 0;

        }

        private void btnDisplay1_Click(object sender, EventArgs e)
        {
            HideDisplay();
            switch (MemoryModule.Stage)
            {
                case 0:
                    ShowLabel();
                    OutputBox.Text = "Press Position 2";
                    MemoryModule.Positions[0] = 2;
                    break;
                case 1:
                    ShowPosition();
                    OutputBox.Text = "Press Label 4";
                    MemoryModule.Labels[1] = 4;
                    break;
                case 2:
                    ShowPosition();
                    OutputBox.Text = "Press Label " + MemoryModule.Labels[1];
                    MemoryModule.Labels[2] = MemoryModule.Labels[1];
                    break;
                case 3:
                    ShowLabel();
                    OutputBox.Text = "Press Position " + MemoryModule.Positions[0];
                    MemoryModule.Positions[3] = MemoryModule.Positions[0];
                    break;
                case 4:
                    OutputBox.Text = "Press Label " + MemoryModule.Labels[0];
                    break;
                default:
                    break;
            }
        }

        private void btnDisplay2_Click(object sender, EventArgs e)
        {
            HideDisplay();
            switch (MemoryModule.Stage)
            {
                case 0:
                    ShowLabel();
                    OutputBox.Text = "Press Position 2";
                    MemoryModule.Positions[0] = 2;
                    break;
                case 1:
                    ShowLabel();
                    OutputBox.Text = "Press Position " + MemoryModule.Positions[0];
                    MemoryModule.Positions[1] = MemoryModule.Positions[0];
                    break;
                case 2:
                    ShowPosition();
                    OutputBox.Text = "Press Label " + MemoryModule.Labels[0];
                    MemoryModule.Labels[2] = MemoryModule.Labels[0];
                    break;
                case 3:
                    ShowLabel();
                    OutputBox.Text = "Press Position 1";
                    MemoryModule.Positions[3] = 1;
                    break;
                case 4:
                    OutputBox.Text = "Press Label " + MemoryModule.Labels[1];
                    break;
                default:
                    break;
            }
        }

        private void btnDisplay3_Click(object sender, EventArgs e)
        {
            HideDisplay();
            switch (MemoryModule.Stage)
            {
                case 0:
                    ShowLabel();
                    OutputBox.Text = "Press Position 3";
                    MemoryModule.Positions[0] = 3;
                    break;
                case 1:
                    ShowLabel();
                    OutputBox.Text = "Press Position 1";
                    MemoryModule.Positions[1] = 1;
                    break;
                case 2:
                    ShowLabel();
                    OutputBox.Text = "Press Position 3";
                    MemoryModule.Positions[2] = 3;
                    break;
                case 3:
                    ShowLabel();
                    OutputBox.Text = "Press Position " + MemoryModule.Positions[1];
                    MemoryModule.Positions[3] = 3;
                    break;
                case 4:
                    OutputBox.Text = "Press Label " + MemoryModule.Labels[3];
                    break;
                default:
                    break;
            }
        }

        private void btnDisplay4_Click(object sender, EventArgs e)
        {
            HideDisplay();
            switch (MemoryModule.Stage)
            {
                case 0:
                    ShowLabel();
                    OutputBox.Text = "Press Position 4";
                    MemoryModule.Positions[0] = 4;
                    break;
                case 1:
                    ShowLabel();
                    OutputBox.Text = "Press Position " + MemoryModule.Positions[0];
                    MemoryModule.Positions[1] = MemoryModule.Positions[0];
                    break;
                case 2:
                    ShowPosition();
                    OutputBox.Text = "Press Label 4";
                    MemoryModule.Labels[2] = 4;
                    break;
                case 3:
                    ShowLabel();
                    OutputBox.Text = "Press Position " + MemoryModule.Positions[1];
                    MemoryModule.Positions[3] = MemoryModule.Positions[1];
                    break;
                case 4:
                    OutputBox.Text = "Press Label " + MemoryModule.Labels[2];
                    break;

                default:
                    break;
            }
        }
        private void HideDisplay()
        {
            btnDisplay1.Visible = false;
            btnDisplay2.Visible = false;
            btnDisplay3.Visible = false;
            btnDisplay4.Visible = false;
            lblDisplay.Visible = false;
        }

        private void ShowDisplay()
        {
            btnDisplay1.Visible = true;
            btnDisplay2.Visible = true;
            btnDisplay3.Visible = true;
            btnDisplay4.Visible = true;
            lblDisplay.Visible = true;
        }

        private void HidePosition()
        {
            btnPosition1.Visible = false;
            btnPosition2.Visible = false;
            btnPosition3.Visible = false;
            btnPosition4.Visible = false;
            lblPosition.Visible = false;
        }

        private void ShowPosition()
        {
            btnPosition1.Visible = true;
            btnPosition2.Visible = true;
            btnPosition3.Visible = true;
            btnPosition4.Visible = true;
            lblPosition.Visible = true;
        }

        private void HideLabel()
        {
            btnLabel1.Visible = false;
            btnLabel2.Visible = false;
            btnLabel3.Visible = false;
            btnLabel4.Visible = false;
            lblLabel.Visible = false;
        }

        private void ShowLabel()
        {
            btnLabel1.Visible = true;
            btnLabel2.Visible = true;
            btnLabel3.Visible = true;
            btnLabel4.Visible = true;
            lblLabel.Visible = true;
        }

        private void btnLabel1_Click(object sender, EventArgs e)
        {
            MemoryModule.Labels[MemoryModule.Stage] = 1;
            HideLabel();
            ShowDisplay();
            MemoryModule.Stage++;
        }

        private void btnLabel2_Click(object sender, EventArgs e)
        {
            MemoryModule.Labels[MemoryModule.Stage] = 2;
            HideLabel();
            ShowDisplay();
            MemoryModule.Stage++;
        }

        private void btnLabel3_Click(object sender, EventArgs e)
        {
            MemoryModule.Labels[MemoryModule.Stage] = 3;
            HideLabel();
            ShowDisplay();
            MemoryModule.Stage++;
        }

        private void btnLabel4_Click(object sender, EventArgs e)
        {
            MemoryModule.Labels[MemoryModule.Stage] = 4;
            HideLabel();
            ShowDisplay();
            MemoryModule.Stage++;
        }

        private void btnPosition1_Click(object sender, EventArgs e)
        {
            MemoryModule.Positions[MemoryModule.Stage] = 1;
            HidePosition();
            ShowDisplay();
            MemoryModule.Stage++;
        }

        private void btnPosition2_Click(object sender, EventArgs e)
        {
            MemoryModule.Positions[MemoryModule.Stage] = 2;
            HidePosition();
            ShowDisplay();
            MemoryModule.Stage++;
        }

        private void btnPosition3_Click(object sender, EventArgs e)
        {
            MemoryModule.Positions[MemoryModule.Stage] = 3;
            HidePosition();
            ShowDisplay();
            MemoryModule.Stage++;
        }

        private void btnPosition4_Click(object sender, EventArgs e)
        {
            MemoryModule.Positions[MemoryModule.Stage] = 4;
            HidePosition();
            ShowDisplay();
            MemoryModule.Stage++;
        }
    }

    public class MemoryModule
    {
        public static int Stage = 0;
        public static int Status = 0;
        public static List<int> Labels = new List<int> { 0, 0, 0, 0 };
        public static List<int> Positions = new List<int> { 0, 0, 0, 0 };
        

    }

}
