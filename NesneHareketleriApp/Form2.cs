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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Player health variable
        private float playerHealth = 100;

        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialize player health label
            label1.Text = "Health: " + playerHealth;

            this.KeyPreview = true; // Ensure the form receives key events
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);

            timer1.Start();

          

        }

        private void CheckCollision()
        {
            // Check if pictureBox2 intersects with panel1
            if (pictureBox2.Bounds.IntersectsWith(panel1.Bounds))
            {
                ReducePlayerHealth(10); // Reduce health by 10, adjust as needed
            }
            if (pictureBox2.Bounds.IntersectsWith(panel2.Bounds))
            {
                ReducePlayerHealth(10); // Reduce health by 10, adjust as needed
            }
            if (pictureBox2.Bounds.IntersectsWith(panel3.Bounds))
            {
                ReducePlayerHealth(10); // Reduce health by 10, adjust as needed
            }
        }

        private void ReducePlayerHealth(float amount)
        {
            if ((playerHealth - amount) >= 0)
            {
                playerHealth -= amount;
            }
            else if(playerHealth==0)
            {
              
                // Handle player death if needed
                MessageBox.Show("Player is dead");
            }
            label1.Text = "Health: " + playerHealth;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
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
            // Check for collision with the panel after moving
            CheckCollision();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Left += 5;
            panel2.Left += 5;
            panel3.Left += 5;

            if (panel1.Left >= 556 && panel2.Left>=526 && panel3.Left >=506)
            {
               timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Left -= 5;
            panel2.Left -= 5;
            panel3.Left -= 5;

            if (panel1.Left <= 162 && panel2.Left<=175 && panel3.Left<=180)
            {
                timer2.Stop();
                timer1.Start();
            }
        }
    }
}
