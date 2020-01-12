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
    public partial class MazeForm : Form
    {
        public MazeForm()
        {
            InitializeComponent();
            MazeModule.GoalSet = false;
            MazeModule.PlayerSet = false;
            btnUp.Visible = false;
            btnDown.Visible = false;
            btnLeft.Visible = false;
            btnRight.Visible = false;
        }

        private void btnMaze1_Click(object sender, EventArgs e)
        {
            MazeBox.BackgroundImage = Properties.Resources.Maze1;
            MazeBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnMaze2_Click(object sender, EventArgs e)
        {
            MazeBox.BackgroundImage = Properties.Resources.Maze2;
            MazeBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnMaze3_Click(object sender, EventArgs e)
        {
            MazeBox.BackgroundImage = Properties.Resources.Maze3;
            MazeBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnMaze4_Click(object sender, EventArgs e)
        {
            MazeBox.BackgroundImage = Properties.Resources.Maze4;
            MazeBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnMaze5_Click(object sender, EventArgs e)
        {
            MazeBox.BackgroundImage = Properties.Resources.Maze5;
            MazeBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnMaze6_Click(object sender, EventArgs e)
        {
            MazeBox.BackgroundImage = Properties.Resources.Maze6;
            MazeBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnMaze7_Click(object sender, EventArgs e)
        {
            MazeBox.BackgroundImage = Properties.Resources.Maze7;
            MazeBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnMaze8_Click(object sender, EventArgs e)
        {
            MazeBox.BackgroundImage = Properties.Resources.Maze8;
            MazeBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnMaze9_Click(object sender, EventArgs e)
        {
            MazeBox.BackgroundImage = Properties.Resources.Maze9;
            MazeBox.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void MazeBox_Click(object sender, MouseEventArgs e)
        {
            if (!MazeModule.GoalSet)
            {
                MazeModule.GoalX = e.X;
                MazeModule.GoalY = e.Y;
                DrawGoal();
                MazeModule.GoalSet = true;

                return;
            }
            if (!MazeModule.PlayerSet)
            {
                MazeModule.PlayerX = e.X;
                MazeModule.PlayerY = e.Y;
                MazeModule.PlayerSet = true;
                btnLeft.Visible = true;
                btnRight.Visible = true;
                btnUp.Visible = true;
                btnDown.Visible = true;
                DrawPlayer();
                return;
            }
        }

        private void DrawGoal()
        {
            MazeBox.Refresh();
            Graphics g = MazeBox.CreateGraphics();
            g.DrawRectangle(new Pen(Brushes.Red, 5),
            new Rectangle(new Point(MazeModule.GoalX - 25, MazeModule.GoalY - 25), new
                Size(50, 50)));
            return;
        }

        private void DrawPlayer()
        {
            MazeBox.Refresh();
            DrawGoal();
            Graphics g = MazeBox.CreateGraphics();
            g.FillRectangle(Brushes.Black,
            new Rectangle(new Point(MazeModule.PlayerX - 15, MazeModule.PlayerY - 15), new
                Size(30, 30)));
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            OutputBox.Text += "Up, ";
            MazeModule.PlayerY -= MazeBox.Height / 6;
            DrawPlayer();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            OutputBox.Text += "Right, ";
            MazeModule.PlayerX += MazeBox.Height / 6;
            DrawPlayer();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            OutputBox.Text += "Down, ";
            MazeModule.PlayerY += MazeBox.Height / 6;
            DrawPlayer();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            OutputBox.Text += "Left, ";
            MazeModule.PlayerX -= MazeBox.Height / 6;
            DrawPlayer();
        }
    }

    public static class MazeModule
    {
        public static bool GoalSet = false;
        public static bool PlayerSet = false;
        public static int GoalX = 0;
        public static int GoalY = 0;
        public static int PlayerX = 0;
        public static int PlayerY = 0;
    }
}
