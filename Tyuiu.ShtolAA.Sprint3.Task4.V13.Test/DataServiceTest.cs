using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtolAA.Sprint3.Task4.V13.Lib;

namespace Tyuiu.ShtolAA.Sprint3.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 2.993;
            Assert.AreEqual(wait, res);
        }
    }
}
