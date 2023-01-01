using DataAnalysis1.DataSource;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DataAnalysis1.Computing
{
    public class ClassSegregationComputing : Computing<double>, IFrequencyComputing<IList<double>>
    {
        public IList<IList<double>> ClassList { get; set; }
        public int ClassesNumber { get; set; }
        public List<Tuple<double, double>> Limits { get; set; }

        public ClassSegregationComputing(BaseSeries<double> dataSource, int classNumber)
        {
            DataSource = dataSource;
            ClassesNumber = classNumber;
            Limits = new List<Tuple<double, double>>();
            ClassList = GenerateClasses();
        }

        public IList<IList<double>> GenerateClasses()
        {
            if (ClassesNumber == 1)
            {
                Limits.Add(Tuple.Create(DataSource.Series.Min(), DataSource.Series.Max()));
                return new List<IList<double>> { DataSource.Series };
            }

            var listOfClasses = new List<IList<double>>();
            double h = CountClassWidth();
            double xmin = DataSource.Series.Min(), xdiff = xmin;

            for (int i = 1; i < ClassesNumber + 1; i++)
            {
                double xmax = xmin + h * i;
                Limits.Add(Tuple.Create(xdiff, xmax));
                listOfClasses.Add(GetDistinctAndSorted(false)
                    .SkipWhile(e => e < xdiff)
                    .TakeWhile(e => e <= xmax)
                    .ToList());
                xdiff = xmax;
            }

            return listOfClasses;
        }

        public Tuple<double, double> GetLimits(int index)
        {
            return Limits[index];
        }

        public int CountFrequency(IList<double> classList)
        {
            return classList.Count();
        }

        public double CountRelativeFrequency(IList<double> classList)
        {
            return CountFrequency(classList) / (double)DataSource.Series.Count;
        }

        public double ComputeEmpiricalCumulativeDistributionFunctionValue(int index)
        {
            double relativeFrequencyPerClassList = 0;

            foreach (var c in ClassList.TakeWhile(l => ClassList.IndexOf(l) <= index))
            {
                relativeFrequencyPerClassList += CountRelativeFrequency(c);
            }

            return relativeFrequencyPerClassList;
        }

        public double CountClassWidth()
        {
            return (DataSource.Series.Max() - DataSource.Series.Min()) / ClassesNumber;
        }
    }
}
