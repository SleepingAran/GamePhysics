using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Physics_Assignment_Form
{
    public partial class Form1 : Form
    {
        const int widthPlanet = 20, heightPlanet = 20; //size of the planet is always constant
        double mStar, mPlanet, distance, velocity; //mass of Star, mass of Planet, distance between star and planet, velocity of planet
        int xPlanet, yPlanet; //planet x and y coordinate
        int xStar, yStar; //star x and y coordinate
        int xChange, yChange; //displacement value
        int widthStar, heightStar; //star size
        float Gravity, EscapeForce; //Gravity and Angular Velocity
        const int GravitionalConstant = 6; //Gravitational Constant, G
        double angle;
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public Form1()
        {
            
            InitializeComponent();

            starComboBox.Items.Add("Sun");
            starComboBox.Items.Add("KW Sigittarii");
            starComboBox.Items.Add("VV Cephei A");
            starComboBox.SelectedIndex = 0;

            gameTimer.Start(); //To make the mass change in real time
            
        }


        private void UpdateDisplay() // draw the panel
        {
            
            int width = canvas.Width; 
            int height = canvas.Height;
           

            Graphics g = canvas.CreateGraphics(); //Drawing
            g.Clear(Color.White); //Background color
            SolidBrush newBrush = new SolidBrush(Color.Red); //Red for Star
            SolidBrush planetBrush = new SolidBrush(Color.RoyalBlue); //Blue for planet
            SolidBrush fontBrush =new SolidBrush(Color.Black); //Black for font
            Font font = new Font("Arial", 10); //Font format
            //The sun
            xStar = width / 3;
            yStar = height / 3;
            g.FillEllipse(newBrush, xStar, yStar, widthStar, heightStar); //Draw the selected Star

            
            g.DrawString("The Gravitational Force is " + Gravity +" Newton", font, fontBrush, 20, 10); //Show the Gravitational force
            g.DrawString("The Centrifugal Force is " + EscapeForce + " Newton", font, fontBrush, 20, 22); //Show the Centrifugal Force
            if (Gravity - EscapeForce <= 20 && Gravity - EscapeForce >= -20) //If in force equilibrium range
            {
                g.DrawString("They have reach force equilibrium", font, fontBrush, 20, 34); //Tell the player what happened
                //Circular motion
                if (angle==2)
                {
                    angle = 0;
                }
                xPlanet = (int)(xStar + (100 + distance*10) * Math.Cos(angle*Math.PI));
                yPlanet = (int)(yStar + (100 + distance*10) * Math.Sin(angle*Math.PI));
                g.FillEllipse(planetBrush, xPlanet, yPlanet, widthPlanet, heightPlanet);
                angle += 0.01;
                
            }
            else if (Gravity - EscapeForce > 20) //If gravity is larger
            {
                g.DrawString("The Gravitational Force is stronger than the Centrifugal Force", font, fontBrush, 20, 34); //Tell the player what happened
                //Circular motion
                if (angle == 2)
                {
                    angle = 0;
                }
                xPlanet = (int)(xStar + (100 + distance * 10 + xChange) * Math.Cos(angle * Math.PI));
                yPlanet = (int)(yStar + (100 + distance * 10 + yChange) * Math.Sin(angle * Math.PI));
                g.FillEllipse(planetBrush, xPlanet, yPlanet, widthPlanet, heightPlanet); // The planet
                angle += 0.01;

            }//
            else if (Gravity - EscapeForce < -20) //If angular velocity is larger
            {
                g.DrawString("The Centrifugal Force is stronger than the Gravitational Force", font, fontBrush, 20, 34); //Tell the player what happened
                //Circular motion
                if (angle==2)
                {
                    angle = 0;
                }
                xPlanet = (int)(xStar + (100 + distance * 10 + xChange) * Math.Cos(angle * Math.PI));
                yPlanet = (int)(yStar + (100 + distance * 10 + yChange) * Math.Sin(angle * Math.PI));
                g.FillEllipse(planetBrush, xPlanet, yPlanet, widthPlanet, heightPlanet); // The planet
                angle += 0.01;
            }
            
            g.Dispose();

        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            
            mStar = Convert.ToDouble(mass_Sun.Text); //Store the mass of Star
            mPlanet = Convert.ToDouble(mass_Planet.Text); //Store the mass of planet
            distance = Convert.ToDouble(distanceTextbox.Text); //Store the mass of distance
            velocity = Convert.ToDouble(planetVelocity.Text); //Store the velocity
            angle = Convert.ToDouble(radianTextBox.Text);
            Gravity = GravitationalForce(GravitionalConstant, mStar, mPlanet, distance); //Pass in information to calculate the gravitational force
            EscapeForce = CentrifugalForce(velocity, distance); //Pass in the information to calculate the angular velocity
            secondGameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e) //Allocate the mass of Star in real-time
        {
            
            if (String.Equals(starComboBox.Text, "Sun"))
            {
                mass_Sun.Text = "100";
                widthStar = 30;
                heightStar = 30;

            }
            else if (String.Equals(starComboBox.Text,"KW Sigittarii"))
            {
                mass_Sun.Text = "200";
                widthStar = 60;
                heightStar = 60;

            }
            else if (String.Equals(starComboBox.Text, "VV Cephei A"))
            {
                mass_Sun.Text = "50";
                widthStar = 15;
                heightStar = 15;
            }
           
            
        }

        private float GravitationalForce(double G, double mStar, double mPlanet, double distance)
        {
            float Force;
            Force = (float)((G * mStar * mPlanet) / Math.Pow((double)(distance), 2)); //Gravitational Force Equation F = G*m1*m2/r
            return Force;
        }

        private float CentrifugalForce(double velocity, double distance)
        {
            float Force;
            Force = (float)(mPlanet * Math.Pow((double)(velocity), 2) / distance); //Centrifugal Force Equation F = m*v^2/r
            return Force;
        }

        private void secondGameTimer_Tick(object sender, EventArgs e)
        {
            // comparison
            if (Gravity - EscapeForce <= 20 && Gravity - EscapeForce >= -20) // within the answer
            {
                // rotate around
                UpdateDisplay();

            }

             if (Gravity - EscapeForce > 20) //The ball will get closer to the sun
             {
                 if (xPlanet == xStar)
                     xChange++;
                 else
                    xChange--;
                 if (yPlanet == yStar)
                     yChange++;
                 else
                    yChange--;
                UpdateDisplay();
            }
            else if (Gravity - EscapeForce < -20) //The ball will fly away
            {
                
                xChange++;
                yChange++; 
                UpdateDisplay();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            secondGameTimer.Stop(); //Stop the game
            //Reset everything
            xChange = 0;
            yChange = 0;

        }
    }
}
