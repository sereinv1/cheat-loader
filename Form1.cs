using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Microsoft.Win32;
using System.IO;
using ImageProcessor;
using System.DirectoryServices.AccountManagement;
using System.Reflection.PortableExecutable;
using Guna.UI2.WinForms;

namespace m1vdesign
{
    public partial class Form1 : Form
    {

            


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );




        public Form1()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcWidth = 20;
            int arcHeight = 20;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(rect.X, rect.Y, arcWidth, arcHeight, 180, 90);
            path.AddArc(rect.X + rect.Width - arcWidth, rect.Y, arcWidth, arcHeight, 270, 90);
            path.AddArc(rect.X + rect.Width - arcWidth, rect.Y + rect.Height - arcHeight, arcWidth, arcHeight, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - arcHeight, arcWidth, arcHeight, 90, 90);
            this.Region = new System.Drawing.Region(path);

            guna2ProgressBar1.Value = 0;
            

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            guna2TextBox1.Visible = false;
            username.Visible = false;
            password.Visible = false;
            guna2ProgressBar1.Visible = true;
            guna2Button1.Visible = false;
            pictureBox3.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value += 1;
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Stop();
                Form2 login = new Form2();
                login.Show();
                this.Hide();
            }
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Button4.Visible = true;
            guna2Button3.Visible = false;
            guna2Button2.Visible = true;
            pictureBox2.Visible = true;
            guna2TextBox1.Visible = true;
            guna2Button1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            guna2Button2.Visible = false;
            guna2TextBox1.Visible = false;
            username.Visible = false;
            password.Visible = false;
            guna2ProgressBar2.Visible = true;
            guna2Button1.Visible = false;
            pictureBox4.Visible = true;
        }

        private void guna2ProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar2.Value += 1;
            if (guna2ProgressBar2.Value == 100)
            {
                timer2.Stop();
                Form2 ssss = new Form2();
                ssss.Show();
                this.Hide();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false ;
            guna2TextBox1.Visible = false;
            guna2Button2.Visible = false;
            guna2Button1.Visible =true;
        }

        private void guna2ProgressBar2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
