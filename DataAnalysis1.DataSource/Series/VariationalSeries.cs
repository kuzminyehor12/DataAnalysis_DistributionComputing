using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysis1.DataSource
{
    public class VariationalSeries : BaseSeries<double>
    {
        public VariationalSeries()
        {
            Series = new List<double>();
        }
        public VariationalSeries(string path)
        {
            Series = new List<double>();
            InitSeries(path);
        }

        public override void InitSeries(string path)
        {
            using (TextReader reader = File.OpenText(path))
            {
                string text = reader.ReadToEnd();
                string[] bits = text.Split(' ', '\r', '\n');
                foreach (var b in bits)
                {
                    if (double.TryParse(b, out double res))
                        Series.Add(res);
                }
            }
        }
    }
}
