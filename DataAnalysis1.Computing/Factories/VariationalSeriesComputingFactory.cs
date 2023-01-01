using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing
{
    public class VariationalSeriesComputingFactory<T> : IComputingFactory<T>
    {
        public Computing<T> CreateComputing(BaseSeries<T> dataSource)
        {
            return new VariationalSeriesComputing<T>(dataSource);
        }
    }
}
