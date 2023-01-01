using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataAnalysis1.Computing;
using DataAnalysis1.Computing.Computing;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Forms.Forms
{
    public partial class ClassesSegregationForm : Form
    {
        public ClassSegregationComputingFactory Factory { get; set; }
        public ClassSegregationComputing SeriesComputing { get; set; }
        public VariationalSeries Series { get; set; }
        public Chart Chart { get; set; }
        public double CustomBandwidth { get; set; }
        private bool _entryOnce;
        public ClassesSegregationForm()
        {
            InitializeComponent();
            Factory = new ClassSegregationComputingFactory();
            CustomBandwidth = -1;
            _entryOnce = false;
        }

        private async void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (SeriesComputing != null)
            {
                await FillClassesSegregationScheme(SeriesComputing.DataSource as VariationalSeries, Chart);
            }
        }

        public async Task FillClassesSegregationScheme(VariationalSeries dataSource, Chart chart)
        {
            await Task.Run(async () =>
            {
                try
                {
                    Series = dataSource;
                    Chart = chart;
                    SeriesComputing = Factory.SetClassNumber((int)numericUpDown1.Value)
                        .CreateComputing(Series) as ClassSegregationComputing;
                    int classNumber = 1;

                    ClassSegregationScheme.Invoke(new MethodInvoker(() =>
                    {
                        ClassSegregationScheme.Rows.Clear();
                        foreach (var l in SeriesComputing.ClassList)
                        {
                            ClassSegregationScheme.Rows.Add(classNumber++,
                                ConvertLimitsToString(SeriesComputing.GetLimits(
                                    SeriesComputing.ClassList.IndexOf(l))),
                                SeriesComputing.CountFrequency(l),
                                SeriesComputing.CountRelativeFrequency(l),
                                SeriesComputing.ComputeEmpiricalCumulativeDistributionFunctionValue(
                                    SeriesComputing.ClassList.IndexOf(l)));
                        }

                    }));

                    await FillBarChart();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace, e.GetType().ToString(), MessageBoxButtons.OK);
                }
            });
        }

        public async Task FillBarChart(bool isScaled = false)
        {
            await Task.Run(() =>
            {
                try
                {
                    Chart.Invoke(new MethodInvoker(async () =>
                    {
                        Chart.Show();
                        Chart.Series[0].Points.Clear();

                        foreach (var l in SeriesComputing.ClassList)
                        {
                            if (l.Count != 0)
                            {
                                Chart.Series[0].Points.AddXY(
                                    (SeriesComputing.Limits[SeriesComputing.ClassList.IndexOf(l)].Item1 
                                    + SeriesComputing.Limits[SeriesComputing.ClassList.IndexOf(l)].Item2) / 2,
                                    SeriesComputing.CountRelativeFrequency(l) / SeriesComputing.CountClassWidth());
                            }
                        }

                        SetBorders();
                        SetBandwidthBox();

                        var kernelDensityEstimation = new KernelDensityEstimationChart(Chart)
                        {
                            CustomBandwidth = this.CustomBandwidth,
                            ClassWidth = SeriesComputing.CountClassWidth(),
                            IsScaled = isScaled,
                        };

                        await kernelDensityEstimation.FillKernelDensityEstimationSeries(Series);
                    }));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace, e.GetType().ToString(), MessageBoxButtons.OK);
                }
            });
        }

        private void SetBandwidthBox()
        {
            if (!_entryOnce)
            {
                var kernelComputing = new KernelDensityEstimationComputing(Series);
                textBox1.Text = kernelComputing.ComputeBandwidth(Computing.Enums.Rule.Scott).ToString();
                _entryOnce = true;
            }
        }
        private void SetBorders()
        {
            foreach (var p in Chart.Series[0].Points)
            {
                p.BorderColor = Color.Black;
                p.BorderWidth = 1;
            }
        }
        private string ConvertLimitsToString(Tuple<double, double> limits)
        {
            return $"[ {Math.Round(limits.Item1, 3)} " +
                   $": {Math.Round(limits.Item2, 3)} )";
        }

        private async void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            if (textBox1.Text != string.Empty
                && double.TryParse(textBox1.Text, out double res) && res > 0)
            {
                CustomBandwidth = res;
                var kernelDensityEstimation = new KernelDensityEstimationChart(Chart)
                {
                    CustomBandwidth = this.CustomBandwidth
                };

                await kernelDensityEstimation.FillKernelDensityEstimationSeries(Series);
                return;
            }

            MessageBox.Show("Cannot parse your bandwidth value. Also bandwidth is supposed to be non-negative number",
                "Bandwidth Error", MessageBoxButtons.OK);
        }
    }
}
