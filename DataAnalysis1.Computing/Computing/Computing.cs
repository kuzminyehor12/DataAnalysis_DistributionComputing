using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Computing
{
    public class Computing<T>
    {
        public BaseSeries<T> DataSource { get; set; }

        public IEnumerable<T> GetDistinctAndSorted(bool isDistinct)
        {
            return isDistinct ? 
                DataSource.Series
                .Distinct()
                .OrderBy(e => e) :
                    DataSource.Series
                        .OrderBy(e => e);
        }
    }
}
