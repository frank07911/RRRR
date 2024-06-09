namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {                       
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            label2.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button2.Visible = false;
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            radioButton1.Visible = true;
            radioButton1.Visible = true;
            label2.Visible = true;
            radioButton2.Visible = true;
            button3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = true;
            button5.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton1.Visible = false;
            label2.Visible = false;
            radioButton2.Visible = false;
            button3.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            if(radioButton1.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }


    }
}