using Guna.UI2.WinForms;
using ImageProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
internal class Program
{
    private static void Main(string[] args)
    {

        Process notepad = new Process();
        notepad.StartInfo.FileName = "Adobe Xd x64.exe";
        notepad.StartInfo.Arguments = "DemoText";
        notepad.Start();
        Console.ReadLine();
    }
}
}

namespace m1vdesign
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button4.Visible = true;
            pictureBox8.Visible = true;
            pictureBox7.Visible = true;
            guna2Button1.Visible = false;
            pictureBox3.Visible = false;
            guna2CirclePictureBox1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox8.Visible = false;
            guna2ProgressBar1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value += 1;
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Stop();
                
            }
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
           
            guna2ProgressBar1.Visible = false;
            pictureBox8.Visible = false;
            guna2Button1.Visible = false;
            pictureBox3.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Visible = false;
            guna2ProgressBar1.Visible = false;
            pictureBox8.Visible = false;
            guna2Button1.Visible = true;
            pictureBox3.Visible = true;
            pictureBox7.Visible = false;
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Visible = false;
            pictureBox7.Visible = false;
            guna2Button4.Visible = false;
            pictureBox8.Visible = false;
            timer1.Start();
            pictureBox8.Visible = false;
            guna2ProgressBar1.Visible = true;
            pictureBox6.Visible = true;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
