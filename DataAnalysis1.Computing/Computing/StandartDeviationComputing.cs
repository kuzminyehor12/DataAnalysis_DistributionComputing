using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing.Computing
{
    public class StandartDeviationComputing : VariationalSeriesComputing<double>
    {
        private readonly PointEstimationCharacteristicsComputing _innerComputing;
        public int Count { get; set; }
        public StandartDeviationComputing(BaseSeries<double> dataSource) : base(dataSource)
        {
            _innerComputing = new PointEstimationCharacteristicsComputing(dataSource);
            Count = dataSource.Series.Count;
        }

        public double ComputeForAverage()
        {
            return _innerComputing.ComputeStandartDeviation() / Math.Sqrt(Count);
        }

        public double ComputeForStandartDeviation()
        {
            return _innerComputing.ComputeStandartDeviation() / Math.Sqrt(2 * Count);
        }

        public double ComputeForSkewness()
        {
            return Math.Sqrt(6 * Count * (Count - 1) / ((double)(Count + 1) * (Count + 3) * (Count - 2)));
        }

        public double ComputeForKurtosis()
        {
            return Math.Sqrt(24 * Count * Math.Pow(Count - 1, 2) / ((double)(Count - 3) * (Count - 2) * (Count + 3) * (Count + 5)));
        }
    }
}
