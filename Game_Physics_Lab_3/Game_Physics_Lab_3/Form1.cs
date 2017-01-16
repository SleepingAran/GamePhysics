using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Physics_Lab_3
{
    public partial class shuffleboard : Form
    {
        private double mu , mass , initialVelocty , xLocation , time;
        private static double G = 9.81;
        public shuffleboard()
        {
            InitializeComponent();
        }

        private void shuffleboard_Load(object sender, EventArgs e)
        {
           
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Extract information from text box
            mu = Convert.ToDouble(muTextBox.Text);
            initialVelocty = Convert.ToDouble(velocityTextBox.Text);
            mass = Convert.ToDouble(massTextBox.Text);

            //set time and inital x location
            time = 0.0;
            xLocation = 0.0;

            //start the timer
            gameTimer.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //stop the timer
            gameTimer.Stop();
            
            //reset disk location
            xLocation = 0.0;

            //update the display
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Graphics g = drawingPanel.CreateGraphics();
            int width = drawingPanel.Width - 1;
            int height = drawingPanel.Height - 1;

            //clear current display

            g.Clear(drawingPanel.BackColor);

            Pen blackPen = new Pen(Color.Black, 2);
            g.DrawLine(blackPen, 0, 125, width, 125);
            g.DrawLine(blackPen, 200, 125, 200, height);
            g.DrawLine(blackPen, 225, 125, 225, height);
            g.DrawLine(blackPen, 250, 125, 250, height);
            g.DrawLine(blackPen, 275, 125, 275, height);

            SolidBrush brush = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 12);
            g.DrawString("10", font, brush, 202, 127);
            g.DrawString("20", font, brush, 227, 127);
            g.DrawString("50", font, brush, 252, 127);
            g.DrawString("0", font, brush, 227, 127);

            //Update the postition of the box
            int x = (int)(xLocation * 100);
            g.DrawEllipse(brush, x, 115, 10, 10);
            
            //Clean up the graphic object
            g.Dispose();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //update the time
            time += 0.05;
            //compute the currect velocity of the disk
            double velocity = initialVelocty - mu * G * time;
            //update the positio of the disk
            xLocation = initialVelocty * time - 0.5 * mu * G * time * time;
            //update the dispaly
            UpdateDisplay();

            //if the disk stop moving, or reaches the end, stop the timer
            if (velocity <= 0.0 || xLocation > 2.9)
                gameTimer.Stop();
        }

        
    }
}
