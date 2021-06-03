using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Image_Editor
{
    class Filters
    {

        public void Red (PictureBox Pb)
        {                         
                Image img = Pb.Image;
                Bitmap bmp = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]

                {
                      new float [] {1, 0, 0, 0, 0},
                      new float [] {0, 0, 0, 0, 0},
                      new float [] {0, 0, 0, 0, 0},
                      new float [] {0, 0, 0, 1, 0},
                      new float [] {0, 0, 0, 0, 0}
                });

                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                Pb.Image = bmp;
            }
       
            public void Green(PictureBox Pb)
            {

                Image img = Pb.Image;
                Bitmap bmp = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]

                {
                      new float [] {0, 0, 0, 0, 0},
                      new float [] {0, 1, 0, 0, 0},
                      new float [] {0, 0, 0, 0, 0},
                      new float [] {0, 0, 0, 1, 0},
                      new float [] {0, 0, 0, 0, 0}
                });

                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                Pb.Image = bmp;
            }

      
        //    public void Green(PictureBox Pb)
        //    {
        //        Bitmap temp = (Bitmap)Pb.Image;
        //        Bitmap bmp = (Bitmap)temp.Clone();

        //        for (int i = 0; i < bmp.Width; i++)
        //        {
        //            for (int j = 0; j < bmp.Height; j++)
        //            {
        //                Color c = bmp.GetPixel(i, j);
        //                int pixelR = 0;
        //                int pixelG = 0;
        //                int pixelB = 0;


        //                pixelR = c.R - 255;
        //                pixelG = c.G;
        //                pixelB = c.B - 255;

        //                pixelR = Math.Max(pixelR, 0);
        //                pixelR = Math.Min(255, pixelR);

        //                pixelG = Math.Max(pixelG, 0);
        //                pixelG = Math.Min(255, pixelG);

        //                pixelB = Math.Max(pixelB, 0);
        //                pixelB = Math.Min(255, pixelB);

        //                bmp.SetPixel(i, j, Color.FromArgb((byte)pixelR, (byte)pixelG, (byte)pixelB));
        //            }
        //            Pb.Image = (Bitmap)bmp.Clone();
        //        }
        //    }
        //}

            public void Blue(PictureBox pb)
            {
                Image img = pb.Image;
                Bitmap bmp = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]

                {
                      new float [] {0, 0, 0, 0, 0},
                      new float [] {0, 0, 0, 0, 0},
                      new float [] {0, 0, 1, 0, 0},
                      new float [] {0, 0, 0, 1, 0},
                      new float [] {0, 0, 0, 0, 0}
                });

                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pb.Image = bmp;
            }
    }

}

       
           

