//<copyright file="Form8.cs" company="OmGTU"> 
//Copyright (c) OmGTU. All rights reserved.
//</copyright> 
//<author>
//Kalita Aleksandr, Valyn Ivan, Loshchinina Tatyana
//</author> 
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

    /// <summary>
    /// Copy of a class of the form.
    /// </summary>
    public partial class Form8 : Form
        {

        private void FormResize()
            {
            double W = (int)(Screen.PrimaryScreen.Bounds.Width);
            double H = (int)(Screen.PrimaryScreen.Bounds.Height);
            double kWidth = W / 1292;
            double kHeght = H / 732;
            this.Width = Convert.ToInt32(W);
            this.Height = Convert.ToInt32(H);
            this.pictureBox1.Left = Convert.ToUInt16(pictureBox1.Location.X * kWidth);
            this.pictureBox1.Top = Convert.ToUInt16(pictureBox1.Location.Y * kHeght);
            this.label1.Left = Convert.ToUInt16(label1.Location.X * kWidth);
            this.label1.Left = Convert.ToUInt16(label1.Location.Y * kHeght);
                int NewButtonWidth = Convert.ToInt32(Convert.ToInt32(this.Controls["Button" + 1.ToString()].Width / 1.991) * kWidth);
                this.Controls["Button" + 1.ToString()].Width = NewButtonWidth;
                int NewButtonHeght = Convert.ToInt32(Convert.ToInt32(this.Controls["Button" + 1.ToString()].Height / 3.3) * kHeght);
                this.Controls["Button" + 1.ToString()].Height = NewButtonHeght;
                this.Controls["Button" + 1.ToString()].Left = Convert.ToUInt16(this.Controls["Button" + 1.ToString()].Location.X * kWidth);
                this.Controls["Button" + 1.ToString()].Top = Convert.ToUInt16(this.Controls["Button" + 1.ToString()].Location.Y * kHeght);
                NewButtonWidth = 0;
                NewButtonHeght = 0;


                if (W == 1600) { this.BackgroundImage = Image.FromFile(@"Resources\1600.jpg"); }
                else if (W == 1400) { this.BackgroundImage = Image.FromFile(@"Resources\1400.jpg"); }
                else if (W == 1366) { this.BackgroundImage = Image.FromFile(@"Resources\1366.jpg"); }
                else if (W == 1360) { this.BackgroundImage = Image.FromFile(@"Resources\1360.jpg"); }
                else if (W != 1600 || W != 1400 || W != 1366 || W != 1360) { this.BackgroundImage = Image.FromFile(@"Resources\FON_2_1280.jpg"); }
            }
        /// <summary>
        /// Form start.
        /// </summary>
        public Form8()
            {
            InitializeComponent();
            FormResize();
            }

        /// <summary>
        /// Transition to the form of a choice of categories.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Click(object sender, EventArgs e)
            {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
            }
        }
    }
