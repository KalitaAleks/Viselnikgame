//<copyright file="CallBack.cs" company="OmGTU"> 
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

    /// <summary>
    /// This class returns a line with the name of a category from the form with a choice of categories.
    /// </summary>
    public static class CallBack
        {
        /// <summary>
        ///  Returns a line with the name of a category from the form with a choice of categories.
        /// </summary>
        /// <param name="what"></param>
        public delegate void CallBackEvent(string what);

        /// <summary>
        /// Contains returned value
        /// </summary>
        public static CallBackEvent CallBackEventHandler;

        /// <summary>
        /// Returns value of complexity.
        /// </summary>
        /// <param name="what"></param>
        public delegate void CallBackEvent2(int what);

        /// <summary>
        ///  Contains returned value
        /// </summary>
        public static CallBackEvent2 CallBackEventHandler2;

        public delegate void CallBackEvent3(string[] what);
        public static CallBackEvent3 CallBackEventHandler3;
        }
    }
