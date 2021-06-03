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
    class BtnEffects
    {

        public void GrayScale(PictureBox Pb, Button B)
        {

            Image img = Pb.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                                            new float[] {0.33f, 0.33f, 0.33f, 0, 0},
                                            new float[] {0.59f, 0.59f, 0.59f, 0, 0},
                                            new float[] {0.11f, 0.116f, 0.11f, 0, 0},
                                            new float[] {0, 0, 0, 1, 0},
                                            new float[] {0, 0, 0, 0, 1}
                });

            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            B.BackgroundImage = bmp;
        }


        public void BlacknWhite(PictureBox Pb, Button B)
        {

            Image img = Pb.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                                            new float[] {1.5f, 1.5f, 1.5f, 0, 0},
                                            new float[] {1.5f, 1.5f, 1.5f, 0, 0},
                                            new float[] {1.5f, 1.5f, 1.5f, 0, 0},
                                            new float[] {0, 0, 0, 1, 0},
                                            new float[] {-1, -1, -1, 0, 1}
                });

            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            B.BackgroundImage = bmp;
        }

        public void Invert(PictureBox Pb, Button B)
        {

            Image img = Pb.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                                            new float[] {-1, 0, 0, 1, 0},
                                            new float[] {0, -1, 0, 0, 0},
                                            new float[] {0, 0, -1, 0, 0},
                                            new float[] {0, 0, 0, 1, 0},
                                            new float[] {1, 1, 1, 0, 1}
                });

            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            B.BackgroundImage = bmp;
        }

        public void BGR(PictureBox Pb, Button B)
        {
            Image img = Pb.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                                            new float[] {0, 0, 1, 0, 0},
                                            new float[] {0, 1, 0, 0, 0},
                                            new float[] {1, 0, 0, 0, 0},
                                            new float[] {0, 0, 0, 1, 0},
                                            new float[] {0, 0, 0, 0, 1}
                });

            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            B.BackgroundImage = bmp;
        }

        public void Sepia(PictureBox Pb, Button B)
        {

            Image img = Pb.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                                            new float[] {.393f, .349f, .272f, 0, 0},
                                            new float[] {.769f, .686f, .534f, 0, 0},
                                            new float[] {.189f, .168f, .131f, 0, 0},
                                            new float[] {0, 0, 0, 1, 0},
                                            new float[] {0, 0, 0, 0, 1}
                });

            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            B.BackgroundImage = bmp;
        }

        public void Polaroid(PictureBox Pb, Button B)
        {

            Image img = Pb.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                                            new float[] {1.438f, -0.062f, -0.062f, 0, 0},
                                            new float[] {-0.122f, 1.378f, 0.122f, 0, 0},
                                            new float[] {-0.016f, -0.016f, 1.483f, 0, 0},
                                            new float[] {0, 0, 0, 1, 0},
                                            new float[] {-0.03f, 0.05f, -0.02f, 0, 1}
                });

            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            B.BackgroundImage = bmp;
        }

        public void Dusty(PictureBox Pb, Button B)
        {
            Image img = Pb.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                                            new float[] {0.25f, 0.25f, 0.25f, 0, 0},
                                            new float[] {0.5f, 0.5f, 0.5f, 0, 0},
                                            new float[] {0.125f, 0.125f, 0.125f, 0, 0},
                                            new float[] {0, 0, 0, 1, 0},
                                            new float[] {0.2f, 0.2f, 0.2f, 0, 1}
                });

            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            B.BackgroundImage = bmp;
        }

        public void Bonnard(PictureBox Pb, Button B)
        {

            Image img = Pb.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                                            new float[] {1.5f, 0, 0, -0.1f, 0},
                                            new float[] {0, 1.5f, 0, 0, 0},
                                            new float[] {0, -0.5f, 1.5f, 0, 0},
                                            new float[] {0, 0, 0, 1, 0},
                                            new float[] {-0.1f, -0.05f, -0.1f, 0, 1}
                });

            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            B.BackgroundImage = bmp;
        }
    }
}
