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
    public partial class WhosOnFirstForm : Form
    {
        public WhosOnFirstForm()
        {
            InitializeComponent();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Left";
            Transition();
        }

        private void btnBlank_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Right";
            Transition();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Top Right";
            Transition();
        }

        private void btnCee_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Right";
            Transition();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Right";
            Transition();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Top Right";
            Transition();
        }

        private void btnHoldOn_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Right";
            Transition();
        }

        private void btnLead_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Right";
            Transition();
        }

        private void btnLed_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Left";
            Transition();
        }

        private void btnLeed_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Left";
            Transition();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Right";
            Transition();
        }

        private void btnNothing_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Left";
            Transition();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Top Right";
            Transition();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Right";
            Transition();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Right";
            Transition();
        }

        private void btnReed_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Left";
            Transition();
        }

        private void btnSays_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Right";
            Transition();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Right";
            Transition();
        }

        private void btnTheir_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Right";
            Transition();
        }

        private void btnThere_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Right";
            Transition();
        }

        private void btnTheyAre_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Left";
            Transition();
        }

        private void btnTheyRe_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Left";
            Transition();
        }

        private void btnUR_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Top Left";
            Transition();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Left";
            Transition();
        }

        private void btnYou_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Right";
            Transition();
        }

        private void btnYouAre_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Bottom Right";
            Transition();
        }

        private void btnYouRe_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Right";
            Transition();
        }

        private void btnYour_Click(object sender, EventArgs e)
        {
            LocationBox.Text = "Middle Right";
            Transition();
        }

        private void Transition()
        {
            btnEmpty.Visible = false;
            btnBlank.Visible = false;
            btnC.Visible = false;
            btnCee.Visible = false;
            btnDisplay.Visible = false;
            btnFirst.Visible = false;
            btnHoldOn.Visible = false;
            btnLead.Visible = false;
            btnLed.Visible = false;
            btnLeed.Visible = false;
            btnNo.Visible = false;
            btnNothing.Visible = false;
            btnOkay.Visible = false;
            btnRead.Visible = false;
            btnRed.Visible = false;
            btnReed.Visible = false;
            btnSays.Visible = false;
            btnSee.Visible = false;
            btnTheir.Visible = false;
            btnThere.Visible = false;
            btnTheyAre.Visible = false;
            btnTheyRe.Visible = false;
            btnUR.Visible = false;
            btnYes.Visible = false;
            btnYou.Visible = false;
            btnYouAre.Visible = false;
            btnYouRe.Visible = false;
            btnYour.Visible = false;

            btn2Blank.Visible = true;
            btn2Done.Visible = true;
            btn2First.Visible = true;
            btn2Hold.Visible = true;
            btn2Left.Visible = true;
            btn2Like.Visible = true;
            btn2Middle.Visible = true;
            btn2Next.Visible = true;
            btn2No.Visible = true;
            btn2Nothing.Visible = true;
            btn2Okay.Visible = true;
            btn2Press.Visible = true;
            btn2Ready.Visible = true;
            btn2Right.Visible = true;
            btn2Sure.Visible = true;
            btn2U.Visible = true;
            btn2UhHuh.Visible = true;
            btn2UhUh.Visible = true;
            btn2Uhhh.Visible = true;
            btn2UR.Visible = true;
            btn2Wait.Visible = true;
            btn2What.Visible = true;
            btn2WhatQuestionMark.Visible = true;
            btn2Yes.Visible = true;
            btn2You.Visible = true;
            btn2YouAre.Visible = true;
            btn2YouRe.Visible = true;
            btn2Your.Visible = true;
            btnStage.Visible = true;

        }

        private void btn2Blank_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "WAIT, RIGHT, OKAY, MIDDLE, BLANK, PRESS, READY, NOTHING, NO, WHAT, LEFT, UHHH, YES, FIRST";
        }

        private void btn2Done_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "SURE, UH HUH, NEXT, WHAT?, YOUR, UR, YOU'RE, HOLD, LIKE, YOU, U, YOU ARE, UH UH, DONE";
        }

        private void btn2First_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "LEFT, OKAY, YES, MIDDLE, NO, RIGHT, NOTHING, UHHH, WAIT, READY, BLANK, WHAT, PRESS, FIRST";
        }

        private void btn2Hold_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "YOU ARE, U, DONE, UH UH, YOU, UR, SURE, WHAT ?, YOU'RE, NEXT, HOLD, UH HUH, YOUR, LIKE";
        }

        private void btn2Left_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "RIGHT, LEFT, FIRST, NO, MIDDLE, YES, BLANK, WHAT, UHHH, WAIT, PRESS, READY, OKAY, NOTHING";
        }

        private void btn2Like_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "YOU'RE, NEXT, U, UR, HOLD, DONE, UH UH, WHAT?, UH HUH, YOU, LIKE, SURE, YOU ARE, YOUR";
        }

        private void btn2Middle_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "BLANK, READY, OKAY, WHAT, NOTHING, PRESS, NO, WAIT, LEFT, MIDDLE, RIGHT, FIRST, UHHH, YES";
        }

        private void btn2Next_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "WHAT?, UH HUH, UH UH, YOUR, HOLD, SURE, NEXT, LIKE, DONE, YOU ARE, UR, YOU'RE, U, YOU";
        }

        private void btn2No_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "BLANK, UHHH, WAIT, FIRST, WHAT, READY, RIGHT, YES, NOTHING, LEFT, PRESS, OKAY, NO, MIDDLE";
        }

        private void btn2Nothing_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "UHHH, RIGHT, OKAY, MIDDLE, YES, BLANK, NO, PRESS, LEFT, WHAT, WAIT, FIRST, NOTHING, READY";
        }

        private void btn2Okay_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "MIDDLE, NO, FIRST, YES, UHHH, NOTHING, WAIT, OKAY, LEFT, READY, BLANK, PRESS, WHAT, RIGHT";
        }

        private void btn2Press_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "RIGHT, MIDDLE, YES, READY, PRESS, OKAY, NOTHING, UHHH, BLANK, LEFT, FIRST, WHAT, NO, WAIT";
        }

        private void btn2Ready_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "YES, OKAY, WHAT, MIDDLE, LEFT, PRESS, RIGHT, BLANK, READY, NO, FIRST, UHHH, NOTHING, WAIT";
        }

        private void btn2Right_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "YES, NOTHING, READY, PRESS, NO, WAIT, WHAT, RIGHT, MIDDLE, LEFT, UHHH, BLANK, OKAY, FIRST";
        }

        private void btn2Sure_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "YOU ARE, DONE, LIKE, YOU'RE, YOU, HOLD, UH HUH, UR, SURE, U, WHAT?, NEXT, YOUR, UH UH";
        }

        private void btn2U_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "UH HUH, SURE, NEXT, WHAT?, YOU'RE, UR, UH UH, DONE, U, YOU, LIKE, HOLD, YOU ARE, YOUR";
        }

        private void btn2UhHuh_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "UH HUH, YOUR, YOU ARE, YOU, DONE, HOLD, UH UH, NEXT, SURE, LIKE, YOU'RE, UR, U, WHAT?";
        }

        private void btn2UhUh_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "UR, U, YOU ARE, YOU'RE, NEXT, UH UH, DONE, YOU, UH HUH, LIKE, YOUR, SURE, HOLD, WHAT?";
        }

        private void btn2Uhhh_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "READY, NOTHING, LEFT, WHAT, OKAY, YES, RIGHT, NO, PRESS, BLANK, UHHH, MIDDLE, WAIT, FIRST";
        }

        private void btn2UR_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "DONE, U, UR, UH HUH, WHAT?, SURE, YOUR, HOLD, YOU'RE, LIKE, NEXT, UH UH, YOU ARE, YOU";
        }

        private void btn2Wait_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "UHHH, NO, BLANK, OKAY, YES, LEFT, FIRST, PRESS, WHAT, WAIT, NOTHING, READY, RIGHT, MIDDLE";
        }

        private void btn2What_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "UHHH, WHAT, LEFT, NOTHING, READY, BLANK, MIDDLE, NO, OKAY, FIRST, WAIT, YES, PRESS, RIGHT";
        }

        private void btn2WhatQuestionMark_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "YOU, HOLD, YOU'RE, YOUR, U, DONE, UH UH, LIKE, YOU ARE, UH HUH, UR, NEXT, WHAT?, SURE";
        }

        private void btn2Yes_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "OKAY, RIGHT, UHHH, MIDDLE, FIRST, WHAT, PRESS, READY, NOTHING, YES, LEFT, BLANK, NO, WAIT";
        }

        private void btn2You_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "SURE, YOU ARE, YOUR, YOU'RE, NEXT, UH HUH, UR, HOLD, WHAT?, YOU, UH UH, LIKE, DONE, U";
        }

        private void btn2YouAre_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "YOUR, NEXT, LIKE, UH HUH, WHAT?, DONE, UH UH, HOLD, YOU, U, YOU'RE, SURE, UR, YOU ARE";
        }

        private void btn2YouRe_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "YOU, YOU'RE, UR, NEXT, UH UH, YOU ARE, U, YOUR, WHAT?, UH HUH, SURE, DONE, LIKE, HOLD";
        }

        private void btn2Your_Click(object sender, EventArgs e)
        {
            SolutionBox.Text = "UH UH, YOU ARE, UH HUH, YOUR, NEXT, UR, SURE, U, YOU'RE, YOU, WHAT?, HOLD, LIKE, DONE";
        }

        private void btnStage_Click(object sender, EventArgs e)
        {
            new WhosOnFirstForm().Show();
            this.Dispose();
        }
    }
}
