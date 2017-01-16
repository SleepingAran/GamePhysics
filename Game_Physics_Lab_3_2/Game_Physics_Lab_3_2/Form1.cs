using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Physics_Lab_3_2
{
    public partial class Form1 : Form
    {
        private double z;     //  altitude of beanbag
        private double z0;    //  initial altitude of beanbag
        private double vz0;   //  initial vertical velocity
        private double x;     //  horizontal location
        private double x0;    //  initial horizontal location
        private double vx0;   //  initial horizontal velocity
        private double time;
        //  This field is for the images used in the game.
        private Image playerIcon;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vxTextBox.Text = "0";
            vzTextBox.Text = "0";
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            //  Extract initial data from the textfields.
            vx0 = Convert.ToDouble(vxTextBox.Text);
            vz0 = Convert.ToDouble(vzTextBox.Text);

            //  Start the box sliding using a Timer object
            //  to slow down the action.
            gameTimer.Start();

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //  Event handling method for the "Reset" button
            //  stop the timer.
            gameTimer.Stop();

            //  Reset the box and ball location and time;
            z = 1.7;
            z0 = 1.7;
            vz0 = 0.0;
            x = 0.5;
            x0 = 0.5;
            vx0 = 0.0;
            time = 0.0;
            UpdateDisplay();
        }



        //  This method redraws the GUI display.
        private void UpdateDisplay()
        {
            Graphics g = drawingPanel.CreateGraphics();
            int width = drawingPanel.Width - 1;
            int height = drawingPanel.Height - 1;

            //  Clear the current display.
            g.Clear(drawingPanel.BackColor);

            //  Draw the beanbag tosser.
            int zLocation = 125 - 67;
            

            Pen blackPen = new Pen(Color.Black, 2);
            g.DrawLine(blackPen, 0, 125, width, 125);
            g.DrawLine(blackPen, 150, 125, 150, height);
            g.DrawLine(blackPen, 175, 125, 175, height);
            g.DrawLine(blackPen, 200, 125, 200, height);
            g.DrawLine(blackPen, 225, 125, 225, height);

            SolidBrush brush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 12);
            g.DrawString("10", font, brush, 152, 127);
            g.DrawString("20", font, brush, 177, 127);
            g.DrawString("50", font, brush, 202, 127);
            g.DrawString("0", font, brush, 227, 127);

            //  Update the position of the beanbag
            //  on the screen.
            int xPosition = (int)(100.0 * x);
            double deltaZ = z - 1.25;
            int zPosition = (int)(125 - 100.0 * deltaZ);
            g.FillEllipse(brush, xPosition, zPosition, 10, 10);

            //  Clean up the Graphics object.
            g.Dispose();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            double timeIncrement = 0.05;
            time += timeIncrement;

            //  There is no force in the x-direction, so the
            //  new x location is the initial x location plus
            //  the product of the horizontal velocity and time.
            x = x0 + vx0 * time;

            //  The z-location is influenced by the acceleration
            //  due to gravity.
            double g = -9.81;
            z = z0 + vz0 * time + 0.5 * g * time * time;

            //  Update the display
            UpdateDisplay();

            //  If the beanbag hits the ground, stop 
            //  the simulation.
            if (z <= 1.4)
            {
                gameTimer.Stop();

            }

        }
    }
}