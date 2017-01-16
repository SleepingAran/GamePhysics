using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Physics_Lab_2
{
    public partial class Form1 : Form
    {
        float x1, x2, y1, y2;
        float width, height;
        float x_coordinate, y_coordinate;
        double box_Velocity;
        double boxLocation;
        float boxWidth;
        double initialAltitude;
        double ballAltitude;
        double ballLocation;
        double time;
        double dropTime;
        bool dropped;
        double g;
        public Form1()
        {
            InitializeComponent();
            width = this.Width;
            height = this.Height;
            velocity.Text = "0";
            //  Set box, ball, and time parameters.
            boxLocation = 0.0;
            boxWidth = 40;
            initialAltitude = 120.0;
            ballAltitude = initialAltitude;
            ballLocation = 210.0;
            time = 0.0;
            dropTime = 0.0;
            dropped = false;
            UpdateDisplay();
         
        }
    
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            /*
            
            Graphics g = canvas.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.Black);
            x_coordinate = 20;
            y_coordinate=70;
            g.DrawLine(blackPen, 0, 150, width, 150);
            g.DrawRectangle(blackPen, x_coordinate, y_coordinate, 50, 100);
            g.FillRectangle(brush, (int)x_coordinate, y_coordinate, 50, 100);
            g.FillEllipse(brush, 300, 20, 20,20);
             
             
             */
            
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            
            
            box_Velocity = Convert.ToDouble(velocity.Text);
            string selectedItem = (string)planet_combobox.SelectedItem;
            if (String.Equals(selectedItem, "Earth"))
                g = 9.81;
            else if (String.Equals(selectedItem, "Moon"))
                g = 1.624;
            else if (String.Equals(selectedItem, "Jupiter"))
                g = 24.8;

            gameTimer.Start();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void drop_button_Click(object sender, EventArgs e)
        {
            dropped = true;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            boxLocation = 0.0;
            boxWidth = 40;
            initialAltitude = 120.0;
            ballAltitude = initialAltitude;
            ballLocation = 210.0;
            time = 0.0;
            dropTime = 0.0;
            dropped = false;

            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            Graphics g = canvas.CreateGraphics();
            int width = canvas.Width - 1;
            int height = canvas.Height - 1;

            //  Clear the current display.
            g.Clear(canvas.BackColor);

            Pen blackPen = new Pen(Color.Black, 2);
            g.DrawLine(blackPen, 0, 130, width, 130);

            //  Update the position of the box and
            //  ball on the screen.
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, (int)boxLocation, 120, boxWidth, 10);

            int zPosition = (int)(initialAltitude - ballAltitude);
            g.FillEllipse(brush, (int)ballLocation, zPosition, 10, 10);

            //  Clean up the Graphics object.
            g.Dispose();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            double timeIncrement = 0.05;
            time += timeIncrement;
            boxLocation = box_Velocity * time;

            if (dropped)
            {
                dropTime += timeIncrement;
                ballAltitude =
                     initialAltitude - 0.5 * g * dropTime * dropTime;
            }

            //  Update the display
            UpdateDisplay();

            //  If the ball hits the ground, stop the simulation
            //  and determine if it landed in the box.
            if (ballAltitude <= 0.0)
            {
                gameTimer.Stop();

                if (ballLocation >= boxLocation &&
                     ballLocation <= boxLocation + boxWidth - 10)
                {
                    result.Text = "You Win!";
                }
                else
                {
                    result.Text = "Try again";
                }
            }

        }

  

    }
}
