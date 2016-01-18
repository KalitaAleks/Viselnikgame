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
 
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        /// <summary>
        /// Form start.
        /// </summary>
        int v;
        public Form2()
            {
            InitializeComponent();
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
        private void Button4Click(object sender, EventArgs e)
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