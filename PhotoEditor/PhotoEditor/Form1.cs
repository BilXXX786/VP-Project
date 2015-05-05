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
/*
using RasterEdge.Imaging.Basic;
using RasterEdge.Imaging.Basic.Core;
using RasterEdge.Imaging.Processing;
using RasterEdge.Imaging.Basic.Codec;
*/

namespace PhotoEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";
            DialogResult dr = openfd.ShowDialog();
             Bitmap objBitmap = new Bitmap(System.Drawing.Image.FromFile(openfd.FileName), new Size(500, 400));
            pictureBox1.Image = objBitmap;
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

        private void effects_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
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

        private void blur_Click(object sender, EventArgs e)
        {
            GaussianBlur filter = new GaussianBlur(4, 11);
            
            Bitmap newimage= filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = newimage;

           
        }

        private void gray_Click(object sender, EventArgs e)
        {


            GrayscaleBT709 gray1=new GrayscaleBT709();
            pictureBox1.Image = gray1.Apply((Bitmap)pictureBox1.Image);
           
        }

        private void resize_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel6.Visible = true;
            /*
            ResizeNearestNeighbor filter = new ResizeNearestNeighbor(400, 300); 
            Bitmap newImage = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = newImage;
            */
        }

        private void crop_Click(object sender, EventArgs e)
        {
            
        }

        private void sharpen_Click(object sender, EventArgs e)
        {
            Median filter = new Median();
            Bitmap newimage= filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = newimage;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel6.Visible = false;
           
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            RotateNearestNeighbor filter = new RotateNearestNeighbor(90, true);
            Bitmap newImage = filter.Apply((Bitmap)pictureBox1.Image);
            pictureBox1.Image = newImage;
        }
            
    }
}
