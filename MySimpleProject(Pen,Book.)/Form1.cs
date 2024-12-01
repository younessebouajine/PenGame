using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySimpleProject_Pen_Book._
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void radioButtonBoy_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonBoy.Checked) 
            {
                label1.Text = "Boy";
                try
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Administrateur\Desktop\Boy.png"); 
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"An error occurred while loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void radioButtonGirl_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ((RadioButton)sender).Tag.ToString();
             pictureBox1.Image = Image.FromFile(@"C:\Users\Administrateur\Desktop\Girl.png");
            
        }

        private void radioButtonPen_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Pen";
            pictureBox1.Image = Image.FromFile(@"C:\Users\Administrateur\Desktop\Pen.png");
        }

        private void radioButtonBook_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Book";
            pictureBox1.Image = Image.FromFile(@"C:\Users\Administrateur\Desktop\Book.png");
        }
    }
}
