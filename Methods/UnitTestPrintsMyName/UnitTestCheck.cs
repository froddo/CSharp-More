using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintsMyName;


namespace UnitTestMyName
{
    [TestClass]
    public class UnitTestExample
    {
        [TestMethod]
        public void TestMethodName()
        { 
            string name = Name.PrintMyName("Pesho Peshev");
            Assert.AreSame("Pesho Peshev", name);
        }

    }
}
