using DataAnalysis1.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysis1.Computing
{
    public class ClassSegregationComputingFactory : IComputingFactory<double>
    {
        public int ClassNumber { get; set; }
        public Computing<double> CreateComputing(BaseSeries<double> dataSource)
        {
            return new ClassSegregationComputing(dataSource, ClassNumber);
        }

        public IComputingFactory<double> SetClassNumber(int classNumber)
        {
            ClassNumber = classNumber;
            return this;
        }
    }
}
