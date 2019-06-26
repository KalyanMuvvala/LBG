using Microsoft.VisualStudio.TestTools.UnitTesting;
using LBGtestConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBGtestConsole.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void NumberToWordsTestInteger()
        {
            Program obj = new Program();           
            Assert.AreEqual(obj.NumberToWords(100).Trim(),"one hundred");
        }
        [TestMethod()]
        public void NumberToWordsTestMinusInteger()
        {
            Program obj = new Program();            
            Assert.AreEqual(obj.NumberToWords(-10).Trim(), "minus ten");
        }
        [TestMethod()]
        public void NumberToWordsTestZero()
        {
            Program obj = new Program();            
            Assert.AreEqual(obj.NumberToWords(0).Trim(), "zero");
        }
        [TestMethod()]
        public void NumberToWordsBigInteger()
        {
            Program obj = new Program();
            Assert.AreEqual(obj.NumberToWords(1234567890).Trim(), "Number is too big, Please try below number : 999,999,999");
        }

    }
}