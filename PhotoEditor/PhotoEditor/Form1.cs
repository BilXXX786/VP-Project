using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Drawing.Imaging;
using AForge;
using AForge.Imaging;
using AForge.Imaging.ColorReduction;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.Filters;
using System.Drawing.Text;

namespace PhotoEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
         
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(sfd.FileName, format);
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
        OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";
            DialogResult dr = openfd.ShowDialog();
            Bitmap objBitmap = new Bitmap(System.Drawing.Image.FromFile(openfd.FileName), new Size(500, 500));

            pictureBox1.Image = objBitmap;
        }

        private void crop_Click(object sender, EventArgs e)
        {
        panel1.Visible = true;
        }

        private void cancelcrop_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }

        private void applycrop_Click(object sender, EventArgs e)
        {
        int height, width;
            width = Int32.Parse(textBox1.Text);
            height = Int32.Parse(textBox2.Text);
            Crop filter = new Crop(new Rectangle(width, height, 500-width, 500-height));
            Bitmap newImage = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = newImage;
            panel1.Visible = false;
        }

        private void rotate_Click(object sender, EventArgs e)
        {
        RotateNearestNeighbor filter = new RotateNearestNeighbor(90, true);
            Bitmap newImage = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = newImage;
        }

        private void resize_Click(object sender, EventArgs e)
        {
            panel2.Visible=true;
        }

        private void cancelresize_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }

        private void applyresize_Click(object sender, EventArgs e)
        {
        int height, width;
            width = Int32.Parse(textBox3.Text);
            height = Int32.Parse(textBox4.Text);
            ResizeNearestNeighbor filter = new ResizeNearestNeighbor(width, height);
            Bitmap newImage = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = newImage;
            panel2.Visible = false;
        }

        private void gray_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 gray1 = new GrayscaleBT709();
            pictureBox1.Image = gray1.Apply((Bitmap)pictureBox1.Image);
        }

        private void blur_Click(object sender, EventArgs e)
        {
            GaussianBlur filter = new GaussianBlur(4, 11);

            Bitmap newimage = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = newimage;
        }

        private void wave_Click(object sender, EventArgs e)
        {
            WaterWave filter = new WaterWave();
            filter.HorizontalWavesCount = 10;
            filter.HorizontalWavesAmplitude = 5;
            filter.VerticalWavesCount = 10;
            filter.VerticalWavesAmplitude = 5;
            Bitmap waveimage = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = waveimage;
        }

        private void brighten_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void backbrighten_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void highbrighten_Click(object sender, EventArgs e)
        {
            BrightnessCorrection filter = new BrightnessCorrection(15);
            Bitmap bright = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = bright;
        }

        private void lowbrighten_Click(object sender, EventArgs e)
        {
            BrightnessCorrection filter = new BrightnessCorrection(-15);
            Bitmap bright = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = bright;
        }

        private void contrast_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void backcontrast_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void highcontrast_Click(object sender, EventArgs e)
        {
            ContrastCorrection filter = new ContrastCorrection(15);
            Bitmap contrast = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = contrast;
        }

        private void lowcontrast_Click(object sender, EventArgs e)
        {
            ContrastCorrection filter = new ContrastCorrection(-15);
            Bitmap contrast = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = contrast;
        }

        private void text_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void canceltext_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void applytext_Click(object sender, EventArgs e)
        {
       

            /*
            String drawString = textBox5.Text;
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 150.0F;
            float y = 150.0F;
            float width = 200.0F;
            float height = 50.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);
            Pen blackPen = new Pen(Color.Black);

            pictureBox1.Image = e.Graphics.DrawRectangle(blackPen, x, y, width, height);
            pictureBox1.Image = e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect);
             */
        }

        private void zoomin_Click(object sender, EventArgs e)
        {
            Size newSize = new Size((int)(pictureBox1.Image.Width * 1.25), (int)(pictureBox1.Image.Height * 1.25));
            Bitmap obj = new Bitmap(pictureBox1.Image, newSize);
            pictureBox1.Image = obj;
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            Size newSize = new Size((int)(pictureBox1.Image.Width * .75), (int)(pictureBox1.Image.Height * .75));
            Bitmap obj = new Bitmap(pictureBox1.Image, newSize);
            pictureBox1.Image = obj;
        }

       

      

        
        
        }

        
        

        

     

       
        
        
    }

