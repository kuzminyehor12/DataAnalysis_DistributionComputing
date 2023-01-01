using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing.Computing
{
    public class AbnormalValuesComputing : VariationalSeriesComputing<double>
    {
        private const double Alpha = 0.05;
        private readonly SeriesQuantileComputing _quantileComputing;
        private readonly PointEstimationCharacteristicsComputing _pointEstimationCharacteristicsComputing;
        public AbnormalValuesComputing(BaseSeries<double> dataSource) : base(dataSource)
        {
            _quantileComputing = new SeriesQuantileComputing();
            _pointEstimationCharacteristicsComputing = new PointEstimationCharacteristicsComputing(dataSource);
        }

        public double ComputeInf()
        {
            return _pointEstimationCharacteristicsComputing.ComputeAverage() -
                   _quantileComputing.ComputeNormalSeriesQuantile(1 - Alpha / 2) * _pointEstimationCharacteristicsComputing.ComputeStandartDeviation();
        }

        public double ComputeSup()
        {
            return _pointEstimationCharacteristicsComputing.ComputeAverage() +
                   _quantileComputing.ComputeNormalSeriesQuantile(1 - Alpha / 2) * _pointEstimationCharacteristicsComputing.ComputeStandartDeviation();
        }
    }
}
