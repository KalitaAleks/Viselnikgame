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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Threading;

    /// <summary>
    /// This class contains logic of game.
    /// </summary>
    public class Game
        {
        /// <summary>
        /// Create files of words.
        /// </summary>
        public static string[] Food = File.ReadAllLines(@"Resources\FOOD.txt");

        /// <summary>
        /// Create files of words.
        /// </summary>
        public static string[] Transport = File.ReadAllLines(@"Resources\transport.txt");

        /// <summary>
        /// Create files of words.
        /// </summary>
        public static string[] Animals = File.ReadAllLines(@"Resources\animals.txt");
        /// <summary>
        ///объект рандом который  задает индекс элемента массива  Words.
        /// </summary>
        Random rand = new Random();
        /// <summary>
        /// массив индексов 
        /// </summary>
        public string[] random = new string[6];

        /// <summary>
        /// Create a letter.
        /// </summary>
        public char Letter;

        /// <summary>
        /// create counters.
        /// </summary>
        public static int RightWordsCounter = 0;
        public static int CorrectLettersCounter = 0;
        public int WrongLettersCounter = 0;
        public int WinCounter = 0;
        public int LastNumberCounter = 0;

        
        /// <summary>
        /// масив в который будет записываться массив выбраной категории.
        /// </summary>
        public static string[] words = { "" };
        
        /// <summary>
        /// //  массив символов в который будет записываться слово.
        /// </summary>
        static char[] word;
       
        /// <summary>
        ///  //  массив который будем выводить после проверки буквы.
        /// </summary>
        public char[] conclusion = "--".ToCharArray(); 
        
        /// <summary>
        /// Функция записывающая выбраное случайно и не повторяющееся с прошлыми слово в массив символов.
        /// </summary>
        public void Filiing_word()
            {
            string randm = rand.Next(0, 20).ToString();
            for (int i = 0; i < 5; i++)
                {
                if (random[i] != null)
                    {
                    if (random[i] == randm)
                        {
                        randm = rand.Next(0, 20).ToString();
                        }
                    }
                if (random[i] == null)
                    {
                    random[i] = randm;
                    word = words[Convert.ToInt32(random[RightWordsCounter])].ToCharArray();
                    break;
                    }
                }
            }

        
        int count = 0;
        /// <summary>
        /// Функция присваиваюшая длине выводимого массива длину слова и  заполняющего выводимый массив знаком "-".
        /// </summary>
        public void Filling_conclusion()
            {
            Filiing_word();
            conclusion = new char[word.Length];
            foreach (char el in conclusion)
                {
                conclusion[count] = '-';
                count++;
                }
            count = 0;
            }

        /// <summary>
        /// Функция описывающая игровой процесс.
        /// </summary>
        void Logic()
            {
            // Прошлое количество угаданных слов приравнивает к текущему количеству угаданных слов.
            LastNumberCounter = WinCounter;
            // Проводит проверку, есть ли заданная буква в слове.
            int q = 0;
            int count_word = 0;

            foreach (char elem in word)
                {
                // Если буква есть то в строку вывода добавляем в нужном месте эту букву, и счетчик правильных букв увеличиваем на количество повторений буквы в слове. 
                if (word[count_word] == Letter)
                    {
                    conclusion[count_word] = Letter;
                    CorrectLettersCounter++;
                    }
                else
                    {
                    q = q + 1; ;
                    }
                count_word++;
                }
            // Если буква не была обнаружена в слове увеличиваем счетчик неверных букв на единицу.
            if (q == word.Length)
                {
                WrongLettersCounter = WrongLettersCounter + 1; ;
                }
            // Если счетчик правильных букв равен длине слова то увеличиваем счетчики правильных слов на единицу переходим на след слово и обнуляем счетчки правильных и неправильных букв.
            if (CorrectLettersCounter == word.Length)
                {
                RightWordsCounter++;
                }

            }

        /// <summary>
        ///  Публичная функция  программы используется в формах.
        /// </summary>
        public void Start()
            {
            Logic();

            }
        }
    }
