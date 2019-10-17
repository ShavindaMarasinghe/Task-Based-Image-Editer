using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB007297_TBSE_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image pic1;
        Image pic2;
        Boolean openpic1=false;
        Boolean openpic2 = false;


        //Add Image to picture box
        void openimage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pic1 = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = pic1;               openpic1 = true;
            }
        }

        void openimage2()
        {
            DialogResult dr = openFileDialog2.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pic2 = Image.FromFile(openFileDialog2.FileName);
                pictureBox2.Image = pic2;
                openpic2 = true;
            }
        }

        //Saving Image 
        void saveimage()
        {
            if(openpic1)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Images|*.png;*.jpg*;.bmp*";
                ImageFormat format = ImageFormat.Png;

                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string extension1 = Path.GetExtension(save.FileName);
                    switch (extension1) 
                    {

                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        

                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;

                    }

                    pictureBox1.Image.Save(save.FileName, format);
                }

            }
            else
            {
                MessageBox.Show("Please Insert Image");

            }
        }

        void saveimage2()
        {
            if (openpic2)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Images|*.png;*.jpg*;.bmp*";
                ImageFormat format = ImageFormat.Png;

                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string extension1 = Path.GetExtension(save.FileName);
                    switch (extension1)
                    {

                        case ".png":
                            format = ImageFormat.Png;
                            break;


                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;

                    }

                    pictureBox2.Image.Save(save.FileName, format);
                }

            }
            else
            {
                MessageBox.Show("Please Insert Image");

            }
        }
    

        //Remove Image
        void removeimage()
        {
            pictureBox1.Image = null;
        }

        void removeimage2()
        {
            pictureBox2.Image = null;
        }


        //Reset Image
        void resetimage1()
        {
            if (!openpic1)
            {
                MessageBox.Show("Edit Image First");
            }
            else
            {
                if (openpic1)
                {
                    pic1 = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = pic1;
                    openpic1 = true;
                }
            }
        }

        void resetimage2()
        {
            if (!openpic2)
            {
                MessageBox.Show("Edit Image First");
            }
            else
            {
                if (openpic2)
                {
                    pic2 = Image.FromFile(openFileDialog2.FileName);
                    pictureBox2.Image = pic2;
                    openpic2 = true;
                }
            }
        }


        //Editing Function Methods
        void grayscale(Bitmap grayscale_filter)
        {
            int width = grayscale_filter.Width;
            int height = grayscale_filter.Height;


            Color clr;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    clr = grayscale_filter.GetPixel(x, y);
                    int a = clr.A;
                    int r = clr.R;
                    int g = clr.G;
                    int b = clr.B;

                    int avg = (r + g + b) / 3;

                    grayscale_filter.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));

                }
            }
        }

        void darkmode(Bitmap darkmode_filter)
        {
            int width = darkmode_filter.Width;
            int height = darkmode_filter.Height;


            Color clr;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    clr = darkmode_filter.GetPixel(x, y);
                    int a = clr.A;
                    int r = clr.R;
                    int g = clr.G;
                    int b = clr.B;

                    int avg = (r + g + b) / 20;

                    darkmode_filter.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));

                }
            }
        }

        void sepia(Bitmap sepia_filter)
        {
            int width = sepia_filter.Width;
            int height = sepia_filter.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color clr = sepia_filter.GetPixel(x, y);

                    int a = clr.A;
                    int r = clr.B;
                    int g = clr.R;
                    int b = clr.B;

                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.271 * r + 0.534 * g + 0.131 * b);

                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }

                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    sepia_filter.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
        }


        void negative(Bitmap negative_filter)
        {
            int width = negative_filter.Width;
            int height = negative_filter.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color clr = negative_filter.GetPixel(x, y);

                    int a = clr.A;
                    int r = clr.B;
                    int g = clr.R;
                    int b = clr.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    negative_filter.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
        }

        void horizontalflip(Image horizontalflip_img)
        {

            horizontalflip_img.RotateFlip(RotateFlipType.RotateNoneFlipY);

        }


    
        void verticalflip(Image verticalflip_img)
        {

            verticalflip_img.RotateFlip(RotateFlipType.RotateNoneFlipX);

        }

        
        void rotateright(Image rotaterigh_img)
        {

            rotaterigh_img.RotateFlip(RotateFlipType.Rotate90FlipNone);

        }

        
        void rotateleft(Image rotatelef_img)
        {

            rotatelef_img.RotateFlip(RotateFlipType.Rotate270FlipNone);

        }

        void hue()
        {
            var objLock = new object();
            float changered,changegreen,changeblue;
          
            lock (objLock)
            {
                changered = redtrackbar.Value * 0.1f;
                changegreen = greentrackbar.Value * 0.1f;
                changeblue = bluetrackbar.Value * 0.1f;
            }
            redbarvalue.Text = changered.ToString();
            bluebarvalue.Text = changeblue.ToString();
            greenbarvalue.Text = changegreen.ToString();

           
            if (!openpic1)
            {
                MessageBox.Show("Insert Image First!");
                openimage();
            }
            else
            {



                Image img = pictureBox1.Image;
               // Image img1 = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                       

                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
                    new float[]{1+changered, 0, 0, 0, 0},
            new float[]{0, 1+changegreen, 0, 0, 0},
            new float[]{0, 0, 1+changeblue, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           
                Graphics g = Graphics.FromImage(bmpInverted);   
                                                            

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


               


                g.Dispose();                            
                pictureBox1.Image = bmpInverted;


            }
        }
        void hue2()
        {
            var objLock = new object();
            float changered, changegreen, changeblue;

            lock (objLock)
            {
                changered = redtrackbar.Value * 0.1f;
                changegreen = greentrackbar.Value * 0.1f;
                changeblue = bluetrackbar.Value * 0.1f;
            }
            redbarvalue.Text = changered.ToString();
            bluebarvalue.Text = changeblue.ToString();
            greenbarvalue.Text = changegreen.ToString();


            if (!openpic2)
            {
                MessageBox.Show("Insert Image First!");
                openimage2();
            }
            else
            {



                Image img = pictureBox2.Image;
                // Image img1 = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+changered, 0, 0, 0, 0},
            new float[]{0, 1+changegreen, 0, 0, 0},
            new float[]{0, 0, 1+changeblue, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);


                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);





                g.Dispose();
                pictureBox2.Image = bmpInverted;


            }
        }





        //Buttons
        private void add_Click(object sender, EventArgs e)
        {
            openimage();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            removeimage();
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveimage();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetimage1();
        }

        private void add2_Click(object sender, EventArgs e)
        {
            openimage2();
        }

        private void remove2_Click(object sender, EventArgs e)
        {
            removeimage2();
        }

        private void save2_Click(object sender, EventArgs e)
        {
            saveimage2();
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            resetimage2();
        }

        private void negativefilter_Click(object sender, EventArgs e)
        {
            Task t1 = Task.Factory.StartNew(() =>
            {
                Image img1 = pictureBox1.Image;
                Bitmap negative_filter = new Bitmap(img1);
                negative(negative_filter);
                this.pictureBox1.Image = negative_filter;
            });


            Task t2 = Task.Factory.StartNew(() =>
            {

                Image img1 = pictureBox2.Image;
                Bitmap negative_filter = new Bitmap(img1);
                negative(negative_filter);
                this.pictureBox2.Image = negative_filter;
            });
        }

        private void Horizontal_Flip_Click(object sender, EventArgs e)
        {
            Task t1 = Task.Factory.StartNew(() =>
            {
                Image img1 = pictureBox1.Image;
                horizontalflip(img1);
                this.pictureBox1.Image = img1;
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                Image img1 = pictureBox2.Image;
                horizontalflip(img1);
                this.pictureBox2.Image = img1;
            });
        }

        private void Vertical_Flip_Click(object sender, EventArgs e)
        {
            Task t1 = Task.Factory.StartNew(() =>
            {
                Image img1 = pictureBox1.Image;
                verticalflip(img1);
                this.pictureBox1.Image = img1;
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                Image img1 = pictureBox2.Image;
                verticalflip(img1);
                this.pictureBox2.Image = img1;
            });
        }

        private void Rotate_Right_Click(object sender, EventArgs e)
        {
            Task t1 = Task.Factory.StartNew(() =>
            {
                Image img1 = pictureBox1.Image;
                rotateright(img1);
                this.pictureBox1.Image = img1;
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                Image img1 = pictureBox2.Image;
                rotateright(img1);
                this.pictureBox2.Image = img1;
            });
        }

        private void Rotate_Left_Click(object sender, EventArgs e)
        {
            Task t1 = Task.Factory.StartNew(() =>
            {
                Image img1 = pictureBox1.Image;
                rotateleft(img1);
                this.pictureBox1.Image = img1;
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                Image img1 = pictureBox2.Image;
                rotateleft(img1);
                this.pictureBox2.Image = img1;
            });
        }

        private void greyscale_Click(object sender, EventArgs e)
        {
            Task t1 = Task.Factory.StartNew(() =>
            {

                Image img1 = pictureBox1.Image;
                Bitmap grayscale_filter = new Bitmap(img1);
                grayscale(grayscale_filter);
                this.pictureBox1.Image = grayscale_filter;


            });
            Task t2 = Task.Factory.StartNew(() =>
            {

                Image img1 = pictureBox2.Image;
                Bitmap grayscale_filter = new Bitmap(img1);
                grayscale(grayscale_filter);
                this.pictureBox2.Image = grayscale_filter;


            });
        }

        private void dark_mode_Click(object sender, EventArgs e)
        {
            try
            {
                Task t1 = Task.Factory.StartNew(() =>
                {

                    Image img1 = pictureBox1.Image;
                    Bitmap darkmode_filter = new Bitmap(img1);
                    darkmode(darkmode_filter);
                    this.pictureBox1.Image = darkmode_filter;


                });
                Task t2 = Task.Factory.StartNew(() =>
                {

                    Image img1 = pictureBox2.Image;
                    Bitmap darkmode_filter = new Bitmap(img1);
                    darkmode(darkmode_filter);
                    this.pictureBox2.Image = darkmode_filter;


                });
            }
            catch (AggregateException ae)
            {

            }
        }
        private void sepia_filter_Click(object sender, EventArgs e)
        {
            Task t1 = Task.Factory.StartNew(() =>
            {

                Image img1 = pictureBox1.Image;
                Bitmap sepia_filter = new Bitmap(img1);
                sepia(sepia_filter);
                this.pictureBox1.Image = sepia_filter;


            });
            Task t2 = Task.Factory.StartNew(() =>
            {

                Image img1 = pictureBox2.Image;
                Bitmap sepia_filter = new Bitmap(img1);
                sepia(sepia_filter);
                this.pictureBox2.Image = sepia_filter;


            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void redtrackbar_Scroll(object sender, EventArgs e)
        {

            Task t1 = Task.Factory.StartNew(() =>
              {
                  hue();
              },CancellationToken.None,TaskCreationOptions.None,TaskScheduler.FromCurrentSynchronizationContext());
            Task t2 = Task.Factory.StartNew(() =>
              {
                  hue2();
              }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            Task[] tasks = { t1, t2 };
            Task.WaitAll(tasks);

        }

        private void greentrackbar_Scroll(object sender, EventArgs e)
        {

            Task t1 = Task.Factory.StartNew(() =>
            {
                hue();
            }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            Task t2 = Task.Factory.StartNew(() =>
            {
                hue2();
            }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            Task[] tasks = { t1, t2 };
            Task.WaitAll(tasks);

        }

        private void bluetrackbar_Scroll(object sender, EventArgs e)
        {

            Task t1 = Task.Factory.StartNew(() =>
            {
                hue();
            }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            Task t2 = Task.Factory.StartNew(() =>
            {
                hue2();
            }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
            Task[] tasks = { t1, t2 };
            Task.WaitAll(tasks);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
