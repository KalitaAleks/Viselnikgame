//<copyright file="Form2.cs" company="OmGTU"> 
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
    public partial class Form2 : Form
        {
        private void FormResize()
            {
            double W = (int)(Screen.PrimaryScreen.Bounds.Width);
            double H = (int)(Screen.PrimaryScreen.Bounds.Height);
            double kWidth = W / 1292;
            double kHeght = H / 732;
            this.Width=Convert.ToInt32(W);
            this.Height=Convert.ToInt32(H);
           
            
            for (int i = 1; i <= 3; i++)
                {
                int NewButtonWidth = Convert.ToInt32(Convert.ToInt32(this.Controls["Button" + i.ToString()].Width/1.991)* kWidth);
                this.Controls["Button" + i.ToString()].Width = NewButtonWidth;
                int NewButtonHeght = Convert.ToInt32(Convert.ToInt32(this.Controls["Button" + i.ToString()].Height/3.3) * kHeght);
                this.Controls["Button" + i.ToString()].Height = NewButtonHeght;
                string lok=Convert.ToString(this.Controls["Button" + i.ToString()].Location);
                int NewButtonLocationX = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.X*kWidth);
                int NewButtonLocationY = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.Y * kHeght);
                this.Controls["Button" + i.ToString()].Location.Offset(NewButtonLocationX, NewButtonLocationY);
                string lok1 = Convert.ToString(this.Controls["Button" + i.ToString()].Location);
                NewButtonWidth = 0;
                NewButtonHeght = 0;
                }
            }
     
       /// <summary>
       /// Form start.
       /// </summary>
        public Form2()
            {
            InitializeComponent();
            FormResize();
            }

          
        /// <summary>
        ///  Exit from the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        /// <summary>
        ///  Transition to the form of a choice of a category for game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2Click(object sender, EventArgs e)
            {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
            }

        /// <summary>
        /// Transition to the form with the inquiry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3Click(object sender, EventArgs e)
            {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();

            }
            }
        }
    
