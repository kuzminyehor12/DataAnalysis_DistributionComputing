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
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Forms
{
    public partial class VariationalSeriesForm : Form
    {
        public IComputingFactory<double> Factory { get; set; }
        public VariationalSeriesComputing<double> SeriesComputing { get; set; }
        public VariationalSeriesForm()
        {
            InitializeComponent();
            Factory = new VariationalSeriesComputingFactory<double>();
        }

        public async Task FillDataGrid(VariationalSeries dataSource)
        {
            await Task.Run(() =>
            {
                try
                {
                    SeriesComputing = Factory.CreateComputing(dataSource) as VariationalSeriesComputing<double>;
                    int variantNumber = 1;

                    foreach (var elem in SeriesComputing.GetDistinctAndSorted(true))
                    {
                        VariationalSeriesScheme.Invoke(new MethodInvoker(() =>
                        {
                            VariationalSeriesScheme.Rows.Add(
                                variantNumber++, elem,
                                SeriesComputing.CountFrequency(elem),
                                SeriesComputing.CountRelativeFrequency(elem),
                                SeriesComputing.ComputeEmpiricalCumulativeDistributionFunctionValue(
                                    SeriesComputing.GetDistinctAndSorted(true)
                                        .ToList()
                                        .IndexOf(elem)));
                        }));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace, e.GetType().ToString(), MessageBoxButtons.OK);
                }
            });
        }

        public void ClearDataGrid()
        {
            VariationalSeriesScheme.Rows.Clear();
        }
    }
}
