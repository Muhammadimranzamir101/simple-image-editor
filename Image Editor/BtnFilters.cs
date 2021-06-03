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
    class BtnFilters
    {

            public void BtnRed(PictureBox Pb, Button B)
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
                B.BackgroundImage = bmp;
            }

            public void BtnGreen(PictureBox Pb, Button B)
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
                B.BackgroundImage = bmp;
            }

            public void BtnBlue(PictureBox Pb, Button B)
            {

                Image img = Pb.Image;
                Bitmap bmp = new Bitmap(img.Width, img.Height);

                ImageAttributes ia1 = new ImageAttributes();
                ColorMatrix cm1 = new ColorMatrix(new float[][]

                {
                      new float [] {0, 0, 0, 0, 0},
                      new float [] {0, 0, 0, 0, 0},
                      new float [] {0, 0,  1, 0, 0},
                      new float [] {0, 0, 0, 1, 0},
                      new float [] {0, 0, 0, 0, 0}
                });

                ia1.SetColorMatrix(cm1);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia1);
                g.Dispose();
                B.BackgroundImage = bmp;
            }

        }

    }

