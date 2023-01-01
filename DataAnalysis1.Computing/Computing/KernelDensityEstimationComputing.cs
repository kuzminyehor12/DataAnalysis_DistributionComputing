using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.Computing.Enums;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing.Computing
{
    public class KernelDensityEstimationComputing : StatisticalCharacteristicsComputing
    {
        private double _customBandwidth;

        public double CustomBandwidth
        {
            get => _customBandwidth; 
            set
            {
                if (value < 0)
                {
                    _customBandwidth = ComputeBandwidth(Rule.Scott);
                    return;
                }

                _customBandwidth = value;
            }
        }

        public KernelDensityEstimationComputing(BaseSeries<double> dataSource) : base(dataSource)
        {
            CustomBandwidth = ComputeBandwidth(Rule.Scott);
        }

        public double ComputeKernelDensityEstimationValue(double elem)
        {
            var prefix = 1 / (CustomBandwidth * DataSource.Series.Count);
            var sum = 0.0;

            foreach (var e in DataSource.Series)
            {
                sum += ComputeKernelValue((elem - e) / CustomBandwidth);
            }

            return prefix * sum;
        }

        public double ComputeKernelValue(double value)
        {
            if (Math.Abs(value) <= Math.Sqrt(5))
            {
                return 0.75 * (1 / Math.Sqrt(5)) * (1 - Math.Pow(value, 2) * 0.2);
            }

            return 0;
        }

        public double ComputeBandwidth(Rule rule)
        {
            if (rule == Rule.Scott)
            {
                return ComputeBandwidthWithScottRule();
            }

            return ComputeBandwidthWithSilvermanRule();
        }

        private double ComputeBandwidthWithScottRule()
        {
            return ComputeStandartDeviation() * Math.Pow(DataSource.Series.Count, -0.2);
        }

        private double ComputeBandwidthWithSilvermanRule()
        {
            return ComputeStandartDeviation() * Math.Pow(0.75 * DataSource.Series.Count, -0.2);
        }
    }
}
