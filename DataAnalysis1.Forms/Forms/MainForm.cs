using DataAnalysis1.Computing;
using DataAnalysis1.DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataAnalysis1.Forms.Extensions;

namespace DataAnalysis1.Forms.Forms
{
    public partial class MainForm : Form
    {
        private readonly VariationalSeriesForm _variationalSeriesForm;
        private readonly ClassesSegregationForm _classesSegregationForm;
        private readonly CharacteristicsEstimationForm _characteristicsEstimationForm;
        private AbnormalValuesForm _abnormalValuesForm;
        private ProbabilitySheetForm _probabilitySheetForm;
        private bool _isScaled;
        private VariationalSeries DataSource { get; set; }
        public IComputingFactory<double> Factory { get; set; }
        public VariationalSeriesComputing<double> SeriesComputing { get; set; }
        public MainForm()
        {
            InitializeComponent();
            _variationalSeriesForm = new VariationalSeriesForm();
            _classesSegregationForm = new ClassesSegregationForm();
            _characteristicsEstimationForm = new CharacteristicsEstimationForm();
            _abnormalValuesForm = new AbnormalValuesForm(new VariationalSeries());
            _probabilitySheetForm = new ProbabilitySheetForm(new VariationalSeries());

            Factory = new VariationalSeriesComputingFactory<double>();
            ClassBar.Series[0]["PointWidth"] = "1";
            ClassBar.Series[1].BorderWidth = 3;

            EmpiricalDistributionFunction.ChartAreas[0].AxisX.Title = "Елемент";
            EmpiricalDistributionFunction.ChartAreas[0].AxisY.Title = "Значення емпіричної функції елемента";

            ClassBar.ChartAreas[0].AxisX.Title = "X";
            ClassBar.ChartAreas[0].AxisY.Title = "Відносна частота";

            ClassBar.AllowZooming();
            _isScaled = false;

            this.OpenChildForm(_variationalSeriesForm, splitContainer2.Panel1);
            EmpiricalDistributionFunction.ShowOnly(splitContainer2.Panel2);
        }

        private async void browsingFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "All files (*.*)|*.*",
                Multiselect = false
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                DataSource = new VariationalSeries(path);
                _abnormalValuesForm = new AbnormalValuesForm(DataSource);
                _probabilitySheetForm = new ProbabilitySheetForm(DataSource);
                await UploadVariationalSeries();
            }
        }

        private async void VariationalSeries_Click(object sender, EventArgs e)
        {
            _probabilitySheetForm.SendToBack();
            _probabilitySheetForm.Hide();
            _abnormalValuesForm.Hide();

            this.OpenChildForm(_variationalSeriesForm, splitContainer2.Panel1);
            EmpiricalDistributionFunction.ShowOnly(splitContainer2.Panel2);

            if (DataSource != null)
            {
                await UploadVariationalSeries();
            }
        }

        private async Task UploadVariationalSeries()
        {
            _variationalSeriesForm.ClearDataGrid();
            EmpiricalDistributionFunction.Series[0].Points.Clear();
            await _variationalSeriesForm.FillDataGrid(DataSource);
            await FillChart();
        }

        private async Task FillChart()
        {
            await Task.Run(() =>
            {
                try
                {
                    SeriesComputing = Factory.CreateComputing(DataSource) as VariationalSeriesComputing<double>;
                    int variantNumber = 0;

                    EmpiricalDistributionFunction.Invoke(new MethodInvoker(() =>
                    {
                        foreach (var elem in SeriesComputing.GetDistinctAndSorted(true))
                        {
                            EmpiricalDistributionFunction.Series[0].Points.AddXY(
                                elem, SeriesComputing.ComputeEmpiricalCumulativeDistributionFunctionValue(variantNumber++));
                        }
                    }));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.StackTrace, e.GetType().ToString(), MessageBoxButtons.OK);
                }
                
            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _probabilitySheetForm.SendToBack();
            _probabilitySheetForm.Hide();
            _abnormalValuesForm.Hide();

            this.OpenChildForm(_classesSegregationForm, splitContainer2.Panel1);
            ClassBar.ShowOnly(splitContainer2.Panel2);

            if (DataSource != null)
            {
                await UploadClassesSegregation();
            }
        }

        private async Task UploadClassesSegregation()
        {
            await _classesSegregationForm.FillClassesSegregationScheme(DataSource, ClassBar);
        }

        private async void ClassBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _isScaled = !_isScaled;
            await _classesSegregationForm.FillBarChart(_isScaled);
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            EmpiricalDistributionFunction.Hide();
            ClassBar.Hide();

            this.OpenChildForm(_characteristicsEstimationForm, splitContainer2.Panel1);

            if (DataSource != null)
            {
                await UploadCharactersticsEstimation();
            }
        }
        private async Task UploadCharactersticsEstimation()
        {
            await _characteristicsEstimationForm.FillCharacteristicsEstimationScheme(DataSource);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            EmpiricalDistributionFunction.Hide();
            ClassBar.Hide();
            _probabilitySheetForm.Hide();

            this.OpenChildForm(_abnormalValuesForm, splitContainer2.Panel2);

            if (DataSource != null)
            {
                await _abnormalValuesForm.UploadAbnormalValuesChart();
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            EmpiricalDistributionFunction.Hide();
            ClassBar.Hide();
            _abnormalValuesForm.Hide();

            this.OpenChildForm(_probabilitySheetForm, splitContainer2.Panel2);

            if (DataSource != null)
            {
                await _probabilitySheetForm.UploadProbabilitySheet();
            }
        }
    }
}
