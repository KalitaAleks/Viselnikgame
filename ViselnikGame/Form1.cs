namespace OmGTU.Advance.Profit.Loyal.ViselnikGame
    {
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void button2_Click(object sender, EventArgs e)
            {
            Form2 f2 = new Form2();
            Form4 f4=new Form4();   
            f2.Opacity = 0;
            f2.Show();
            for (int i = 0; i <= 100; i++)
                {
                f2.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);//чем меньше число, тем быстрее появится
                }
         this.Close();
            f4.Close();
            

            }

        private void button3_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }
        }
    }
