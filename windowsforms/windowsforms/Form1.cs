using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled=false;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            try_catch(progressBar1,10);
            try_catch0(progressBar2,progressBar3);
            //progressBar2.Value -= 5;
            //progressBar3.Value -= 5;

        }
        public static ProgressBar try_catch(ProgressBar progressbarr,int x
            )
        {
            try
            {
                MessageBox.Show((progressbarr.Value+=x).ToString());
                
            }
            catch(Exception)
            {
                MessageBox.Show((progressbarr.Value=100).ToString());
            }          
            return progressbarr;
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try_catch(progressBar2,10);
            try_catch0(progressBar1,progressBar3);           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try_catch(progressBar3, 10);
            try_catch0(progressBar1,progressBar2);
        }
        public static void try_catch0(ProgressBar progress1,ProgressBar progress2)
        {
            try
            {
                progress1.Value -= 5;
                progress2.Value -= 5;
            }
            catch(Exception)
            {
                progress1.Value=0;
                progress2.Value = 0;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value>30)
            {
                label4.Text = "сыт";
            }
            else if (progressBar1.Value<30 &&progressBar1.Value>15)
            {
                label4.Text = "голоден";
            }
            else
            {
                label4.Text = "ща умрёт";
            }
        }

        public static void check(ProgressBar progressBar1)
        {
            
            if (progressBar1.Value > 30)
            {
                label4.Text = "сыт";
            }
            else if (progressBar1.Value < 30 && progressBar1.Value > 15)
            {
                label4.Text = "голоден";
            }
            else
            {
                label4.Text = "ща умрёт";
            }
        }
    }
}
