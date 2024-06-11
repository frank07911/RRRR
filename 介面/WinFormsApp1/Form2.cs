using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            PictureBox1.Top = 150;
        }
        int score = 0;
        int pipespeed = 15;




        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form1.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                timer1.Start();
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox1.Top += 10;
            pipeup.Left -= pipespeed;
            pipedown.Left -= pipespeed;
            pipeup2.Left -= pipespeed;
            pipedown2.Left -= pipespeed;
            pipeup3.Left -= pipespeed;
            pipedown3.Left -= pipespeed;

            scoretext.Text = "分數:" + score;


            if (pipeup.Left < -50)
            {
                pipeup.Left = 1340;
                score++;
            }
            if (pipedown.Left < -50)
            {
                pipedown.Left = 1340;
                score++;
            }
            if (pipeup2.Left < -50)
            {
                pipeup2.Left = 1340;
                score++;
            }
            if (pipedown2.Left < -50)
            {
                pipedown2.Left = 1340;
                score++;
            }
            if (pipeup3.Left < -50)
            {
                pipeup3.Left = 1340;
                score++;
            }
            if (pipedown3.Left < -50)
            {
                pipedown3.Left = 1340;
                score++;
            }

            if (PictureBox1.Bounds.IntersectsWith(pipeup.Bounds) || PictureBox1.Bounds.IntersectsWith(pipedown.Bounds) || PictureBox1.Bounds.IntersectsWith(pipeup2.Bounds) || PictureBox1.Bounds.IntersectsWith(pipedown2.Bounds) || PictureBox1.Bounds.IntersectsWith(pipeup3.Bounds) || PictureBox1.Bounds.IntersectsWith(pipedown3.Bounds))
            {
                endGame();
            }
            if (PictureBox1.Bounds.IntersectsWith(top.Bounds) || PictureBox1.Bounds.IntersectsWith(bottom.Bounds))
            {
                endGame();
            }
        }
        private void endGame()
        {
            timer1.Stop();
            scoretext.Text += "遊戲結束";
            MessageBox.Show("遊戲結束\n你的分數為" + score);
            button1.Enabled = true;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void top_Click(object sender, EventArgs e)
        {

        }

        private void bottom_Click(object sender, EventArgs e)
        {

        }

        private void pipedown_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
