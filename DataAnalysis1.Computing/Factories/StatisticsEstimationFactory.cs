using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.Computing.Computing;
using DataAnalysis1.Computing.Enums;

namespace DataAnalysis1.Computing.Factories
{
    public class StatisticsEstimationFactory : IComputingFactory<double>
    {
        public Strategy GeneratingStrategy { get; set; }
        public Computing<double> CreateComputing(DataSource.BaseSeries<double> dataSource)
        {
            if (GeneratingStrategy == Strategy.Point)
            {
                return new PointEstimationCharacteristicsComputing(dataSource);
            }

            if (GeneratingStrategy == Strategy.Interval)
            {
                return new IntervalEstimationCharacteristicsComputing(dataSource);
            }

            if (GeneratingStrategy == Strategy.Statistics)
            {
                return new StatisticalCharacteristicsComputing(dataSource);
            }

            return new StandartDeviationComputing(dataSource);
        }
    }
}
