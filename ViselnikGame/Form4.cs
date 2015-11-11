using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ViselnikGame
    {
    public   partial class Form4 : Form
        {


 Game   g = new Game();

        public Form4()
            {

            // Получаем название категории от кнопки из Form3.
            CallBackMy.callbackEventHandler = new CallBackMy.callbackEvent(this.Reload);
            CallBackMy2.callbackEventHandler2 = new CallBackMy2.callbackEvent2(this.Relod2);
            // Указываем сколько букв в слове.
            g.Filling_conclusion();
            InitializeComponent();
            int count = 0;
            foreach (char el in g.conclusion)
                {
                this.Controls["label"+(count+1).ToString()].Text = g.conclusion[count].ToString();
                count++;
                }
           }

        int complexity;
        void Reload(string param)
            {
            label12.Text = param;
            }

        void Relod2(int param2) 
            {
            complexity = param2;
            }
        int error_count=0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


       string z;

      


 char[] Conc = new char[10];
        private void button_clic(object sender, EventArgs e)
        { 
            // При нажатии на кнопку меняем её цвет.
       ActiveControl.BackColor = Color.Red;
            z= ActiveControl.Text;
           
            int count = 0;
           // Предаем букву в сласс Game.
             g.letter = Convert.ToChar(z);
           // Запускаем проверку буквы.
            g.Start();
            Conc = g.conclusion;
            // Выводим букву ели была нажата правильная.
             foreach (char el in Conc)
                {
                this.Controls["label" + (count+1).ToString()].Text = Conc[count].ToString();
                count++;
                }
            // Выводим кнопку перехода на следуюшее слово.
            if (g.win> g.last_number) 
                {  
                button28.Visible = true;
                }
            //Выводим каринку висельницы если была нажта неверная буква.
            pictureBox1.Image = Image.FromFile("Resources\\"+ g.wrong_letters + ".jpg");
            // Если все слова были угаданы то выводим форму для победы.
            if (g.win == Game.words.Length) 
                {
                Form8 f8 = new Form8();
                this.Hide();
                f8.Show();
                g.win = 0;
                g.wrong_letters = 0;
                Game.right_words = 0;
                }

            if (g.wrong_letters == 7)
                {
                count = 0;
                error_count++;
                g.wrong_letters = 0;
                
                if (Convert.ToInt32(complexity) == 1 && error_count <= 4)
                    {

                    g.conclusion = Game.words[Game.right_words].ToCharArray();
                    Conc = g.conclusion;

                    // Выводим букву ели была нажата правильная.
                    foreach (char el in Conc)
                        {
                        this.Controls["label" + (count + 1).ToString()].Text = Conc[count].ToString();
                        count++;
                        }
                    Game.right_words++;
                    g.win++;
                    for (int i = 2; i < 28; i++)
                        {
                        this.Controls["button" + (i).ToString()].Enabled = false;
                        }

                    button28.Visible = true;
                    }

                if (Convert.ToInt32(complexity) == 2 && error_count <= 2)
                    {
                    g.conclusion = Game.words[Game.right_words].ToCharArray();
                    Conc = g.conclusion;

                    // Выводим букву ели была нажата правильная.
                    foreach (char el in Conc)
                        {
                        this.Controls["label" + (count + 1).ToString()].Text = Conc[count].ToString();
                        count++;
                        }
                    Game.right_words++;
                    g.win++;
                    for (int i = 2; i < 28; i++)  
                        {
                        this.Controls["button" + (i).ToString()].Enabled = false;
                        }
                 
                        button28.Visible = true;
                    
                    }

                if (Convert.ToInt32(complexity) == 2 && error_count > 2 || Convert.ToInt32(complexity) == 1 && error_count > 4 || Convert.ToInt32(complexity) == 3)
                    {
                    Form6 f6 = new Form6();
                    this.Hide();
                    f6.Show();
                    g.win = 0;
                    g.wrong_letters = 0;
                    Game.right_words = 0;
                    for (int i = 2; i < 28; i++)
                        {
                        this.Controls["button" + (i).ToString()].Enabled = false;
                        }
                    }
                }
            ActiveControl.Enabled= false;

            button1.Enabled = true;
        }

       
               
            
            
       
    
        public void button_color() 
            {
            //Изменение цвета кнопок на начальный.
            for (int d = 2; d < 28; d++)
                {
                this.Controls["button" + (d).ToString()].BackColor = Color.Transparent;
                this.Controls["button" + (d).ToString()].Enabled = true;
                }
            }
    
  
       
        private void button28_Click(object sender, EventArgs e)
            {
            button28.Visible = false;
            g.Filiing_word();
            g.Filling_conclusion();
            int count = 0;
            // Указываем сколько букв в следующем слове
            foreach (char el in g.conclusion)
                {
                this.Controls["label" +(count+1).ToString()].Text = g.conclusion[count].ToString();
                count++;
                }
            for (int i = g.conclusion.Length + 1; i < 11; i++) 
                {
                this.Controls["label" + i.ToString()].Text = "";
                }
            //Возвращаем картинку в начальное положение
            pictureBox1.Image = Image.FromFile(@"Resources\0.jpg");
            button_color();
            
            }

        private void button1_Click(object sender, EventArgs e)
            {

            Game.right_words = 0;
            g.last_number = 0;
            g.wrong_letters = 0;
            Game.correct_letters = 0;
            // Переход на форму назад.
            Form3 f3 = new Form3();
            this.Close();
            f3.Show();
            }


      


        


        
        }
    }
        
    
