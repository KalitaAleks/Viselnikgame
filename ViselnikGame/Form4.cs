//<copyright file="Form4.cs" company="OmGTU"> 
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
    using System.Threading;
    using System.Threading.Tasks; 
    using System.Windows.Forms;
  
    /// <summary>
    /// Copy of a class of the form.
    /// </summary>      

    public partial class Form4 : Form
        {

        private void FormResize()
            {
            double W = (int)(Screen.PrimaryScreen.Bounds.Width);
            double H = (int)(Screen.PrimaryScreen.Bounds.Height);
            double kWidth = W / 1292;
            double kHeght = H / 732;
            this.Width = Convert.ToInt32(W);
            this.Height = Convert.ToInt32(H);
         int ww = Convert.ToUInt16(Convert.ToUInt16(this.pictureBox1.Width / 1.37)*kWidth);
         int wh = Convert.ToUInt16(Convert.ToUInt16(this.pictureBox1.Height / 1.216)*kHeght);
         this.pictureBox1.Width = ww;
         this.pictureBox1.Height = wh;
         this.pictureBox1.Left = Convert.ToUInt16(pictureBox1.Location.X * kWidth);
         this.pictureBox1.Top = Convert.ToUInt16(pictureBox1.Location.Y * kHeght);  
            for (int i = 1; i <= 28; i++)
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

            if (W == 1600) { this.BackgroundImage = Image.FromFile(@"Resources\G1600.jpg"); }
            else if (W == 1400) { this.BackgroundImage = Image.FromFile(@"Resources\G1400.jpg"); }
            else if (W == 1366) { this.BackgroundImage = Image.FromFile(@"Resources\G1366.jpg"); }
            else if (W == 1360) { this.BackgroundImage = Image.FromFile(@"Resources\G1360.jpg"); }
            else if (W != 1600 || W != 1400 || W != 1366 || W != 1360) { this.BackgroundImage = Image.FromFile(@"Resources\G1280.jpg"); }
            }


        /// <summary>
        /// Copy of class Game.
        /// </summary>
        Game g = new Game();
        /// <summary>
        ///  Form start.
        /// </summary>
        public Form4()
            {
            //receive the name of a category from the button from Form3.
            CallBack.CallBackEventHandler = new CallBack.CallBackEvent(this.Reload);

            //receive value of complexity from Form9.
            CallBack.CallBackEventHandler2 = new CallBack.CallBackEvent2(this.Relod2);

            //specify how many letters in a word.
            g.Filling_conclusion();
            InitializeComponent();
            int count = 0;
            foreach (char el in g.conclusion)
                {
                this.Controls["label" + (count + 1).ToString()].Text = g.conclusion[count].ToString();
                count++;
                }
            FormResize();
            }

        /// <summary>
        /// Variable containing complexity.
        /// </summary>
        int complexity;

        /// <summary>
        /// create error counter.
        /// </summary>
        int errorCount = 0;

        /// <summary>
        /// Line receiving value of a letter.
        /// </summary>
        string z;

        /// <summary>
        /// Line showing what letters are guessed and how many all letters in a word.
        /// </summary>
        char[] conc = new char[10];

        /// <summary>
        /// Change of color of buttons on the initial.
        /// </summary>
        public void ButtonColor()
            {
            for (int d = 2; d < 28; d++)
                {
                this.Controls["button" + (d).ToString()].BackColor = Color.Transparent;
                this.Controls["button" + (d).ToString()].Enabled = true;
                }
            }

        /// <summary>
        /// Function starting letter check on correctness.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClic(object sender, EventArgs e)
            {
            // By pressing the button its colour is changed.
            ActiveControl.BackColor = Color.DarkRed;

            //Receive value of a letter
            z = ActiveControl.Text;
            int count = 0;

            // We betray a letter in сласс Game.
            g.Letter = Convert.ToChar(z);

            // We start letter check.
            g.Start();
            conc = g.conclusion;

            // We remove a fur-tree letter the correct has been pressed.
            foreach (char el in conc)
                {
                this.Controls["label" + (count + 1).ToString()].Text = conc[count].ToString();
                count++;
                }

            // We remove the transition button on следуюшее a word.
            if (Game.CorrectLettersCounter==g.conclusion.Length && Game.RightWordsCounter+errorCount<=5)
                {
                for (int i = 2; i < 28; i++)
                    {
                    this.Controls["button" + (i).ToString()].Enabled = false;
                    }
                button28.Visible = true;
                }

            //We remove a gallows picture if there was press an incorrect letter.
            if (g.WrongLettersCounter != 0)
                {
                pictureBox1.Image = Image.FromFile(@"Resources\" + g.WrongLettersCounter + ".jpg");
                }

            if (g.WrongLettersCounter == 0)
                {
                pictureBox1.Image = null;
                }
            if (g.WrongLettersCounter == 7 )
                {
                count = 0;
                errorCount++;
                g.WrongLettersCounter = 0;
                if (Convert.ToInt32(complexity) == 1 && errorCount <= 4)
                    {
                    g.conclusion = g.Words[Convert.ToInt32(g.random[g.index])].ToCharArray();
                    conc = g.conclusion;

                    // We remove a fur-tree letter the correct has been pressed.
                    foreach (char el in conc)
                        {
                        this.Controls["label" + (count + 1).ToString()].Text = conc[count].ToString();
                        count++;
                        }

                    for (int i = 2; i < 28; i++)
                        {
                        this.Controls["button" + (i).ToString()].Enabled = false;
                        }

                    button28.Visible = true;
                    }

                if (Convert.ToInt32(complexity) == 2 && errorCount <= 2)
                    {
                    g.conclusion = g.Words[Convert.ToInt32(g.random[g.index])].ToCharArray();
                    conc = g.conclusion;

                    // We remove a fur-tree letter the correct has been pressed.
                    foreach (char el in conc)
                        {
                        this.Controls["label" + (count + 1).ToString()].Text = conc[count].ToString();
                        count++;
                        }

                    
                    for (int i = 2; i < 28; i++)
                        {
                        this.Controls["button" + (i).ToString()].Enabled = false;
                        }

                    button28.Visible = true;
                    }

                if ((Convert.ToInt32(complexity) == 2 && errorCount > 2) || (Convert.ToInt32(complexity) == 1 && errorCount > 4) || (Convert.ToInt32(complexity) == 3))
                    {
                    Form6 f6 = new Form6();
                    this.Hide();
                    f6.Show();
                    g.WinCounter = 0;
                    g.WrongLettersCounter = 0;
                    Game.RightWordsCounter = 0;
                    for (int i = 2; i < 28; i++)
                        {
                        this.Controls["button" + (i).ToString()].Enabled = false;
                        }
                    }
                }
           
                label13.Text = "Guess words: " + (Game.RightWordsCounter).ToString();
            label14.Text = "Not guess the word: " + errorCount.ToString();
            ActiveControl.Enabled = false;
            button1.Enabled = true;
            }

        /// <summary>
        /// Transition to a following word.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button28Click(object sender, EventArgs e)
            {
            g.WinCounter++;
            button28.Visible = false;
            g.Filling_conclusion();
            g.WrongLettersCounter = 0;
            Game.CorrectLettersCounter = 0;
            int count = 0;

            // We specify how many letters in a following word.
            foreach (char el in g.conclusion)
                {
                this.Controls["label" + (count + 1).ToString()].Text = g.conclusion[count].ToString();
                count++;
                }

            for (int i = g.conclusion.Length + 1; i < 11; i++)
                {
                this.Controls["label" + i.ToString()].Text = " ";
                }

            //We return a picture in initial position.
            pictureBox1.Image=null;
            ButtonColor();     
            // If all words have been guessed that we remove the form for a victory.
            if (g.WinCounter == 5)
                {
                Form8 f8 = new Form8();
                this.Hide();
                f8.Show();
                g.WinCounter = 0;
                g.WrongLettersCounter = 0;
                Game.RightWordsCounter = 0;
                }
            }

        /// <summary>
        /// Return on the form with a category choice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Click(object sender, EventArgs e)
            {
            Game.RightWordsCounter = 0;
            g.LastNumberCounter = 0;
            g.WrongLettersCounter = 0;
            Game.CorrectLettersCounter = 0;

            // Transition to the form back.
            Form3 f3 = new Form3();
            this.Close();
            f3.Show();
            }

        /// <summary>
        /// Conclusion of the name of a category.
        /// </summary>
        /// <param name="param"></param>
        void Reload(string param)
            {
            label12.Text = param;
            }

        /// <summary>
        /// Record of value of complexity.
        /// </summary>
        /// <param name="param2"></param>
        void Relod2(int param2)
            {
            complexity = param2;
            }
        }
    }
