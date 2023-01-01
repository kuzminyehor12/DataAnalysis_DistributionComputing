using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysis1.DataSource
{
    public abstract class BaseSeries<T>
    {
        public IList<T> Series { get; set; }
        public abstract void InitSeries(string path);
    }
}
