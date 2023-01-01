using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing.Computing
{
    public class PointEstimationCharacteristicsComputing : VariationalSeriesComputing<double>
    {
        public PointEstimationCharacteristicsComputing(BaseSeries<double> dataSource) : base(dataSource)
        {
            
        }

        public double ComputeAverage()
        {
            var sum = 0.0;

            foreach (var elem in GetDistinctAndSorted(false))
            {
                sum += elem;
            }

            return sum / GetDistinctAndSorted(false).Count();
        }

        public double ComputeMedian()
        {
            var series = GetDistinctAndSorted(false).ToList();

            if (series.Count() % 2 == 0)
            {
                return 0.5 * (series[series.Count / 2] + series[series.Count / 2 + 1]);
            }

            return series[(series.Count + 1) / 2];
        }

        public double ComputeDispersion(bool isShifted = false)
        {
            var sum = 0.0;

            foreach (var elem in GetDistinctAndSorted(false))
            {
                sum += Math.Pow(elem - ComputeAverage(), 2);
            }

            return !isShifted
                ? 1 / ((double)GetDistinctAndSorted(false).Count() - 1) * sum
                : 1 / (double)GetDistinctAndSorted(false).Count() * sum;
        }

        public double ComputeStandartDeviation(bool isShifted = false)
        {
            return !isShifted ? Math.Sqrt(ComputeDispersion()) : Math.Sqrt(ComputeDispersion(true));
        }

        public double ComputeSkewnessCoefficient()
        {
            var sum = 0.0;

            foreach (var elem in GetDistinctAndSorted(false))
            {
                sum += Math.Pow(elem - ComputeAverage(), 3);
            }

            return 1 / (GetDistinctAndSorted(false).Count() * Math.Pow(ComputeStandartDeviation(true), 3)) * sum;
        }

        public double ComputeKurtosisCoefficient()
        {
            var count = GetDistinctAndSorted(false).Count();

            var shiftedCurtosis = ComputeShiftedKurtosis();

            var first = (Math.Pow(count, 2) - 1) / ((count - 2) * (count - 3));
            var second = shiftedCurtosis + 6 / ((double)count + 1);

            return first * second;
        }

        public double ComputeAntikurtosisCoefficient()
        {
            return 1 / Math.Sqrt(ComputeShiftedKurtosis() + 3);
        }

        public double ComputeShiftedKurtosis()
        {
            var sum = 0.0;

            foreach (var elem in GetDistinctAndSorted(false))
            {
                sum += Math.Pow(elem - ComputeAverage(), 4);
            }

            return 1 / (GetDistinctAndSorted(false).Count() * Math.Pow(ComputeStandartDeviation(true), 4)) * sum - 3;
        }

        public double GetMax()
        {
            return GetDistinctAndSorted(false).Max();
        }

        public double GetMin()
        {
            return GetDistinctAndSorted(false).Min();
        }
    }
}
