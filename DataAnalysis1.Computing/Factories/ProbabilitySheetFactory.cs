using DataAnalysis1.Computing.Computing;
using DataAnalysis1.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysis1.Computing.Factories
{
    public class ProbabilitySheetFactory : IComputingFactory<double>
    {
        public Computing<double> CreateComputing(BaseSeries<double> dataSource)
        {
            return new ProbabilitySheetComputing(dataSource);
        }
    }
}
