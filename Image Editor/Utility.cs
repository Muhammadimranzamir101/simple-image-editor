using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Drawing.Imaging;
using System.IO;

namespace Image_Editor
{
    class Utility
    {

        public static OpenFileDialog ofd = new OpenFileDialog();
        public static bool opened = false;
        Bitmap img;

        public static int Picindex;
        public static String filePath;
        public static String [] files;
        public static int a;
        
        float b; // brightness
        float c; // contrast

        public void Open(PictureBox pb)
        {
            ofd.Title = "Image Editor - Open";
            ofd.Filter = "Jpg(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp|Png(*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                opened = true;

                 a = ofd.FileName.LastIndexOf('\\');
                
                filePath = ofd.FileName.Substring(0, a);
                files = Directory.GetFiles(filePath);
                Picindex = Array.IndexOf(files, ofd.FileName);
                pb.Image = Image.FromFile(ofd.FileName);
               
            } 
        }

        public void nextBtnClck(PictureBox pb)
        {
            Picindex++;
            if (Picindex == files.Length)
                Picindex = 0;

            pb.Image = Image.FromFile(files[Picindex]);
        }

        public void prevBtnClck(PictureBox pb)
        {
            Picindex--;
            if (Picindex < 0)

                Picindex = files.Length - 1;
            pb.Image = Image.FromFile(files[Picindex]);
        }

        public void zoomin(PictureBox pb, Size s)
        {
            img = (Bitmap) Image.FromFile(files[Picindex]);
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * s.Width / 50), img.Height + (img.Height * s.Height / 50));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pb.Image = bmp;

        }

        public void zoomOut(PictureBox pb, Size s)
        {
            img = (Bitmap)Image.FromFile(files[Picindex]);
            Bitmap bmp = new Bitmap(img, img.Width - (img.Width * s.Width / 50), img.Height - (img.Height * s.Height / 50));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pb.Image = bmp;

        }

        public void Save(PictureBox pb)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Jpg(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp|Png(*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pb.Image.Save(sfd.FileName);
            }
        }



        public void brightness(MetroTrackBar m, Label l, PictureBox pb)
        {
            l.Text = m.Value.ToString();
            b = 0.003f * m.Value;

            img = (Bitmap)Image.FromFile(files[Picindex]);
            //img = (Bitmap)pb.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics g = Graphics.FromImage(bmp);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]

               {
                     new float [] {1, 0, 0, 0, 0},
                     new float [] {0, 1, 0, 0, 0},
                     new float [] {0, 0, 1, 0, 0},
                     new float [] {0, 0, 0, 1, 0},
                     new float [] {b, b, b, 0, 1}
               });

            ia.SetColorMatrix(cm);

            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            ia.Dispose();
            pb.Image = bmp;

        }

        public void contrast(MetroTrackBar m, Label l, PictureBox pb)
        {

            l.Text = (m.Value - 100).ToString();
            c = 0.01f * m.Value;

            float t = (1.0f - c) / 2.0f;

            img = (Bitmap)Image.FromFile(files[Picindex]);
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics g = Graphics.FromImage(bmp);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]

               {
                     new float [] {c, 0, 0, 0, 0},
                     new float [] {0, c, 0, 0, 0},
                     new float [] {0, 0, c, 0, 0},
                     new float [] {0, 0, 0, 1, 0},
                     new float [] {t, t, t, 0, 1}
               });

            ia.SetColorMatrix(cm);

            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            ia.Dispose();
            pb.Image = bmp;
        }

        public void saturation(MetroTrackBar m, Label l, PictureBox pb)
        {

            //float R = 0.3086f;
            //float G = 0.6094f;
            //float B = 0.0820f;

            float R = 0.2125f;
            float G = 0.7154f;
            float B = 0.0721f;

            float s = 0.03f * m.Value;

            float sr = (1 - s) * R;
            float sg = (1 - s) * G;
            float sb = (1 - s) * B;

            l.Text = m.Value.ToString();


            img = (Bitmap)Image.FromFile(files[Picindex]);
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics g = Graphics.FromImage(bmp);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]


               {
                     new float [] {sr+s, sr, sr, 0, 0},
                     new float [] {sg, sg+s, sg, 0, 0},
                     new float [] {sb, sb, sb+s, 0, 0},
                     new float []      {0, 0, 0, 1, 0},
                     new float []      {0, 0, 0, 0, 1}
               });

            ia.SetColorMatrix(cm);

            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            ia.Dispose();
            pb.Image = bmp;
        }


        public void rotate(PictureBox pb)
        {
            img = new Bitmap(pb.Image);
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pb.Image = img;
        }

        public void mirror(PictureBox pb)
        {
            img = new Bitmap(pb.Image);
            img.RotateFlip(RotateFlipType.Rotate180FlipY);
            pb.Image = img;
        }
    }
}
