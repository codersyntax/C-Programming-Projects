using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInterativeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayImage();
        }

        private void DisplayImage()
        {
            Bitmap image = new Bitmap("C:/Users/TDL.MCTECHDEV.009/Documents/Visual Studio 2015/Projects/EggsInterativeGUI/EggsInterativeGUI/chicken.gif");
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int firstChicken = Convert.ToInt32(textBox1.Text);
            int secondChicken = Convert.ToInt32(textBox2.Text);
            int thirdChicken = Convert.ToInt32(textBox3.Text);
            int fourthChicken = Convert.ToInt32(textBox4.Text);
            int fifthChicken = Convert.ToInt32(textBox6.Text);
            int total = firstChicken + secondChicken + thirdChicken + fourthChicken + fifthChicken;
            int dozen = total / 12;
            int remainder = total % 12;
            textBox5.Text = Convert.ToString(total) + " EGGS / " + dozen + " DOZEN WITH " + remainder + " LEFT OVER";
        }
    }
}
