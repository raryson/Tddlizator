using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumberConversion.FrameWork;
using System;

namespace RomanNumberConversion.Test
{
    [TestClass]
    public class NumberConvertionTest
    {
        //1° tip, start with a test list
        //2° tip, every start for most simple implementation

        /*
         * Need to convert from I to 1 (Ok)
         * Need to convert from II to 2 (Ok)
         * Need to convert from III to 3 (Ok)
         * Need to convert from VI to 4
         * Need to convert from V to 5 (Ok)
         * Need to convert from VI to 6 (Ok)
         * Need to convert from VII to 7 (Ok)
         * Need to convert from VIII to 8 (Ok)
         * Need to convert from IX to 9
         * Need to convert from X to 10 (Ok)
         * Need catch error with unkow cars (Ok)
         * 
         */

        //3° tip, start build your code with your test
        //4° tip, start build your test with a acertive definition
        //Mantra -> Red > Green > Refactor
        //5° tip, matrix the code at build
        //6° tip, catche green more faster possible


        [TestMethod]
        public void Need_Convert_I_For_1()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(1, Conversor.ConvertToInt('I'));
        }

        //7°tip, just build necessari things for my test works
        [TestMethod]
        public void Need_Convert_V_For_5()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(5, Conversor.ConvertToInt('V'));
        }

        [TestMethod]
        public void Need_Convert_V_For_10()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(10, Conversor.ConvertToInt('X'));
        }


        //8° tip, baby steps
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Throw_Excepetion_With_No_Knowledge_Chars()
        {
            var Conversor = new RomanNumberConverter();

            Conversor.ConvertToInt('Z');
        }

        [TestMethod]
        public void Need_Convert_II_For_2()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(2, Conversor.ConvertToInt("II"));
        }

        [TestMethod]
        public void Need_Convert_III_For_3()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(3, Conversor.ConvertToInt("III"));
        }

        //9° Tip, Build same equal tests but with distincts parameters

        [TestMethod]
        public void Need_Convert_VI_For_6()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(6, Conversor.ConvertToInt("VI"));
        }

        [TestMethod]
        public void Need_Convert_VII_For_7()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(7, Conversor.ConvertToInt("VII"));
        }

        [TestMethod]
        public void Need_Convert_VIII_For_8()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(8, Conversor.ConvertToInt("VIII"));
        }

        [TestMethod]
        public void Need_Convert_IV_For_4()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(4, Conversor.ConvertToInt("IV"));
        }

        [TestMethod]
        public void Need_Convert_IX_For_9()
        {
            var Conversor = new RomanNumberConverter();

            Assert.AreEqual(9, Conversor.ConvertToInt("IX"));
        }
    }
}
