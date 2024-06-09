namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(267, 177);
            button1.Name = "button1";
            button1.Size = new Size(280, 72);
            button1.TabIndex = 0;
            button1.Text = "開始遊戲";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(179, 89);
            label1.Name = "label1";
            label1.Size = new Size(439, 85);
            label1.TabIndex = 1;
            label1.Text = "歐鎧爾帶你飛";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(23, 11);
            button2.Name = "button2";
            button2.Size = new Size(84, 44);
            button2.TabIndex = 2;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(280, 193);
            button3.Name = "button3";
            button3.Size = new Size(256, 47);
            button3.TabIndex = 3;
            button3.Text = "單人遊戲";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(280, 255);
            button4.Name = "button4";
            button4.Size = new Size(256, 47);
            button4.TabIndex = 4;
            button4.Text = "多人遊戲";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(23, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 107);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(21, 306);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 89);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(168, 222);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 32);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "角色1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(168, 333);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 32);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "角色2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 123);
            label2.Name = "label2";
            label2.Size = new Size(123, 35);
            label2.TabIndex = 9;
            label2.Text = "選擇角色";
            label2.Click += label2_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(23, 11);
            button5.Name = "button5";
            button5.Size = new Size(84, 44);
            button5.TabIndex = 10;
            button5.Text = "返回";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(340, 237);
            button6.Name = "button6";
            button6.Size = new Size(131, 47);
            button6.TabIndex = 11;
            button6.Text = "開始遊戲";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Button button5;
        private Button button6;
    }
}