namespace PhotoEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rotate = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Button();
            this.effects = new System.Windows.Forms.Button();
            this.crop = new System.Windows.Forms.Button();
            this.resize = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colors = new System.Windows.Forms.Button();
            this.contrast = new System.Windows.Forms.Button();
            this.brightness = new System.Windows.Forms.Button();
            this.wave = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.blur = new System.Windows.Forms.Button();
            this.sharpen = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zoomout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.resizeheightlabel = new System.Windows.Forms.Label();
            this.resizewidthlabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancelresize = new System.Windows.Forms.Button();
            this.applyresize = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.redo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.highbrighten = new System.Windows.Forms.Button();
            this.lowbrighten = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cancelcrop = new System.Windows.Forms.Button();
            this.applycrop = new System.Windows.Forms.Button();
            this.cropheightlabel = new System.Windows.Forms.Label();
            this.cropwidthlabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.backcontrast = new System.Windows.Forms.Button();
            this.highcontrast = new System.Windows.Forms.Button();
            this.lowcontrast = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.canceltext = new System.Windows.Forms.Button();
            this.applytext = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rotate);
            this.panel1.Controls.Add(this.text);
            this.panel1.Controls.Add(this.effects);
            this.panel1.Controls.Add(this.crop);
            this.panel1.Controls.Add(this.resize);
            this.panel1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 90);
            this.panel1.TabIndex = 0;
            // 
            // rotate
            // 
            this.rotate.BackColor = System.Drawing.Color.White;
            this.rotate.Image = ((System.Drawing.Image)(resources.GetObject("rotate.Image")));
            this.rotate.Location = new System.Drawing.Point(80, 12);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(75, 67);
            this.rotate.TabIndex = 4;
            this.rotate.UseVisualStyleBackColor = false;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Silver;
            this.text.ForeColor = System.Drawing.Color.Black;
            this.text.Image = ((System.Drawing.Image)(resources.GetObject("text.Image")));
            this.text.Location = new System.Drawing.Point(322, 12);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(75, 67);
            this.text.TabIndex = 3;
            this.text.UseVisualStyleBackColor = false;
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // effects
            // 
            this.effects.BackColor = System.Drawing.Color.Silver;
            this.effects.ForeColor = System.Drawing.Color.Black;
            this.effects.Image = ((System.Drawing.Image)(resources.GetObject("effects.Image")));
            this.effects.Location = new System.Drawing.Point(241, 12);
            this.effects.Name = "effects";
            this.effects.Size = new System.Drawing.Size(75, 67);
            this.effects.TabIndex = 2;
            this.effects.UseVisualStyleBackColor = false;
            this.effects.Click += new System.EventHandler(this.effects_Click);
            // 
            // crop
            // 
            this.crop.BackColor = System.Drawing.Color.Silver;
            this.crop.ForeColor = System.Drawing.Color.Black;
            this.crop.Image = ((System.Drawing.Image)(resources.GetObject("crop.Image")));
            this.crop.Location = new System.Drawing.Point(161, 12);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(75, 67);
            this.crop.TabIndex = 1;
            this.crop.UseVisualStyleBackColor = false;
            this.crop.Click += new System.EventHandler(this.crop_Click);
            // 
            // resize
            // 
            this.resize.BackColor = System.Drawing.Color.Silver;
            this.resize.ForeColor = System.Drawing.Color.Black;
            this.resize.Image = ((System.Drawing.Image)(resources.GetObject("resize.Image")));
            this.resize.Location = new System.Drawing.Point(3, 12);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(75, 67);
            this.resize.TabIndex = 0;
            this.resize.UseVisualStyleBackColor = false;
            this.resize.Click += new System.EventHandler(this.resize_Click);
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.Color.Silver;
            this.upload.Image = ((System.Drawing.Image)(resources.GetObject("upload.Image")));
            this.upload.Location = new System.Drawing.Point(3, 3);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(65, 23);
            this.upload.TabIndex = 1;
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Silver;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(5, 34);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(65, 23);
            this.save.TabIndex = 2;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // zoomin
            // 
            this.zoomin.BackColor = System.Drawing.Color.Silver;
            this.zoomin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zoomin.Image = ((System.Drawing.Image)(resources.GetObject("zoomin.Image")));
            this.zoomin.Location = new System.Drawing.Point(2, 34);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(65, 23);
            this.zoomin.TabIndex = 6;
            this.zoomin.UseVisualStyleBackColor = false;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.colors);
            this.panel2.Controls.Add(this.contrast);
            this.panel2.Controls.Add(this.brightness);
            this.panel2.Controls.Add(this.wave);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.blur);
            this.panel2.Controls.Add(this.sharpen);
            this.panel2.Controls.Add(this.gray);
            this.panel2.Location = new System.Drawing.Point(170, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 90);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // colors
            // 
            this.colors.Image = ((System.Drawing.Image)(resources.GetObject("colors.Image")));
            this.colors.Location = new System.Drawing.Point(489, 12);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(75, 67);
            this.colors.TabIndex = 7;
            this.colors.UseVisualStyleBackColor = true;
            this.colors.Click += new System.EventHandler(this.colors_Click);
            // 
            // contrast
            // 
            this.contrast.Image = ((System.Drawing.Image)(resources.GetObject("contrast.Image")));
            this.contrast.Location = new System.Drawing.Point(408, 12);
            this.contrast.Name = "contrast";
            this.contrast.Size = new System.Drawing.Size(75, 67);
            this.contrast.TabIndex = 6;
            this.contrast.UseVisualStyleBackColor = true;
            this.contrast.Click += new System.EventHandler(this.contrast_Click);
            // 
            // brightness
            // 
            this.brightness.Image = ((System.Drawing.Image)(resources.GetObject("brightness.Image")));
            this.brightness.Location = new System.Drawing.Point(327, 12);
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(75, 67);
            this.brightness.TabIndex = 5;
            this.brightness.UseVisualStyleBackColor = true;
            this.brightness.Click += new System.EventHandler(this.brightness_Click);
            // 
            // wave
            // 
            this.wave.Image = ((System.Drawing.Image)(resources.GetObject("wave.Image")));
            this.wave.Location = new System.Drawing.Point(246, 12);
            this.wave.Name = "wave";
            this.wave.Size = new System.Drawing.Size(75, 67);
            this.wave.TabIndex = 4;
            this.wave.UseVisualStyleBackColor = true;
            this.wave.Click += new System.EventHandler(this.wave_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Silver;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(570, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 67);
            this.close.TabIndex = 3;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // blur
            // 
            this.blur.BackColor = System.Drawing.Color.Silver;
            this.blur.Image = ((System.Drawing.Image)(resources.GetObject("blur.Image")));
            this.blur.Location = new System.Drawing.Point(165, 12);
            this.blur.Name = "blur";
            this.blur.Size = new System.Drawing.Size(75, 67);
            this.blur.TabIndex = 2;
            this.blur.UseVisualStyleBackColor = false;
            this.blur.Click += new System.EventHandler(this.blur_Click);
            // 
            // sharpen
            // 
            this.sharpen.BackColor = System.Drawing.Color.Silver;
            this.sharpen.Image = ((System.Drawing.Image)(resources.GetObject("sharpen.Image")));
            this.sharpen.Location = new System.Drawing.Point(84, 12);
            this.sharpen.Name = "sharpen";
            this.sharpen.Size = new System.Drawing.Size(75, 67);
            this.sharpen.TabIndex = 1;
            this.sharpen.UseVisualStyleBackColor = false;
            this.sharpen.Click += new System.EventHandler(this.sharpen_Click);
            // 
            // gray
            // 
            this.gray.BackColor = System.Drawing.Color.Silver;
            this.gray.Image = ((System.Drawing.Image)(resources.GetObject("gray.Image")));
            this.gray.Location = new System.Drawing.Point(3, 10);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(75, 67);
            this.gray.TabIndex = 0;
            this.gray.UseVisualStyleBackColor = false;
            this.gray.Click += new System.EventHandler(this.gray_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(146, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 500);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // zoomout
            // 
            this.zoomout.BackColor = System.Drawing.Color.Silver;
            this.zoomout.Image = ((System.Drawing.Image)(resources.GetObject("zoomout.Image")));
            this.zoomout.Location = new System.Drawing.Point(0, 63);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(65, 23);
            this.zoomout.TabIndex = 9;
            this.zoomout.UseVisualStyleBackColor = false;
            this.zoomout.Click += new System.EventHandler(this.zoomout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.exit);
            this.panel4.Controls.Add(this.save);
            this.panel4.Controls.Add(this.upload);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 90);
            this.panel4.TabIndex = 10;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(3, 63);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 23);
            this.exit.TabIndex = 3;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Controls.Add(this.resizeheightlabel);
            this.panel6.Controls.Add(this.resizewidthlabel);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.cancelresize);
            this.panel6.Controls.Add(this.applyresize);
            this.panel6.Location = new System.Drawing.Point(170, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 70);
            this.panel6.TabIndex = 12;
            this.panel6.Visible = false;
            // 
            // resizeheightlabel
            // 
            this.resizeheightlabel.AutoSize = true;
            this.resizeheightlabel.ForeColor = System.Drawing.Color.White;
            this.resizeheightlabel.Location = new System.Drawing.Point(114, 38);
            this.resizeheightlabel.Name = "resizeheightlabel";
            this.resizeheightlabel.Size = new System.Drawing.Size(38, 13);
            this.resizeheightlabel.TabIndex = 9;
            this.resizeheightlabel.Text = "Height";
            // 
            // resizewidthlabel
            // 
            this.resizewidthlabel.AutoSize = true;
            this.resizewidthlabel.ForeColor = System.Drawing.Color.White;
            this.resizewidthlabel.Location = new System.Drawing.Point(114, 9);
            this.resizewidthlabel.Name = "resizewidthlabel";
            this.resizewidthlabel.Size = new System.Drawing.Size(35, 13);
            this.resizewidthlabel.TabIndex = 8;
            this.resizewidthlabel.Text = "Width";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox2.Location = new System.Drawing.Point(8, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // cancelresize
            // 
            this.cancelresize.Image = ((System.Drawing.Image)(resources.GetObject("cancelresize.Image")));
            this.cancelresize.Location = new System.Drawing.Point(172, 33);
            this.cancelresize.Name = "cancelresize";
            this.cancelresize.Size = new System.Drawing.Size(75, 23);
            this.cancelresize.TabIndex = 3;
            this.cancelresize.UseVisualStyleBackColor = true;
            this.cancelresize.Click += new System.EventHandler(this.cancel_Click);
            // 
            // applyresize
            // 
            this.applyresize.Image = ((System.Drawing.Image)(resources.GetObject("applyresize.Image")));
            this.applyresize.Location = new System.Drawing.Point(172, 4);
            this.applyresize.Name = "applyresize";
            this.applyresize.Size = new System.Drawing.Size(75, 23);
            this.applyresize.TabIndex = 2;
            this.applyresize.UseVisualStyleBackColor = true;
            this.applyresize.Click += new System.EventHandler(this.applyresize_Click);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.Silver;
            this.undo.Image = ((System.Drawing.Image)(resources.GetObject("undo.Image")));
            this.undo.Location = new System.Drawing.Point(13, 20);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(75, 23);
            this.undo.TabIndex = 3;
            this.undo.UseVisualStyleBackColor = false;
            // 
            // redo
            // 
            this.redo.BackColor = System.Drawing.Color.Silver;
            this.redo.Image = ((System.Drawing.Image)(resources.GetObject("redo.Image")));
            this.redo.Location = new System.Drawing.Point(13, 49);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(75, 23);
            this.redo.TabIndex = 4;
            this.redo.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.redo);
            this.panel5.Controls.Add(this.undo);
            this.panel5.Location = new System.Drawing.Point(70, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 90);
            this.panel5.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel7.Controls.Add(this.back);
            this.panel7.Controls.Add(this.highbrighten);
            this.panel7.Controls.Add(this.lowbrighten);
            this.panel7.Location = new System.Drawing.Point(425, 90);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 70);
            this.panel7.TabIndex = 13;
            this.panel7.Visible = false;
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(101, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 67);
            this.back.TabIndex = 2;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // highbrighten
            // 
            this.highbrighten.Image = ((System.Drawing.Image)(resources.GetObject("highbrighten.Image")));
            this.highbrighten.Location = new System.Drawing.Point(8, 32);
            this.highbrighten.Name = "highbrighten";
            this.highbrighten.Size = new System.Drawing.Size(75, 23);
            this.highbrighten.TabIndex = 1;
            this.highbrighten.UseVisualStyleBackColor = true;
            this.highbrighten.Click += new System.EventHandler(this.highbrighten_Click_1);
            // 
            // lowbrighten
            // 
            this.lowbrighten.Image = ((System.Drawing.Image)(resources.GetObject("lowbrighten.Image")));
            this.lowbrighten.Location = new System.Drawing.Point(8, 3);
            this.lowbrighten.Name = "lowbrighten";
            this.lowbrighten.Size = new System.Drawing.Size(75, 23);
            this.lowbrighten.TabIndex = 0;
            this.lowbrighten.UseVisualStyleBackColor = true;
            this.lowbrighten.Click += new System.EventHandler(this.lowbrighten_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel8.Controls.Add(this.menu);
            this.panel8.Controls.Add(this.zoomout);
            this.panel8.Controls.Add(this.zoomin);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(70, 90);
            this.panel8.TabIndex = 14;
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(2, 5);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(65, 23);
            this.menu.TabIndex = 3;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel9.Controls.Add(this.cancelcrop);
            this.panel9.Controls.Add(this.applycrop);
            this.panel9.Controls.Add(this.cropheightlabel);
            this.panel9.Controls.Add(this.cropwidthlabel);
            this.panel9.Controls.Add(this.textBox4);
            this.panel9.Controls.Add(this.textBox3);
            this.panel9.Location = new System.Drawing.Point(170, 90);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(255, 70);
            this.panel9.TabIndex = 15;
            this.panel9.Visible = false;
            // 
            // cancelcrop
            // 
            this.cancelcrop.Image = ((System.Drawing.Image)(resources.GetObject("cancelcrop.Image")));
            this.cancelcrop.Location = new System.Drawing.Point(168, 38);
            this.cancelcrop.Name = "cancelcrop";
            this.cancelcrop.Size = new System.Drawing.Size(75, 23);
            this.cancelcrop.TabIndex = 5;
            this.cancelcrop.UseVisualStyleBackColor = true;
            this.cancelcrop.Click += new System.EventHandler(this.cancelcrop_Click);
            // 
            // applycrop
            // 
            this.applycrop.Image = ((System.Drawing.Image)(resources.GetObject("applycrop.Image")));
            this.applycrop.Location = new System.Drawing.Point(168, 9);
            this.applycrop.Name = "applycrop";
            this.applycrop.Size = new System.Drawing.Size(75, 23);
            this.applycrop.TabIndex = 4;
            this.applycrop.UseVisualStyleBackColor = true;
            this.applycrop.Click += new System.EventHandler(this.applycrop_Click);
            // 
            // cropheightlabel
            // 
            this.cropheightlabel.AutoSize = true;
            this.cropheightlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cropheightlabel.Location = new System.Drawing.Point(118, 41);
            this.cropheightlabel.Name = "cropheightlabel";
            this.cropheightlabel.Size = new System.Drawing.Size(38, 13);
            this.cropheightlabel.TabIndex = 3;
            this.cropheightlabel.Text = "Height";
            // 
            // cropwidthlabel
            // 
            this.cropwidthlabel.AutoSize = true;
            this.cropwidthlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cropwidthlabel.Location = new System.Drawing.Point(118, 14);
            this.cropwidthlabel.Name = "cropwidthlabel";
            this.cropwidthlabel.Size = new System.Drawing.Size(35, 13);
            this.cropwidthlabel.TabIndex = 2;
            this.cropwidthlabel.Text = "Width";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox4.Location = new System.Drawing.Point(12, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox3.Location = new System.Drawing.Point(12, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel10.Controls.Add(this.backcontrast);
            this.panel10.Controls.Add(this.highcontrast);
            this.panel10.Controls.Add(this.lowcontrast);
            this.panel10.Location = new System.Drawing.Point(425, 90);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(180, 70);
            this.panel10.TabIndex = 16;
            this.panel10.Visible = false;
            // 
            // backcontrast
            // 
            this.backcontrast.Image = ((System.Drawing.Image)(resources.GetObject("backcontrast.Image")));
            this.backcontrast.Location = new System.Drawing.Point(94, 0);
            this.backcontrast.Name = "backcontrast";
            this.backcontrast.Size = new System.Drawing.Size(75, 67);
            this.backcontrast.TabIndex = 2;
            this.backcontrast.UseVisualStyleBackColor = true;
            this.backcontrast.Click += new System.EventHandler(this.backcontrast_Click);
            // 
            // highcontrast
            // 
            this.highcontrast.Image = ((System.Drawing.Image)(resources.GetObject("highcontrast.Image")));
            this.highcontrast.Location = new System.Drawing.Point(13, 31);
            this.highcontrast.Name = "highcontrast";
            this.highcontrast.Size = new System.Drawing.Size(75, 23);
            this.highcontrast.TabIndex = 1;
            this.highcontrast.UseVisualStyleBackColor = true;
            this.highcontrast.Click += new System.EventHandler(this.highcontrast_Click);
            // 
            // lowcontrast
            // 
            this.lowcontrast.Image = ((System.Drawing.Image)(resources.GetObject("lowcontrast.Image")));
            this.lowcontrast.Location = new System.Drawing.Point(13, 6);
            this.lowcontrast.Name = "lowcontrast";
            this.lowcontrast.Size = new System.Drawing.Size(75, 23);
            this.lowcontrast.TabIndex = 0;
            this.lowcontrast.UseVisualStyleBackColor = true;
            this.lowcontrast.Click += new System.EventHandler(this.lowcontrast_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel11.Controls.Add(this.canceltext);
            this.panel11.Controls.Add(this.applytext);
            this.panel11.Controls.Add(this.textBox5);
            this.panel11.Location = new System.Drawing.Point(170, 90);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(255, 70);
            this.panel11.TabIndex = 17;
            this.panel11.Visible = false;
            // 
            // canceltext
            // 
            this.canceltext.Image = ((System.Drawing.Image)(resources.GetObject("canceltext.Image")));
            this.canceltext.Location = new System.Drawing.Point(167, 33);
            this.canceltext.Name = "canceltext";
            this.canceltext.Size = new System.Drawing.Size(75, 23);
            this.canceltext.TabIndex = 2;
            this.canceltext.UseVisualStyleBackColor = true;
            this.canceltext.Click += new System.EventHandler(this.canceltext_Click);
            // 
            // applytext
            // 
            this.applytext.Image = ((System.Drawing.Image)(resources.GetObject("applytext.Image")));
            this.applytext.Location = new System.Drawing.Point(167, 6);
            this.applytext.Name = "applytext";
            this.applytext.Size = new System.Drawing.Size(75, 23);
            this.applytext.TabIndex = 1;
            this.applytext.UseVisualStyleBackColor = true;
            this.applytext.Click += new System.EventHandler(this.applytext_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox5.Location = new System.Drawing.Point(24, 8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 750);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Photo_Editor";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button text;
        private System.Windows.Forms.Button effects;
        private System.Windows.Forms.Button crop;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button zoomin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button blur;
        private System.Windows.Forms.Button sharpen;
        private System.Windows.Forms.Button gray;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button zoomout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label resizeheightlabel;
        private System.Windows.Forms.Label resizewidthlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancelresize;
        private System.Windows.Forms.Button applyresize;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button redo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.Button wave;
        private System.Windows.Forms.Button brightness;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button highbrighten;
        private System.Windows.Forms.Button lowbrighten;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label cropheightlabel;
        private System.Windows.Forms.Label cropwidthlabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cancelcrop;
        private System.Windows.Forms.Button applycrop;
        private System.Windows.Forms.Button colors;
        private System.Windows.Forms.Button contrast;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button backcontrast;
        private System.Windows.Forms.Button highcontrast;
        private System.Windows.Forms.Button lowcontrast;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button canceltext;
        private System.Windows.Forms.Button applytext;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button menu;


    }
}

