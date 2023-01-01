using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing.Computing
{
    public class StatisticalCharacteristicsComputing : VariationalSeriesComputing<double>
    {
        public StatisticalCharacteristicsComputing(BaseSeries<double> dataSource) : base(dataSource)
        {
           
        }

        public double ComputeMathExpectation(int exp = 1)
        {
            var mathExp = 0.0;

            foreach (var elem in GetDistinctAndSorted(true))
            {
                mathExp += Math.Pow(elem, exp) * CountRelativeFrequency(elem);
            }

            return mathExp;
        }

        public double ComputeDispersion()
        {
            return ComputeMathExpectation(2) - Math.Pow(ComputeMathExpectation(), 2);
        }

        public double ComputeStandartDeviation()
        {
            return Math.Sqrt(ComputeDispersion());
        }
    }
}
