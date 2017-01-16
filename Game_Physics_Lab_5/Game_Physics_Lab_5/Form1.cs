using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Physics_Lab_5
{
    public partial class Form1 : Form
    {
        private Image golferIcon;
        private Image flagIcon;

        //  The golf ball is a SimpleProjectile
        private SimpleProjectile golfball;

        //  The player can control the distance to the hole.
        private double distanceToHole;


        public Form1()
        {
            InitializeComponent();
            //  Create a SimpleProjectile object with default values so
            //  the display can be updated the first time.
            golfball = new SimpleProjectile(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);

            //  Set up images
            golferIcon = Image.FromFile("Golfer.jpg");
            flagIcon = Image.FromFile("Hole_Cartoon.jpg");

            //  Initialize the distanceToHole field.
            distanceToHole = 200.0;

            axesComboBox.Items.Add("XZ");
            axesComboBox.Items.Add("XY");
            axesComboBox.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vx0 = Convert.ToDouble(vxTextBox.Text);
            double vy0 = Convert.ToDouble(vyTextBox.Text);
            double vz0 = Convert.ToDouble(vzTextBox.Text);
            distanceToHole = Convert.ToDouble(distanceTextBox.Text);

            //  Create a SimpleProjectile object representing the golf ball.
            golfball = new SimpleProjectile(0.0, 0.0, 0.0, vx0, vy0, vz0, 0.0);

            //  Update the display
            UpdateDisplay();

            //  Fire the golf ball using a Timer object
            //  to slow down the action.
            gameTimer.Start();

        }





        private void button2_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();

            //  Reset the time, location, and velocity of ball;
            golfball.S = 0.0;       //  time
            golfball.SetQ(0.0, 0);   //  vx0
            golfball.SetQ(0.0, 1);   //  x0
            golfball.SetQ(0.0, 2);   //  vy0
            golfball.SetQ(0.0, 3);   //  y0
            golfball.SetQ(0.0, 4);   //  vz0
            golfball.SetQ(0.0, 5);   //  z0

            //  Reset the distance to hole.
            distanceToHole = Convert.ToDouble(distanceTextBox.Text);

            //  Update the display.
            UpdateDisplay();


        }
        private void UpdateDisplay()
        {
            Graphics g = drawingPanel.CreateGraphics();
            int width = drawingPanel.Width - 1;
            int height = drawingPanel.Height - 1;

            //  Clear the current display.
            //    g.Clear(drawingPanel.BackColor);
            g.Clear(Color.White);

            //  Update the position of the golfball on the screen.
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 1);

            //  Draw picture based on whether the XZ or 
            //  XY axes are selected.
            string axes = (string)axesComboBox.SelectedItem;
            if (String.Equals(axes, "XZ"))
            {

                //  Draw the golfer.
                int zLocation = height - 50;
                g.DrawImage(golferIcon, 0, zLocation, 34, 50);

                //  Draw the flag
                zLocation = height - 62;
                g.DrawImage(flagIcon, (int)(2.0 * distanceToHole),
                            zLocation, 55, 62);

                //  Update the position of the golfball
                //  on the screen.
                int xPosition = (int)(2.0 * golfball.GetX() + 14);
                int zPosition = (int)(height - 5 - 2.0 * golfball.GetZ());
                g.FillEllipse(brush, xPosition, zPosition, 5, 5);
            }
            else
            {
                //  Draw location of green.
                g.DrawEllipse(blackPen, (int)(2.0 * distanceToHole - 20), 80, 40, 40);
                g.FillEllipse(brush, (int)(2.0 * distanceToHole - 4), 96, 8, 8);

                //  Update the position of the golfball
                //  on the screen.
                int xPosition = (int)(2.0 * golfball.GetX());
                int yPosition = (int)(100 - 2 - 2.0 * golfball.GetY());
                g.FillEllipse(brush, xPosition, yPosition, 5, 5);
            }

            //  Clean up the Graphics object.
            g.Dispose();

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            double timeIncrement = 0.07;
            golfball.UpdateLocationAndVelocity(timeIncrement);

            //  Update the display
            UpdateDisplay();

            //  Access the Graphics object of the drawing panel.
            Graphics g = drawingPanel.CreateGraphics();

            //  When the golfball hits the ground, stop the simulation
            //  and see where ball has landed.
            if (golfball.GetZ() <= 0.0)
            {

                Console.WriteLine("time=" + (float)golfball.GetTime() +
                "  x=" + (float)golfball.GetX() +
                "  y=" + (float)golfball.GetY() + "  z=" + (float)golfball.GetZ());

                //  Stop the simulation
                gameTimer.Stop();

                //  Determine if ball is on the green.
                SolidBrush brush = new SolidBrush(Color.Black);
                Font font = new Font("Arial", 12);
                if (golfball.GetX() > distanceToHole - 10.0 &&
                     golfball.GetX() < distanceToHole + 10.0 &&
                     golfball.GetY() < 10.0)
                {
                    g.DrawString("You're on the green", font, brush, 100, 30);

                }
                else
                {
                    g.DrawString("You missed", font, brush, 100, 30);
                }
            }
        


        }

    }
}
