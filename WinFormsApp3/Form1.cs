using System.Collections.Generic;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public int pcn = 2;
        int ppn = 4;
        int ppu = 6;
        int pemail = 1;
        int ptel = 2;
        int pfax = 3;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int coste = 0;
            if (rb1.Checked == true)
            {
               
                coste = coste+pcn;
                //rb1.Checked = false;
                //checkBox3.Checked = false;
            }
            if (rb2.Checked == true)
            {
                coste = coste + 4;
                //checkBox1.Checked = false;
                //checkBox3.Checked = false;
            }
            if (rb3.Checked == true)
            {
                coste = coste + 10;
                //checkBox1.Checked = false;
                //checkBox2.Checked = false;
            }

            if (checkBox4.Checked == true)
            {
                checkBox4.ThreeState = true;
                coste = coste + pemail;
            }
            if (checkBox5.Checked == true)
            {
                coste = coste + ptel;
            }
            if (checkBox6.Checked == true)
            {
                coste = coste + pfax;
            }
            //string select = (string)checkedListBox1.SelectedItem;
            tbCoste.Text = coste+" $";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbCoste_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}