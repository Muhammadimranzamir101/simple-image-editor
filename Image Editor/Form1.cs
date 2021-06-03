using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing.Imaging;
using System.IO;

namespace Image_Editor
{
    public partial class Form1 : Form
    {
        static int Count = 1;
        static int Count1 = 1;

        public Form1()
        {
            InitializeComponent();
        }


        void Reload()
        {
            pictureBox1.Image = (Bitmap)Image.FromFile(Utility.files[Utility.Picindex]);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            panel8.BackColor = Color.FromArgb(0, 151, 203);

            panel8.Width = 750;
            panel8.Height = 548;

            pictureBox1.Width = 745;
            pictureBox1.Height = 544;

            panel2.Show();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            panel4.BringToFront();

            button1.BringToFront();
            button4.BringToFront();
            button5.BringToFront();
            button11.BringToFront();
            button12.BringToFront();
            button8.BringToFront();
            button9.BringToFront();



            Count = 1;
            Count1 = 1;
        }

        void Reload1()
        {
            pictureBox1.Image = (Bitmap)Image.FromFile(Utility.files[Utility.Picindex]);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Utility U = new Utility();
            U.Open(pictureBox1);

            if (Utility.opened == true)
                button6.Enabled = true;
            button10.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility U = new Utility();
            U.Save(pictureBox1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            panel8.AutoScroll = false;
            panel8.Width = 1010;
            panel8.Height = 548;
            pictureBox1.Width = 1005;
            pictureBox1.Height = 544;

            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button18.Enabled = false;
            button17.Enabled = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = (Bitmap)Image.FromFile(Utility.files[Utility.Picindex]);

            panel8.AutoScroll = true;
            panel8.Width = 1010;
            panel8.Height = 548;
            pictureBox1.Width = 1005;
            pictureBox1.Height = 544;

            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            button14.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            panel8.BackColor = Color.FromArgb(25, 38, 56);

            Count++;

            Utility u = new Utility();
            u.zoomin(pictureBox1, new Size(Count, Count));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            panel8.AutoScroll = true;
            panel8.Width = 1010;
            panel8.Height = 548;
            pictureBox1.Width = 1005;
            pictureBox1.Height = 544;

            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();

            button13.BringToFront();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            panel8.BackColor = Color.FromArgb(25, 38, 56);

            Count1++;
            Utility u = new Utility();
            u.zoomOut(pictureBox1, new Size(Count1, Count1));

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
            button2.BringToFront();

            panel5.SendToBack();
            panel6.SendToBack();
            panel4.BringToFront();
            panel4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reload();
            panel5.SendToBack();
            panel6.SendToBack();
            panel4.BringToFront();
            panel4.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            button17.BringToFront();
            metroTrackBar1.Value = 0;
            metroTrackBar2.Value = 100;
            metroTrackBar4.Value = 0;
            Reload();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button3.BringToFront();
            metroTrackBar1.Value = 0;
            metroTrackBar2.Value = 100;
            metroTrackBar4.Value = 0;
            Reload();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Reload();

            panel6.SendToBack();
            panel5.BringToFront();

            BtnFilters B1 = new BtnFilters();
            B1.BtnRed(pictureBox1, button23);

            BtnFilters B2 = new BtnFilters();
            B2.BtnGreen(pictureBox1, button24);

            BtnFilters B3 = new BtnFilters();
            B3.BtnBlue(pictureBox1, button25);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reload();

            panel6.SendToBack();
            panel5.BringToFront();
            button18.BringToFront();

            BtnFilters B1 = new BtnFilters();
            B1.BtnRed(pictureBox1, button23);

            BtnFilters B2 = new BtnFilters();
            B2.BtnGreen(pictureBox1, button24);

            BtnFilters B3 = new BtnFilters();
            B3.BtnBlue(pictureBox1, button25);

        }


        private void button8_Click(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(25, 38, 56);

            button21.BringToFront();
            Utility u = new Utility();
            u.rotate(pictureBox1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Utility u = new Utility();
            u.rotate(pictureBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(25, 38, 56);

            button22.BringToFront();
            Utility u = new Utility();
            u.mirror(pictureBox1);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Utility u = new Utility();
            u.mirror(pictureBox1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
                pictureBox1.Dispose();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Reload1();
            Filters Filter = new Filters();
            Filter.Red(pictureBox1);

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Reload1();
            Filters Filter = new Filters();
            Filter.Green(pictureBox1);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Reload1();
            Filters Filter = new Filters();
            Filter.Blue(pictureBox1);
        }

        private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            Reload();
            if (metroTrackBar2.Value != 100)
            {
                metroTrackBar2.Value = 100;
            }
            if (metroTrackBar4.Value != 0)
            {
                metroTrackBar4.Value = 0;
            }
            pictureBox1.Image = (Bitmap)Image.FromFile(Utility.files[Utility.Picindex]);
            Utility u = new Utility();
            u.brightness(metroTrackBar1, label5, pictureBox1);
            
        }

        private void metroTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            Reload();
            if (metroTrackBar1.Value != 0)
            {
                metroTrackBar1.Value = 0;           
            }
            if (metroTrackBar4.Value != 0)
            {
                metroTrackBar4.Value = 0;
            }
            pictureBox1.Image = (Bitmap)Image.FromFile(Utility.files[Utility.Picindex]);
            Utility u = new Utility();
            u.contrast(metroTrackBar2, label6, pictureBox1);
        }

        private void metroTrackBar4_ValueChanged(object sender, EventArgs e)
        {
            Reload();
            if (metroTrackBar1.Value != 0)
            {
                metroTrackBar1.Value = 0;
            }
            if (metroTrackBar2.Value != 100)
            {
                metroTrackBar2.Value = 100;
            }
            pictureBox1.Image = (Bitmap)Image.FromFile(Utility.files[Utility.Picindex]);
            Utility u = new Utility();
            u.saturation(metroTrackBar4, label8, pictureBox1);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();

            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;


            button8.Enabled = false;
            button9.Enabled = false;

            button11.Enabled = false;
            button12.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reload();
            button7.BringToFront();
            panel6.BringToFront();

            BtnEffects B1 = new BtnEffects();
            B1.GrayScale(pictureBox1, button28);

            BtnEffects B2 = new BtnEffects();
            B2.BlacknWhite(pictureBox1, button33);

            BtnEffects B3 = new BtnEffects();
            B3.Invert(pictureBox1, button34);

            BtnEffects B4 = new BtnEffects();
            B4.BGR(pictureBox1, button35);

            BtnEffects B5 = new BtnEffects();
            B5.Sepia(pictureBox1, button29);

            BtnEffects B6 = new BtnEffects();
            B6.Polaroid(pictureBox1, button30);

            BtnEffects B7 = new BtnEffects();
            B7.Dusty(pictureBox1, button31);

            BtnEffects B8 = new BtnEffects();
            B8.Bonnard(pictureBox1, button32);

        }



        private void button28_Click(object sender, EventArgs e)
        {
            Reload();
            Effects E = new Effects();
            E.GrayScale(pictureBox1);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Reload();
            Effects E = new Effects();
            E.BlacknWhite(pictureBox1);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Reload();
            Effects E = new Effects();
            E.Invert(pictureBox1);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Reload();
            Effects E = new Effects();
            E.BGR(pictureBox1);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Reload();
            Effects E = new Effects();
            E.Sepia(pictureBox1);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Reload();
            Effects E = new Effects();
            E.Polaroid(pictureBox1);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Reload();
            Effects E = new Effects();
            E.Dusty(pictureBox1);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Reload();
            Effects E = new Effects();
            E.Bonnard(pictureBox1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel8.Width = 750;
            panel8.Height = 548;
            panel8.AutoScroll = true;

            pictureBox1.Width = 745;
            pictureBox1.Height = 544;

            panel2.Show();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            panel4.BringToFront();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;


            button8.Enabled = true;
            button9.Enabled = true;

            button11.Enabled = true;
            button12.Enabled = true;

            button13.Enabled = true;
            button14.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;

            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;

            button6.BringToFront();
        }


        private void button6_Click(object sender, EventArgs e)
        {
          
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            panel8.AutoScroll = false;
            panel8.Width = 1010;
            panel8.Height = 548;
            pictureBox1.Width = 1005;
            pictureBox1.Height = 544;

            panel2.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();

            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
         

            button10.BringToFront();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button20.BringToFront();
            Utility u = new Utility();
            u.nextBtnClck(pictureBox1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button19.BringToFront();
            Utility u = new Utility();
            u.prevBtnClck(pictureBox1);
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Utility u = new Utility();
            u.prevBtnClck(pictureBox1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Utility u = new Utility();
            u.nextBtnClck(pictureBox1);
        }

    }
}
