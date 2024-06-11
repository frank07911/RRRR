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
            imageList1 = new ImageList(components);
            pipeup = new PictureBox();
            pipedown = new PictureBox();
            pipeup2 = new PictureBox();
            pipedown2 = new PictureBox();
            pipeup3 = new PictureBox();
            pipedown3 = new PictureBox();
            scoretext = new Label();
            bottom = new PictureBox();
            角色 = new ImageList(components);
            top = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox1.Location = new Point(19, 60);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(58, 49);
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
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
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
            pipeup.Location = new Point(813, 369);
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
            pipedown.Location = new Point(666, -194);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(52, 320);
            pipedown.SizeMode = PictureBoxSizeMode.AutoSize;
            pipedown.TabIndex = 4;
            pipedown.TabStop = false;
            pipedown.Click += pipedown_Click;
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
            pipedown2.Location = new Point(933, -245);
            pipedown2.Name = "pipedown2";
            pipedown2.Size = new Size(52, 320);
            pipedown2.SizeMode = PictureBoxSizeMode.AutoSize;
            pipedown2.TabIndex = 6;
            pipedown2.TabStop = false;
            // 
            // pipeup3
            // 
            pipeup3.Image = Properties.Resources.pipe_up___3;
            pipeup3.Location = new Point(1163, 338);
            pipeup3.Name = "pipeup3";
            pipeup3.Size = new Size(52, 320);
            pipeup3.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeup3.TabIndex = 7;
            pipeup3.TabStop = false;
            // 
            // pipedown3
            // 
            pipedown3.Image = Properties.Resources.pipe_down___3;
            pipedown3.Location = new Point(1263, -211);
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
            // bottom
            // 
            bottom.Location = new Point(-2, 433);
            bottom.Name = "bottom";
            bottom.Size = new Size(100, 50);
            bottom.TabIndex = 11;
            bottom.TabStop = false;
            bottom.Click += bottom_Click;
            // 
            // 角色
            // 
            角色.ColorDepth = ColorDepth.Depth8Bit;
            角色.ImageStream = (ImageListStreamer)resources.GetObject("角色.ImageStream");
            角色.TransparentColor = Color.Transparent;
            角色.Images.SetKeyName(0, "飛飛人.png");
            角色.Images.SetKeyName(1, "麥塊.png");
            // 
            // top
            // 
            top.Location = new Point(6, -42);
            top.Name = "top";
            top.Size = new Size(354, 50);
            top.TabIndex = 10;
            top.TabStop = false;
            top.Click += top_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-15, 424);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(822, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1520, 450);
            Controls.Add(scoretext);
            Controls.Add(pipedown3);
            Controls.Add(pipeup3);
            Controls.Add(pipedown2);
            Controls.Add(pipeup2);
            Controls.Add(pipedown);
            Controls.Add(pipeup);
            Controls.Add(button1);
            Controls.Add(PictureBox1);
            Controls.Add(bottom);
            Controls.Add(pictureBox2);
            Controls.Add(top);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            KeyDown += Form2_KeyDown;
            KeyPress += Form2_KeyPress;
            KeyUp += Form2_KeyUp;
            PreviewKeyDown += Form2_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)top).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureBox1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private ImageList imageList1;
        private PictureBox pipeup;
        private PictureBox pipedown;
        private PictureBox pipeup2;
        private PictureBox pipedown2;
        private PictureBox pipeup3;
        private PictureBox pipedown3;
        private Label scoretext;
        private PictureBox bottom;
        private ImageList 角色;
        private PictureBox top;
        private PictureBox pictureBox2;
    }
}