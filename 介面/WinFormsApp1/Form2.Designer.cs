namespace WinFormsApp1
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            PictureBox1 = new PictureBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            imageList1 = new ImageList(components);
            pipeup = new PictureBox();
            pipedown = new PictureBox();
            pipeup2 = new PictureBox();
            pipedown2 = new PictureBox();
            pipeup3 = new PictureBox();
            pipedown3 = new PictureBox();
            scoretext = new Label();
            top = new PictureBox();
            bottom = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottom).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox1.Location = new Point(34, 195);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(97, 84);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            PictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(6, 6);
            button1.Name = "button1";
            button1.Size = new Size(71, 37);
            button1.TabIndex = 1;
            button1.Text = "返回";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-9, 430);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(822, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "pipe_up.png");
            imageList1.Images.SetKeyName(1, "pipe_down.png");
            imageList1.Images.SetKeyName(2, "pipe_up - 2.png");
            imageList1.Images.SetKeyName(3, "pipe_down - 2.png");
            imageList1.Images.SetKeyName(4, "pipe_up - 3.png");
            imageList1.Images.SetKeyName(5, "pipe_down - 3.png");
            // 
            // pipeup
            // 
            pipeup.Image = Properties.Resources.pipe_up;
            pipeup.Location = new Point(261, 331);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(52, 320);
            pipeup.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeup.TabIndex = 3;
            pipeup.TabStop = false;
            pipeup.Click += pictureBox3_Click;
            // 
            // pipedown
            // 
            pipedown.Image = Properties.Resources.pipe_down;
            pipedown.Location = new Point(261, -120);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(52, 320);
            pipedown.SizeMode = PictureBoxSizeMode.AutoSize;
            pipedown.TabIndex = 4;
            pipedown.TabStop = false;
            // 
            // pipeup2
            // 
            pipeup2.Image = Properties.Resources.pipe_up___2;
            pipeup2.Location = new Point(475, 356);
            pipeup2.Name = "pipeup2";
            pipeup2.Size = new Size(52, 320);
            pipeup2.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeup2.TabIndex = 5;
            pipeup2.TabStop = false;
            // 
            // pipedown2
            // 
            pipedown2.Image = Properties.Resources.pipe_down___2;
            pipedown2.Location = new Point(475, -141);
            pipedown2.Name = "pipedown2";
            pipedown2.Size = new Size(52, 320);
            pipedown2.SizeMode = PictureBoxSizeMode.AutoSize;
            pipedown2.TabIndex = 6;
            pipedown2.TabStop = false;
            // 
            // pipeup3
            // 
            pipeup3.Image = Properties.Resources.pipe_up___3;
            pipeup3.Location = new Point(690, 291);
            pipeup3.Name = "pipeup3";
            pipeup3.Size = new Size(52, 320);
            pipeup3.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeup3.TabIndex = 7;
            pipeup3.TabStop = false;
            // 
            // pipedown3
            // 
            pipedown3.Image = Properties.Resources.pipe_down___3;
            pipedown3.Location = new Point(690, -81);
            pipedown3.Name = "pipedown3";
            pipedown3.Size = new Size(52, 320);
            pipedown3.SizeMode = PictureBoxSizeMode.AutoSize;
            pipedown3.TabIndex = 8;
            pipedown3.TabStop = false;
            // 
            // scoretext
            // 
            scoretext.AutoSize = true;
            scoretext.Location = new Point(101, 406);
            scoretext.Name = "scoretext";
            scoretext.Size = new Size(42, 15);
            scoretext.TabIndex = 9;
            scoretext.Text = "label1";
            // 
            // top
            // 
            top.Location = new Point(97, 104);
            top.Name = "top";
            top.Size = new Size(100, 50);
            top.TabIndex = 10;
            top.TabStop = false;
            // 
            // bottom
            // 
            bottom.Location = new Point(88, 358);
            bottom.Name = "bottom";
            bottom.Size = new Size(100, 50);
            bottom.TabIndex = 11;
            bottom.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 450);
            Controls.Add(bottom);
            Controls.Add(top);
            Controls.Add(scoretext);
            Controls.Add(pipedown3);
            Controls.Add(pipeup3);
            Controls.Add(pipedown2);
            Controls.Add(pipeup2);
            Controls.Add(pipedown);
            Controls.Add(pipeup);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(PictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            KeyPress += Form2_KeyPress;
            KeyUp += Form2_KeyUp;
            PreviewKeyDown += Form2_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)top).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureBox1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private ImageList imageList1;
        private PictureBox pipeup;
        private PictureBox pipedown;
        private PictureBox pipeup2;
        private PictureBox pipedown2;
        private PictureBox pipeup3;
        private PictureBox pipedown3;
        private Label scoretext;
        private PictureBox top;
        private PictureBox bottom;
    }
}