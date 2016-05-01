//<copyright file="Form3.cs" company="OmGTU"> 
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
    ///  Copy of a class of the form.
    /// </summary>
    public partial class Form3 : Form
        {
        private void FormResize()
            {
            double W = (int)(Screen.PrimaryScreen.Bounds.Width);
            double H = (int)(Screen.PrimaryScreen.Bounds.Height);
            double kWidth = W / 1292;
            double kHeght = H / 732;
            this.Width = Convert.ToInt32(W);
            this.Height = Convert.ToInt32(H);


            for (int i = 1; i <= 4; i++)
                {
                int NewButtonWidth = Convert.ToInt32(Convert.ToInt32(this.Controls["Button" + i.ToString()].Width / 1.991) * kWidth);
                this.Controls["Button" + i.ToString()].Width = NewButtonWidth;
                int NewButtonHeght = Convert.ToInt32(Convert.ToInt32(this.Controls["Button" + i.ToString()].Height / 3.3) * kHeght);
                this.Controls["Button" + i.ToString()].Height = NewButtonHeght;
                int NewButtonLocationX = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.X * kWidth);
                int NewButtonLocationY = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.Y * kHeght);
                NewButtonWidth = 0;
                NewButtonHeght = 0;
                }
            }
        /// <summary>
        ///  Form start.
        /// </summary>
        public Form3()
            {
            InitializeComponent();
            FormResize();
            }

        /// <summary>
        ///  Line in which we place the category name.
        /// </summary>
        public string D;

        /// <summary>
        /// Function of a choice of a category and transition to the form with a complexity choice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Categories(object sender, EventArgs e)
            {
            D = ActiveControl.Text;
            Game.category = D;
            Form9 frm9 = new Form9();
            frm9.Categories = D;
            this.Hide();
            frm9.Show();
            }

        /// <summary>
        /// Transition to the previous form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4Click(object sender, EventArgs e)
            {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            }
        }
    }
