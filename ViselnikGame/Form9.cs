﻿//<copyright file="Form9.cs" company="OmGTU"> 
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
    public partial class Form9 : Form
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
                this.Controls["Button" + i.ToString()].Left = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.X * kWidth);
                this.Controls["Button" + i.ToString()].Top = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.Y * kHeght);
                NewButtonWidth = 0;
                NewButtonHeght = 0;
                }


            if (W == 1600) { this.BackgroundImage = Image.FromFile(@"Resources\PC1600.jpg"); }
            else if (W == 1400) { this.BackgroundImage = Image.FromFile(@"Resources\PC1400.jpg"); }
            else if (W == 1366) { this.BackgroundImage = Image.FromFile(@"Resources\PC1366.jpg"); }
            else if (W == 1360) { this.BackgroundImage = Image.FromFile(@"Resources\PC1360.jpg"); }
            else if (W != 1600 || W != 1400 || W != 1366 || W != 1360) { this.BackgroundImage = Image.FromFile(@"Resources\PC1280.jpg"); }
            }
        /// <summary>
        /// Form start.
        /// </summary>
        public Form9()
            {
            InitializeComponent();
            FormResize();
            }

        /// <summary>
        /// Variable containing value of complexity.
        /// </summary>
        public int Complexity = 0;

        /// <summary>
        /// Line containing the category name.
        /// </summary>
        public string Categories;

        /// <summary>
        /// Copy of class Form4.
        /// </summary>
        Form4 frm4 = new Form4();

        /// <summary>
        /// Transition to the form with game, with easy complexity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Click(object sender, EventArgs e)
            {
            Complexity = 1;
            CallBack.CallBackEventHandler2(Complexity);
            CallBack.CallBackEventHandler(Categories);
            this.Hide();
            frm4.Show();
            }

        /// <summary>
        /// Transition to the form with game, with average complexity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2Click(object sender, EventArgs e)
            {
            Complexity = 2;
            CallBack.CallBackEventHandler2(Complexity);
            this.Hide();
            frm4.Show();
            }

        /// <summary>
        /// Transition to the form with game, with heavy complexity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3Click(object sender, EventArgs e)
            {
            Complexity = 3;
            CallBack.CallBackEventHandler2(Complexity);
            this.Hide();
            frm4.Show();
            }

        private void button4_Click(object sender, EventArgs e)
            {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
            }
        }
    }
