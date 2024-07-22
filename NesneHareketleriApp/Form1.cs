using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneHareketleriApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
             private float playerHealth = 100;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            /*

            this.KeyPreview = true; // Ensure the form receives key events
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);


            // Check for collision with the panel after moving
            CheckCollision();*/
        }

        /*
        private void CheckCollision()
        {
            if (pictureBox2.Location == panel5.Location)
            {
                ReducePlayerHealth(10);
            }
            if (pictureBox2.Location == panel1.Location)
            {
                ReducePlayerHealth(10);
            }
            if (pictureBox2.Location == panel2.Location)
            {
                ReducePlayerHealth(10);
            }
            if (pictureBox2.Location == panel3.Location)
            {
                ReducePlayerHealth(10);
            }
            if (pictureBox2.Location == panel4.Location)
            {
                ReducePlayerHealth(10);
            }
        }
        private void ReducePlayerHealth(float amount)
        {
            if ((playerHealth - amount) >= 0)
            {
                playerHealth -= amount;
            }
            else
            {
                playerHealth = 0;
                // Handle player death if needed
                MessageBox.Show("Player is dead");
            }
                label1.Text= playerHealth.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int step = 5; // The step size for moving the pictureBox

            switch (e.KeyCode)
            {
                case Keys.Up:
                    pictureBox2.Top -= step;
                    break;
                case Keys.Down:
                    pictureBox2.Top += step;
                    break;
                case Keys.Left:
                    pictureBox2.Left -= step;
                    break;
                case Keys.Right:
                    pictureBox2.Left += step;
                    break;
            }
        }
        */

  




        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top-= 5;
            if (pictureBox1.Top <= 8)
            {
                timer1.Stop(); 
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;

            if (pictureBox1.Left >= 772)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if(pictureBox1.Top >= 369)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 141)
            {
                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 89)
            {
                timer5.Stop();
             timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;

            if (pictureBox1.Left >= 678)
            {
                
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 269)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            //146
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 146)
            {
                timer8.Stop();
                timer9.Start();
              
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 181)
            {
              timer9.Stop();
                timer10.Start();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            
           
                pictureBox1.Left += 5;

                if (pictureBox1.Left >= 584)
                {

                   timer10.Stop();
                MessageBox.Show("Kazandın ");
                }
            
        }


    }
}
