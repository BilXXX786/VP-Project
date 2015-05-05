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
            this.text = new System.Windows.Forms.Button();
            this.effects = new System.Windows.Forms.Button();
            this.crop = new System.Windows.Forms.Button();
            this.resize = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.zoomin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.blur = new System.Windows.Forms.Button();
            this.sharpen = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zoomout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.heightlabel = new System.Windows.Forms.Label();
            this.widthlabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.redo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rotate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rotate);
            this.panel1.Controls.Add(this.text);
            this.panel1.Controls.Add(this.effects);
            this.panel1.Controls.Add(this.crop);
            this.panel1.Controls.Add(this.resize);
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(200, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 70);
            this.panel1.TabIndex = 0;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Silver;
            this.text.ForeColor = System.Drawing.Color.Black;
            this.text.Image = ((System.Drawing.Image)(resources.GetObject("text.Image")));
            this.text.Location = new System.Drawing.Point(322, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(75, 67);
            this.text.TabIndex = 3;
            this.text.UseVisualStyleBackColor = false;
            // 
            // effects
            // 
            this.effects.BackColor = System.Drawing.Color.Silver;
            this.effects.ForeColor = System.Drawing.Color.Black;
            this.effects.Image = ((System.Drawing.Image)(resources.GetObject("effects.Image")));
            this.effects.Location = new System.Drawing.Point(241, 0);
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
            this.crop.Location = new System.Drawing.Point(160, 0);
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
            this.resize.Location = new System.Drawing.Point(8, 0);
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
            this.upload.Location = new System.Drawing.Point(13, 19);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 1;
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Silver;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(13, 48);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // zoomin
            // 
            this.zoomin.BackColor = System.Drawing.Color.Silver;
            this.zoomin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zoomin.Image = ((System.Drawing.Image)(resources.GetObject("zoomin.Image")));
            this.zoomin.Location = new System.Drawing.Point(13, 77);
            this.zoomin.Name = "zoomin";
            this.zoomin.Size = new System.Drawing.Size(75, 23);
            this.zoomin.TabIndex = 6;
            this.zoomin.UseVisualStyleBackColor = false;
            this.zoomin.Click += new System.EventHandler(this.zoomin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.blur);
            this.panel2.Controls.Add(this.sharpen);
            this.panel2.Controls.Add(this.gray);
            this.panel2.Location = new System.Drawing.Point(200, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 70);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Silver;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(301, 24);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 3;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // blur
            // 
            this.blur.BackColor = System.Drawing.Color.Silver;
            this.blur.Image = ((System.Drawing.Image)(resources.GetObject("blur.Image")));
            this.blur.Location = new System.Drawing.Point(209, 0);
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
            this.sharpen.Location = new System.Drawing.Point(114, 0);
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
            this.gray.Location = new System.Drawing.Point(18, 0);
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
            this.panel3.Location = new System.Drawing.Point(146, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 400);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // zoomout
            // 
            this.zoomout.BackColor = System.Drawing.Color.Silver;
            this.zoomout.Image = ((System.Drawing.Image)(resources.GetObject("zoomout.Image")));
            this.zoomout.Location = new System.Drawing.Point(13, 103);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(75, 23);
            this.zoomout.TabIndex = 9;
            this.zoomout.UseVisualStyleBackColor = false;
            this.zoomout.Click += new System.EventHandler(this.zoomout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.zoomout);
            this.panel4.Controls.Add(this.zoomin);
            this.panel4.Controls.Add(this.save);
            this.panel4.Controls.Add(this.upload);
            this.panel4.Location = new System.Drawing.Point(10, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 140);
            this.panel4.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Controls.Add(this.heightlabel);
            this.panel6.Controls.Add(this.widthlabel);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.cancel);
            this.panel6.Controls.Add(this.apply);
            this.panel6.Location = new System.Drawing.Point(200, 500);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 70);
            this.panel6.TabIndex = 12;
            this.panel6.Visible = false;
            // 
            // heightlabel
            // 
            this.heightlabel.AutoSize = true;
            this.heightlabel.ForeColor = System.Drawing.Color.White;
            this.heightlabel.Location = new System.Drawing.Point(114, 38);
            this.heightlabel.Name = "heightlabel";
            this.heightlabel.Size = new System.Drawing.Size(38, 13);
            this.heightlabel.TabIndex = 9;
            this.heightlabel.Text = "Height";
            // 
            // widthlabel
            // 
            this.widthlabel.AutoSize = true;
            this.widthlabel.ForeColor = System.Drawing.Color.White;
            this.widthlabel.Location = new System.Drawing.Point(114, 9);
            this.widthlabel.Name = "widthlabel";
            this.widthlabel.Size = new System.Drawing.Size(35, 13);
            this.widthlabel.TabIndex = 8;
            this.widthlabel.Text = "Width";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // cancel
            // 
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(290, 32);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // apply
            // 
            this.apply.Image = ((System.Drawing.Image)(resources.GetObject("apply.Image")));
            this.apply.Location = new System.Drawing.Point(290, 3);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 2;
            this.apply.UseVisualStyleBackColor = true;
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
            this.redo.Location = new System.Drawing.Point(13, 64);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(75, 23);
            this.redo.TabIndex = 4;
            this.redo.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.redo);
            this.panel5.Controls.Add(this.undo);
            this.panel5.Location = new System.Drawing.Point(670, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 100);
            this.panel5.TabIndex = 11;
            // 
            // rotate
            // 
            this.rotate.BackColor = System.Drawing.Color.Black;
            this.rotate.Location = new System.Drawing.Point(84, 0);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(75, 67);
            this.rotate.TabIndex = 4;
            this.rotate.Text = "Rotate";
            this.rotate.UseVisualStyleBackColor = false;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 612);
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
        private System.Windows.Forms.Label heightlabel;
        private System.Windows.Forms.Label widthlabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button redo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button rotate;


    }
}

