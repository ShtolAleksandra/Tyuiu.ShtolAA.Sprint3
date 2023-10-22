using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShtolAA.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            int k;
            for (k=startValue; k <= stopValue; k++)
            {
                MultiplySeries = (Math.Pow(value, 3) / Math.Pow(k, 3)) * MultiplySeries;
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
