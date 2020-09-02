using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaleDuncan_S00123318;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            Computer mc = new Computer();
            double NewPrice = 450;
            //ACT
            mc.DecreasePrice(10);
            //ASSERT

        }
    }
}
