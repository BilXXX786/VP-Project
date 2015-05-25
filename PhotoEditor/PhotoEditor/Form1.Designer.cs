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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clipboard = new System.Windows.Forms.Label();
            this.redo = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.effects = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Button();
            this.contrast = new System.Windows.Forms.Button();
            this.brighten = new System.Windows.Forms.Button();
            this.wave = new System.Windows.Forms.Button();
            this.blur = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.Label();
            this.rotate = new System.Windows.Forms.Button();
            this.resize = new System.Windows.Forms.Button();
            this.crop = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.display = new System.Windows.Forms.Label();
            this.zoomout = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelcrop = new System.Windows.Forms.Button();
            this.applycrop = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelresize = new System.Windows.Forms.Button();
            this.applyresize = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.backbrighten = new System.Windows.Forms.Button();
            this.highbrighten = new System.Windows.Forms.Button();
            this.lowbrighten = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.backcontrast = new System.Windows.Forms.Button();
            this.highcontrast = new System.Windows.Forms.Button();
            this.lowcontrast = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.canceltext = new System.Windows.Forms.Button();
            this.applytext = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(150, 210);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1300, 120);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.clipboard);
            this.tabPage1.Controls.Add(this.redo);
            this.tabPage1.Controls.Add(this.undo);
            this.tabPage1.Controls.Add(this.file);
            this.tabPage1.Controls.Add(this.save);
            this.tabPage1.Controls.Add(this.upload);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1292, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            // 
            // clipboard
            // 
            this.clipboard.AutoSize = true;
            this.clipboard.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboard.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clipboard.Location = new System.Drawing.Point(362, 71);
            this.clipboard.Name = "clipboard";
            this.clipboard.Size = new System.Drawing.Size(59, 15);
            this.clipboard.TabIndex = 5;
            this.clipboard.Text = "Clipboard";
            // 
            // redo
            // 
            this.redo.FlatAppearance.BorderSize = 0;
            this.redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redo.Location = new System.Drawing.Point(396, 3);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(75, 23);
            this.redo.TabIndex = 4;
            this.redo.Text = "Redo";
            this.redo.UseVisualStyleBackColor = true;
            // 
            // undo
            // 
            this.undo.FlatAppearance.BorderSize = 0;
            this.undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo.Location = new System.Drawing.Point(297, 2);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(75, 23);
            this.undo.TabIndex = 3;
            this.undo.Text = "Undo";
            this.undo.UseVisualStyleBackColor = true;
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.file.Location = new System.Drawing.Point(63, 70);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(27, 15);
            this.file.TabIndex = 2;
            this.file.Text = "File";
            // 
            // save
            // 
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(84, 6);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // upload
            // 
            this.upload.FlatAppearance.BorderSize = 0;
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(3, 6);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 0;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.effects);
            this.tabPage2.Controls.Add(this.text);
            this.tabPage2.Controls.Add(this.contrast);
            this.tabPage2.Controls.Add(this.brighten);
            this.tabPage2.Controls.Add(this.wave);
            this.tabPage2.Controls.Add(this.blur);
            this.tabPage2.Controls.Add(this.gray);
            this.tabPage2.Controls.Add(this.image);
            this.tabPage2.Controls.Add(this.rotate);
            this.tabPage2.Controls.Add(this.resize);
            this.tabPage2.Controls.Add(this.crop);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1292, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Home";
            // 
            // effects
            // 
            this.effects.AutoSize = true;
            this.effects.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effects.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.effects.Location = new System.Drawing.Point(486, 71);
            this.effects.Name = "effects";
            this.effects.Size = new System.Drawing.Size(43, 15);
            this.effects.TabIndex = 10;
            this.effects.Text = "Effects";
            // 
            // text
            // 
            this.text.FlatAppearance.BorderSize = 0;
            this.text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(566, 28);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(75, 23);
            this.text.TabIndex = 9;
            this.text.Text = "Text";
            this.text.UseVisualStyleBackColor = true;
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // contrast
            // 
            this.contrast.FlatAppearance.BorderSize = 0;
            this.contrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrast.Location = new System.Drawing.Point(471, 27);
            this.contrast.Name = "contrast";
            this.contrast.Size = new System.Drawing.Size(75, 23);
            this.contrast.TabIndex = 8;
            this.contrast.Text = "Contrast";
            this.contrast.UseVisualStyleBackColor = true;
            this.contrast.Click += new System.EventHandler(this.contrast_Click);
            // 
            // brighten
            // 
            this.brighten.FlatAppearance.BorderSize = 0;
            this.brighten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brighten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brighten.Location = new System.Drawing.Point(365, 28);
            this.brighten.Name = "brighten";
            this.brighten.Size = new System.Drawing.Size(75, 23);
            this.brighten.TabIndex = 7;
            this.brighten.Text = "Brighten";
            this.brighten.UseVisualStyleBackColor = true;
            this.brighten.Click += new System.EventHandler(this.brighten_Click);
            // 
            // wave
            // 
            this.wave.FlatAppearance.BorderSize = 0;
            this.wave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wave.Location = new System.Drawing.Point(566, 2);
            this.wave.Name = "wave";
            this.wave.Size = new System.Drawing.Size(75, 23);
            this.wave.TabIndex = 6;
            this.wave.Text = "Wave";
            this.wave.UseVisualStyleBackColor = true;
            this.wave.Click += new System.EventHandler(this.wave_Click);
            // 
            // blur
            // 
            this.blur.FlatAppearance.BorderSize = 0;
            this.blur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blur.Location = new System.Drawing.Point(471, -2);
            this.blur.Name = "blur";
            this.blur.Size = new System.Drawing.Size(75, 23);
            this.blur.TabIndex = 5;
            this.blur.Text = "Blur";
            this.blur.UseVisualStyleBackColor = true;
            this.blur.Click += new System.EventHandler(this.blur_Click);
            // 
            // gray
            // 
            this.gray.FlatAppearance.BorderSize = 0;
            this.gray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gray.Location = new System.Drawing.Point(365, -1);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(75, 23);
            this.gray.TabIndex = 4;
            this.gray.Text = "Gray";
            this.gray.UseVisualStyleBackColor = true;
            this.gray.Click += new System.EventHandler(this.gray_Click);
            // 
            // image
            // 
            this.image.AutoSize = true;
            this.image.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.image.Location = new System.Drawing.Point(101, 71);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(42, 15);
            this.image.TabIndex = 3;
            this.image.Text = "Image";
            // 
            // rotate
            // 
            this.rotate.FlatAppearance.BorderSize = 0;
            this.rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate.Location = new System.Drawing.Point(83, -1);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(75, 20);
            this.rotate.TabIndex = 2;
            this.rotate.Text = "Rotate";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // resize
            // 
            this.resize.FlatAppearance.BorderSize = 0;
            this.resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resize.Location = new System.Drawing.Point(164, -1);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(75, 20);
            this.resize.TabIndex = 1;
            this.resize.Text = "Resize";
            this.resize.UseVisualStyleBackColor = true;
            this.resize.Click += new System.EventHandler(this.resize_Click);
            // 
            // crop
            // 
            this.crop.FlatAppearance.BorderSize = 0;
            this.crop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crop.Location = new System.Drawing.Point(2, -1);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(75, 20);
            this.crop.TabIndex = 0;
            this.crop.Text = "Crop";
            this.crop.UseVisualStyleBackColor = true;
            this.crop.Click += new System.EventHandler(this.crop_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.display);
            this.tabPage3.Controls.Add(this.zoomout);
            this.tabPage3.Controls.Add(this.zoomin);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1292, 94);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View";
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display.Location = new System.Drawing.Point(74, 70);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(50, 15);
            this.display.TabIndex = 2;
            this.display.Text = "Display";
            // 
            // zoomout
            // 
            this.zoomout.FlatAppearance.BorderSize = 0;
            this.zoomout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomout.Location = new System.Drawing.Point(106, 3);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(75, 23);
            this.zoomout.TabIndex = 1;
            this.zoomout.Text = "ZoomOut";
            this.zoomout.UseVisualStyleBackColor = true;
            this.zoomout.Click += new System.EventHandler(this.zoomout_Click);
            // 
            // zoomin
            // 
            this.zoomin.FlatAppearance.BorderSize = 0;
            this.zoomin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomin.Location = new System.Drawing.Point(16, 3);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(75, 23);
            this.zoomin.TabIndex = 0;
            this.zoomin.Text = "ZoomIn";
            this.zoomin.UseVisualStyleBackColor = true;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cancelcrop);
            this.panel1.Controls.Add(this.applycrop);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 80);
            this.panel1.TabIndex = 19;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(72, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(72, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width";
            // 
            // cancelcrop
            // 
            this.cancelcrop.FlatAppearance.BorderSize = 0;
            this.cancelcrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelcrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelcrop.Location = new System.Drawing.Point(113, 40);
            this.cancelcrop.Name = "cancelcrop";
            this.cancelcrop.Size = new System.Drawing.Size(75, 23);
            this.cancelcrop.TabIndex = 3;
            this.cancelcrop.Text = "Cancel";
            this.cancelcrop.UseVisualStyleBackColor = true;
            this.cancelcrop.Click += new System.EventHandler(this.cancelcrop_Click);
            // 
            // applycrop
            // 
            this.applycrop.FlatAppearance.BorderSize = 0;
            this.applycrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applycrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applycrop.Location = new System.Drawing.Point(113, 6);
            this.applycrop.Name = "applycrop";
            this.applycrop.Size = new System.Drawing.Size(75, 23);
            this.applycrop.TabIndex = 2;
            this.applycrop.Text = "Apply";
            this.applycrop.UseVisualStyleBackColor = true;
            this.applycrop.Click += new System.EventHandler(this.applycrop_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cancelresize);
            this.panel2.Controls.Add(this.applyresize);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 80);
            this.panel2.TabIndex = 20;
            this.panel2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(69, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(69, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Width";
            // 
            // cancelresize
            // 
            this.cancelresize.FlatAppearance.BorderSize = 0;
            this.cancelresize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelresize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelresize.Location = new System.Drawing.Point(122, 45);
            this.cancelresize.Name = "cancelresize";
            this.cancelresize.Size = new System.Drawing.Size(75, 23);
            this.cancelresize.TabIndex = 3;
            this.cancelresize.Text = "Cancel";
            this.cancelresize.UseVisualStyleBackColor = true;
            this.cancelresize.Click += new System.EventHandler(this.cancelresize_Click);
            // 
            // applyresize
            // 
            this.applyresize.FlatAppearance.BorderSize = 0;
            this.applyresize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyresize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyresize.Location = new System.Drawing.Point(122, 8);
            this.applyresize.Name = "applyresize";
            this.applyresize.Size = new System.Drawing.Size(75, 23);
            this.applyresize.TabIndex = 2;
            this.applyresize.Text = "Apply";
            this.applyresize.UseVisualStyleBackColor = true;
            this.applyresize.Click += new System.EventHandler(this.applyresize_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.backbrighten);
            this.panel4.Controls.Add(this.highbrighten);
            this.panel4.Controls.Add(this.lowbrighten);
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(370, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 80);
            this.panel4.TabIndex = 21;
            this.panel4.Visible = false;
            // 
            // backbrighten
            // 
            this.backbrighten.FlatAppearance.BorderSize = 0;
            this.backbrighten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbrighten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbrighten.Location = new System.Drawing.Point(106, 27);
            this.backbrighten.Name = "backbrighten";
            this.backbrighten.Size = new System.Drawing.Size(75, 23);
            this.backbrighten.TabIndex = 2;
            this.backbrighten.Text = "Back";
            this.backbrighten.UseVisualStyleBackColor = true;
            this.backbrighten.Click += new System.EventHandler(this.backbrighten_Click);
            // 
            // highbrighten
            // 
            this.highbrighten.FlatAppearance.BorderSize = 0;
            this.highbrighten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highbrighten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highbrighten.Location = new System.Drawing.Point(17, 45);
            this.highbrighten.Name = "highbrighten";
            this.highbrighten.Size = new System.Drawing.Size(75, 23);
            this.highbrighten.TabIndex = 1;
            this.highbrighten.Text = "High";
            this.highbrighten.UseVisualStyleBackColor = true;
            this.highbrighten.Click += new System.EventHandler(this.highbrighten_Click);
            // 
            // lowbrighten
            // 
            this.lowbrighten.FlatAppearance.BorderSize = 0;
            this.lowbrighten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowbrighten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowbrighten.Location = new System.Drawing.Point(17, 8);
            this.lowbrighten.Name = "lowbrighten";
            this.lowbrighten.Size = new System.Drawing.Size(75, 23);
            this.lowbrighten.TabIndex = 0;
            this.lowbrighten.Text = "Low";
            this.lowbrighten.UseVisualStyleBackColor = true;
            this.lowbrighten.Click += new System.EventHandler(this.lowbrighten_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Controls.Add(this.backcontrast);
            this.panel5.Controls.Add(this.highcontrast);
            this.panel5.Controls.Add(this.lowcontrast);
            this.panel5.Location = new System.Drawing.Point(370, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 80);
            this.panel5.TabIndex = 22;
            this.panel5.Visible = false;
            // 
            // backcontrast
            // 
            this.backcontrast.FlatAppearance.BorderSize = 0;
            this.backcontrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backcontrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backcontrast.Location = new System.Drawing.Point(111, 27);
            this.backcontrast.Name = "backcontrast";
            this.backcontrast.Size = new System.Drawing.Size(75, 23);
            this.backcontrast.TabIndex = 2;
            this.backcontrast.Text = "Back";
            this.backcontrast.UseVisualStyleBackColor = true;
            this.backcontrast.Click += new System.EventHandler(this.backcontrast_Click);
            // 
            // highcontrast
            // 
            this.highcontrast.FlatAppearance.BorderSize = 0;
            this.highcontrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highcontrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highcontrast.Location = new System.Drawing.Point(20, 43);
            this.highcontrast.Name = "highcontrast";
            this.highcontrast.Size = new System.Drawing.Size(75, 23);
            this.highcontrast.TabIndex = 1;
            this.highcontrast.Text = "High";
            this.highcontrast.UseVisualStyleBackColor = true;
            this.highcontrast.Click += new System.EventHandler(this.highcontrast_Click);
            // 
            // lowcontrast
            // 
            this.lowcontrast.FlatAppearance.BorderSize = 0;
            this.lowcontrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowcontrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowcontrast.Location = new System.Drawing.Point(20, 8);
            this.lowcontrast.Name = "lowcontrast";
            this.lowcontrast.Size = new System.Drawing.Size(75, 23);
            this.lowcontrast.TabIndex = 0;
            this.lowcontrast.Text = "Low";
            this.lowcontrast.UseVisualStyleBackColor = true;
            this.lowcontrast.Click += new System.EventHandler(this.lowcontrast_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Controls.Add(this.canceltext);
            this.panel6.Controls.Add(this.applytext);
            this.panel6.Controls.Add(this.textBox5);
            this.panel6.Location = new System.Drawing.Point(600, 120);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 80);
            this.panel6.TabIndex = 23;
            this.panel6.Visible = false;
            // 
            // canceltext
            // 
            this.canceltext.FlatAppearance.BorderSize = 0;
            this.canceltext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canceltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canceltext.Location = new System.Drawing.Point(119, 46);
            this.canceltext.Name = "canceltext";
            this.canceltext.Size = new System.Drawing.Size(75, 23);
            this.canceltext.TabIndex = 2;
            this.canceltext.Text = "Cancel";
            this.canceltext.UseVisualStyleBackColor = true;
            this.canceltext.Click += new System.EventHandler(this.canceltext_Click);
            // 
            // applytext
            // 
            this.applytext.FlatAppearance.BorderSize = 0;
            this.applytext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applytext.Location = new System.Drawing.Point(119, 10);
            this.applytext.Name = "applytext";
            this.applytext.Size = new System.Drawing.Size(75, 23);
            this.applytext.TabIndex = 1;
            this.applytext.Text = "Apply";
            this.applytext.UseVisualStyleBackColor = true;
            this.applytext.Click += new System.EventHandler(this.applytext_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 11);
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
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Photo_Editor";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.Button crop;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.Button text;
        private System.Windows.Forms.Button contrast;
        private System.Windows.Forms.Button brighten;
        private System.Windows.Forms.Button wave;
        private System.Windows.Forms.Button blur;
        private System.Windows.Forms.Button gray;
        private System.Windows.Forms.Label effects;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button zoomout;
        private System.Windows.Forms.Button zoomin;
        private System.Windows.Forms.Label file;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelcrop;
        private System.Windows.Forms.Button applycrop;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelresize;
        private System.Windows.Forms.Button applyresize;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button backbrighten;
        private System.Windows.Forms.Button highbrighten;
        private System.Windows.Forms.Button lowbrighten;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button backcontrast;
        private System.Windows.Forms.Button highcontrast;
        private System.Windows.Forms.Button lowcontrast;
        private System.Windows.Forms.Label clipboard;
        private System.Windows.Forms.Button redo;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button canceltext;
        private System.Windows.Forms.Button applytext;
        private System.Windows.Forms.TextBox textBox5;


    }
}

