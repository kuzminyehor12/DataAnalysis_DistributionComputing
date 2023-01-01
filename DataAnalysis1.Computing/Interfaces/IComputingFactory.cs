using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing
{
    public interface IComputingFactory<T>
    {
        Computing<T> CreateComputing(BaseSeries<T> dataSource);
    }
}
