﻿//<copyright file="Form2.cs" company="OmGTU"> 
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
                this.Controls["Button" + i.ToString()].Left = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.X * kWidth);
                this.Controls["Button" + i.ToString()].Top = Convert.ToUInt16(this.Controls["Button" + i.ToString()].Location.Y * kHeght);
                NewButtonWidth = 0;
                NewButtonHeght = 0;
                }
            if (W == 1600) { this.BackgroundImage = Image.FromFile(@"Resources\Bg1_1600_900.jpg");}
            else if (W == 1400) { this.BackgroundImage = Image.FromFile(@"Resources\Bg1_1400_900.jpg"); }
            else if (W == 1366) { this.BackgroundImage = Image.FromFile(@"Resources\Bg1_1366_768.jpg"); }
            else if (W == 1360) { this.BackgroundImage = Image.FromFile(@"Resources\Bg1_1360_768.jpg"); }
            else if (W == 1280) { this.BackgroundImage = Image.FromFile(@"Resources\Bg1_1280_800.jpg"); }
            else if (W < 1280) { this.BackgroundImage = Image.FromFile(@"Resources\Bg1_1280_800.jpg"); }
            else if (W > 1600) { this.BackgroundImage = Image.FromFile(@"Resources\Bg1_1600_900.jpg"); }
          
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
            f3.Opacity = 0;
            f3.Show();
           for (int i = 0; i <= 100; i++)
                {
               f3.Opacity = i / 100.0;
               System.Threading.Thread.Sleep(1);//чем меньше число, тем быстрее появится
                }
            this.Hide();
           
            }

        /// <summary>
        /// Transition to the form with the inquiry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3Click(object sender, EventArgs e)
            {
            Form5 f5 = new Form5();
            f5.Opacity = 0;
            f5.Show();
            for (int i = 0; i <= 100; i++)
                {
                f5.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);//чем меньше число, тем быстрее появится
                }
            Hide();
                       
            }
            }
        }
    
