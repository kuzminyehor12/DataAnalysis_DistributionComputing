using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing.Computing
{
    public class IntervalEstimationCharacteristicsComputing : VariationalSeriesComputing<double>
    {
        private readonly SeriesQuantileComputing _quantileComputing;
        private readonly StandartDeviationComputing _deviationComputing;
        private readonly PointEstimationCharacteristicsComputing _pointEstimationComputing;
        private const double Alpha = 0.05;
        private readonly int v;
        public IntervalEstimationCharacteristicsComputing(BaseSeries<double> dataSource) : base(dataSource)
        {
            _quantileComputing = new SeriesQuantileComputing();
            _pointEstimationComputing = new PointEstimationCharacteristicsComputing(dataSource);
            _deviationComputing = new StandartDeviationComputing(dataSource);
            v = DataSource.Series.Count - 1;
        }

        public Tuple<double, double> ComputeIntervalForAverage()
        {
            var first = _pointEstimationComputing.ComputeAverage() -
                        _quantileComputing.ComputeStudentQuantile(1 - Alpha / 2, v) *
                        _deviationComputing.ComputeForAverage();

            var second = _pointEstimationComputing.ComputeAverage() +
                         _quantileComputing.ComputeStudentQuantile(1 - Alpha / 2, v) *
                         _deviationComputing.ComputeForAverage();

            return Tuple.Create(first, second);
        }

        public Tuple<double, double> ComputeIntervalForMedian()
        {
            int j = (int)(DataSource.Series.Count / 2 - _quantileComputing.ComputeNormalSeriesQuantile(1 - Alpha / 2) *
                (Math.Sqrt(DataSource.Series.Count) / 2));

            int k = (int)(DataSource.Series.Count / 2 + 1 + _quantileComputing.ComputeNormalSeriesQuantile(1 - Alpha / 2) *
                (Math.Sqrt(DataSource.Series.Count) / 2));

            return Tuple.Create(GetDistinctAndSorted(false).ToList()[j], GetDistinctAndSorted(false).ToList()[k]);
        }

        public Tuple<double, double> ComputeIntervalForStandartDeviation()
        {
            var first = _pointEstimationComputing.ComputeStandartDeviation() -
                        _quantileComputing.ComputeStudentQuantile(1 - Alpha / 2, v) *
                        _deviationComputing.ComputeForStandartDeviation();

            var second = _pointEstimationComputing.ComputeStandartDeviation() +
                         _quantileComputing.ComputeStudentQuantile(1 - Alpha / 2, v) *
                         _deviationComputing.ComputeForStandartDeviation();

            return Tuple.Create(first, second);
        }

        public Tuple<double, double> ComputeIntervalForSkewness()
        {
            var first = _pointEstimationComputing.ComputeSkewnessCoefficient() -
                        _quantileComputing.ComputeStudentQuantile(1 - Alpha / 2, v) *
                        _deviationComputing.ComputeForSkewness();

            var second = _pointEstimationComputing.ComputeSkewnessCoefficient() +
                         _quantileComputing.ComputeStudentQuantile(1 - Alpha / 2, v) *
                         _deviationComputing.ComputeForSkewness();

            return Tuple.Create(first, second);
        }

        public Tuple<double, double> ComputeIntervalForKurtosis()
        {
            var first = _pointEstimationComputing.ComputeKurtosisCoefficient() -
                        _quantileComputing.ComputeStudentQuantile(1 - Alpha / 2, v) *
                        _deviationComputing.ComputeForKurtosis();

            var second = _pointEstimationComputing.ComputeKurtosisCoefficient() +
                         _quantileComputing.ComputeStudentQuantile(1 - Alpha / 2, v) *
                         _deviationComputing.ComputeForKurtosis();

            return Tuple.Create(first, second);
        }
    }
}
