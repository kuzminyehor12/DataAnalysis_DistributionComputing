using DataAnalysis1.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysis1.Computing.Computing
{
    public class ProbabilitySheetComputing : VariationalSeriesComputing<double>
    {
        private readonly PointEstimationCharacteristicsComputing _pointEstimationCharacteristicsComputing;
        public ProbabilitySheetComputing(BaseSeries<double> dataSource) : base(dataSource)
        {
            _pointEstimationCharacteristicsComputing = new PointEstimationCharacteristicsComputing(dataSource);
        }

        public double GetZ(double x)
        {
            var fx = ComputeEmpiricalCumulativeDistributionFunctionValue(GetDistinctAndSorted(false).ToList().IndexOf(x));
            var avg = _pointEstimationCharacteristicsComputing.ComputeAverage();

            if(x <= avg)
            {
                return Math.Log(2 * fx);
            }

            return -Math.Log(2 * (1 - fx));
        }

        public double GetT(double x)
        {
            return x;
        }
    }
}
