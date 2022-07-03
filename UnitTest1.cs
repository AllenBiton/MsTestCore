using Microsoft.VisualStudio.TestTools.UnitTesting;

using TypeMock.ArrangeActAssert;
using TypeMock;
using System.Diagnostics.CodeAnalysis;
using System.Collections;
using System;
using System.Diagnostics;

namespace Mstest_Core
{
    [TestClass,Isolated]
    public class MathTests
    {

        [TestMethod]
        public void IsEvenNum_Test_ReturnsFalse()
        {
            //foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
              //  Console.WriteLine("  {0} = {1}", de.Key, de.Value);

            //Process[] pname = Process.GetProcessesByName("notepad");
            //if (pname.Length == 0)
            //    MessageBox.Show("nothing");
            //else
                //MessageBox.Show("run");

            Mathe obj = new Mathe();

            Isolate.WhenCalled(() => obj.IsEvenNum(0)).WillReturn(false);
            // act
            var result = obj.IsEvenNum((8));

            // assert
            Assert.AreEqual(false, result);
        }

    }
    public class Mathe
    {
        
        public Mathe()
        {
        }
        public bool IsEvenNum(int number)
        {
            var isEven = (number % 2 == 0) ? true : false;
            return isEven;
        }
    }
}
