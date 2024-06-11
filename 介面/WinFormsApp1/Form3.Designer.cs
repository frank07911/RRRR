namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            pipedown3 = new PictureBox();
            pipeup3 = new PictureBox();
            pipedown2 = new PictureBox();
            pipeup2 = new PictureBox();
            pipedown = new PictureBox();
            pipeup = new PictureBox();
            PictureBox1 = new PictureBox();
            top = new PictureBox();
            scoretext = new Label();
            bottom = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            imageList1 = new ImageList(components);
            角色 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pipedown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)top).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottom).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 46);
            button1.Name = "button1";
            button1.Size = new Size(71, 37);
            button1.TabIndex = 2;
            button1.Text = "返回";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pipedown3
            // 
            pipedown3.Image = Properties.Resources.pipe_down___3;
            pipedown3.Location = new Point(1390, -237);
            pipedown3.Name = "pipedown3";
            pipedown3.Size = new Size(52, 320);
            pipedown3.SizeMode = PictureBoxSizeMode.AutoSize;
            pipedown3.TabIndex = 14;
            pipedown3.TabStop = false;
            // 
            // pipeup3
            // 
            pipeup3.Image = Properties.Resources.pipe_up___3;
            pipeup3.Location = new Point(1137, 386);
            pipeup3.Name = "pipeup3";
            pipeup3.Size = new Size(52, 320);
            pipeup3.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeup3.TabIndex = 13;
            pipeup3.TabStop = false;
            // 
            // pipedown2
            // 
            pipedown2.Image = Properties.Resources.pipe_down___2;
            pipedown2.Location = new Point(875, -224);
            pipedown2.Name = "pipedown2";
            pipedown2.Size = new Size(52, 320);
            pipedown2.SizeMode = PictureBoxSizeMode.AutoSize;
            pipedown2.TabIndex = 12;
            pipedown2.TabStop = false;
            // 
            // pipeup2
            // 
            pipeup2.Image = Properties.Resources.pipe_up___2;
            pipeup2.Location = new Point(473, 319);
            pipeup2.Name = "pipeup2";
            pipeup2.Size = new Size(52, 320);
            pipeup2.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeup2.TabIndex = 11;
            pipeup2.TabStop = false;
            // 
            // pipedown
            // 
            pipedown.Image = Properties.Resources.pipe_down;
            pipedown.Location = new Point(599, -190);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(52, 320);
            pipedown.SizeMode = PictureBoxSizeMode.AutoSize;
            pipedown.TabIndex = 10;
            pipedown.TabStop = false;
            // 
            // pipeup
            // 
            pipeup.Image = Properties.Resources.pipe_up;
            pipeup.Location = new Point(763, 297);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(52, 320);
            pipeup.SizeMode = PictureBoxSizeMode.AutoSize;
            pipeup.TabIndex = 9;
            pipeup.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox1.Location = new Point(69, 115);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(76, 63);
            PictureBox1.TabIndex = 15;
            PictureBox1.TabStop = false;
            // 
            // top
            // 
            top.Location = new Point(-9, -32);
            top.Name = "top";
            top.Size = new Size(354, 50);
            top.TabIndex = 17;
            top.TabStop = false;
            // 
            // scoretext
            // 
            scoretext.AutoSize = true;
            scoretext.Location = new Point(12, 386);
            scoretext.Name = "scoretext";
            scoretext.Size = new Size(42, 15);
            scoretext.TabIndex = 18;
            scoretext.Text = "label1";
            // 
            // bottom
            // 
            bottom.Location = new Point(-9, 421);
            bottom.Name = "bottom";
            bottom.Size = new Size(375, 50);
            bottom.TabIndex = 19;
            bottom.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
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
            // 角色
            // 
            角色.ColorDepth = ColorDepth.Depth8Bit;
            角色.ImageStream = (ImageListStreamer)resources.GetObject("角色.ImageStream");
            角色.TransparentColor = Color.Transparent;
            角色.Images.SetKeyName(0, "飛飛人.png");
            角色.Images.SetKeyName(1, "麥塊.png");
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1542, 450);
            Controls.Add(bottom);
            Controls.Add(scoretext);
            Controls.Add(top);
            Controls.Add(PictureBox1);
            Controls.Add(pipedown3);
            Controls.Add(pipeup3);
            Controls.Add(pipedown2);
            Controls.Add(pipeup2);
            Controls.Add(pipedown);
            Controls.Add(pipeup);
            Controls.Add(button1);
            Name = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pipedown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)top).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pipedown3;
        private PictureBox pipeup3;
        private PictureBox pipedown2;
        private PictureBox pipeup2;
        private PictureBox pipedown;
        private PictureBox pipeup;
        private PictureBox PictureBox1;
        private PictureBox top;
        private Label scoretext;
        private PictureBox bottom;
        private System.Windows.Forms.Timer timer1;
        private ImageList imageList1;
        private ImageList 角色;
    }
}