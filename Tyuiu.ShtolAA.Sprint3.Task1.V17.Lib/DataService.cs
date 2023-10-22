using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShtolAA.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            while (startValue<= stopValue)
            {
                MultiplySeries = (Math.Pow(2,startValue))/Math.Pow(Math.Cos(value),startValue) * MultiplySeries;
                startValue++;
            }
            return Math.Round(MultiplySeries, 3);

        }
    }
}
