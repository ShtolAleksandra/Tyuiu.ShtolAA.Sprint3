using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint3.Task3.V27.Lib;

namespace Tyuiu.ShtolAA.Sprint3.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string str = "!bt,g567kid f!";

            double res = ds.ConvertStringToInt(str);

            double wait = 567;

            Assert.AreEqual(wait, res);
        }
    }
}




