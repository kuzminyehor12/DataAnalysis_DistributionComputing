using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing
{
    public class VariationalSeriesComputing<T> : Computing<T>, IFrequencyComputing<T>
    {
        public VariationalSeriesComputing(BaseSeries<T> dataSource)
        {
            DataSource = dataSource;
        }
        public int CountFrequency(T elem)
        {
            return DataSource.Series.Count(s => elem.Equals(s));
        }

        public double CountRelativeFrequency(T elem)
        {
            return (double)CountFrequency(elem) / DataSource.Series.Count;
        }

        public double ComputeEmpiricalCumulativeDistributionFunctionValue(int index)
        {
            double relativeFrequency = 0;

            foreach (var elem in DataSource.Series.TakeWhile(e => DataSource.Series.IndexOf(e) <= index))
            {
                relativeFrequency += CountRelativeFrequency(elem);
            }

            return relativeFrequency;
        }
    }
}
