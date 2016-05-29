using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OmGTU.Advance.Profit.Loyal.ViselnikGame;
namespace UnitTestProject1
    {
    [TestClass]
    public class UnitTest1
        {
        [TestMethod]
        public void Entering_letters()
            {
            Game g = new Game();
            g.Filling_conclusion();
            g.Letter = 'S';
            g.Start();
            Assert.AreEqual(g.conclusion.ToString(), "S---".ToCharArray().ToString());
            }
        }
    }
