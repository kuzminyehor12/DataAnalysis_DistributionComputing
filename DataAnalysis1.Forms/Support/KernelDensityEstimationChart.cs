using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataAnalysis1.Computing;
using DataAnalysis1.Computing.Computing;
using DataAnalysis1.Computing.Factories;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Forms.Forms
{
    public class KernelDensityEstimationChart
    {
        public KernelDensityEstimationComputingFactory Factory { get; set; }
        public KernelDensityEstimationComputing SeriesComputing { get; set; }
        public double ClassWidth { get; set; }
        public double CustomBandwidth { get; set; }
        public bool IsScaled { get; set; }
        public Chart Chart { get; set; }

        public KernelDensityEstimationChart(Chart chart)
        {
            Factory = new KernelDensityEstimationComputingFactory();
            Chart = chart;
        }

        public async Task FillKernelDensityEstimationSeries(VariationalSeries dataSource)
        {
            await Task.Run(() =>
            {
                try
                {
                    SeriesComputing = Factory.CreateComputing(dataSource) as KernelDensityEstimationComputing;
                    SeriesComputing.CustomBandwidth = this.CustomBandwidth;

                    Chart.Invoke(new MethodInvoker(() =>
                    {
                        Chart.Series[1].Points.Clear();

                        foreach (var e in SeriesComputing.GetDistinctAndSorted(false))
                        {
                            if (IsScaled)
                            {
                                Chart.Series[1].Points.AddXY(e, SeriesComputing.ComputeKernelDensityEstimationValue(e) * ClassWidth);
                            }
                            else
                            {
                                Chart.Series[1].Points.AddXY(e, SeriesComputing.ComputeKernelDensityEstimationValue(e));
                            }
                        }
                    }));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace, e.GetType().ToString(), MessageBoxButtons.OK);
                }
            });
        }
    }
}
