using DataAnalysis1.Computing.Computing;
using DataAnalysis1.Computing.Factories;
using DataAnalysis1.DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysis1.Forms.Forms
{
    public partial class ProbabilitySheetForm : Form
    {
        public VariationalSeries DataSource { get; set; }
        public ProbabilitySheetFactory Factory { get; set; }
        public ProbabilitySheetComputing SeriesComputing { get; set; }
        public ProbabilitySheetForm(VariationalSeries dataSource)
        {
            InitializeComponent();
            DataSource = dataSource;
            Factory = new ProbabilitySheetFactory();

            ProbabilitySheet.ChartAreas[0].AxisX.Title = "t";
            ProbabilitySheet.ChartAreas[0].AxisY.Title = "z";
        }

        public async Task UploadProbabilitySheet()
        {
            await Task.Run(() =>
            {
                ProbabilitySheet.Invoke(new MethodInvoker(() =>
                {
                    ProbabilitySheet.Series[0].Points.Clear();
                    SeriesComputing = Factory.CreateComputing(DataSource) as ProbabilitySheetComputing;

                    foreach (var elem in SeriesComputing.GetDistinctAndSorted(false))
                    {
                        ProbabilitySheet.Series[0].Points.AddXY(SeriesComputing.GetT(elem),
                            SeriesComputing.GetZ(elem));
                    }
                }));
            });
        }
    }
}
