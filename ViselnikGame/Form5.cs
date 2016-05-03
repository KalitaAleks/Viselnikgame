//<copyright file="Form5.cs" company="OmGTU"> 
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
    public partial class Form5 : Form
        {
        private void FormResize()
            {
            double W = (int)(Screen.PrimaryScreen.Bounds.Width);
            double H = (int)(Screen.PrimaryScreen.Bounds.Height);
            double kWidth = W / 1292;
            double kHeght = H / 732;
            this.Width = Convert.ToInt32(W);
            this.Height = Convert.ToInt32(H);


            for (int i = 1; i <= 1; i++)
                {
                int NewButtonWidth = Convert.ToInt32(Convert.ToInt32(this.Controls["Button" + i.ToString()].Width / 1.991) * kWidth);
                this.Controls["Button" + i.ToString()].Width = NewButtonWidth;
                int NewButtonHeght = Convert.ToInt32(Convert.ToInt32(this.Controls["Button" + i.ToString()].Height / 3.3) * kHeght);
                this.Controls["Button" + i.ToString()].Height = NewButtonHeght;
                this.Controls["Button" + i.ToString()].Left = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.X * kWidth);
                this.Controls["Button" + i.ToString()].Top = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.Y * kHeght);
                NewButtonWidth = 0;
                NewButtonHeght = 0;
                }
            if (W == 1600) { this.BackgroundImage = Image.FromFile(@"Resources\spravka_1600.jpg"); }
            else if (W == 1400) { this.BackgroundImage = Image.FromFile(@"Resources\spravka_1400.jpg"); }
            else if (W == 1366) { this.BackgroundImage = Image.FromFile(@"Resources\spravka_1366.jpg"); }
            else if (W == 1360) { this.BackgroundImage = Image.FromFile(@"Resources\spravka_1360.jpg"); }
            else if (W != 1600 || W != 1400 || W != 1366 || W != 1360) { this.BackgroundImage = Image.FromFile(@"Resources\FON_2_1280.jpg"); }
            }
        /// <summary>
        ///  Form start.
        /// </summary>
        public Form5()
            {
            InitializeComponent();
            FormResize();
            }

        /// <summary>
        /// Transition to the form back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Click(object sender, EventArgs e)
            {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            }
        }
    }
