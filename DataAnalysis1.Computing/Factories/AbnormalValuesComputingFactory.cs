using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.Computing.Computing;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing.Factories
{
    public class AbnormalValuesComputingFactory : IComputingFactory<double>
    {
        public Computing<double> CreateComputing(BaseSeries<double> dataSource)
        {
            return new AbnormalValuesComputing(dataSource);
        }
    }
}
