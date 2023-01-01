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
using DataAnalysis1.Computing.Computing;
using DataAnalysis1.Computing.Factories;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Forms.Forms
{
    public partial class AbnormalValuesForm : Form
    {
        public AbnormalValuesComputingFactory Factory { get; set; }
        public AbnormalValuesComputing SeriesComputing { get; set; }
        public VariationalSeries DataSource { get; set; }
        public double Infimum { get; set; }
        public double Supremum { get; set; }

        private const string Format = "F5";
        private readonly Color LineColor;
        private readonly Color AbnormalColor;
        public AbnormalValuesForm(VariationalSeries dataSource)
        {
            InitializeComponent();

            DataSource = dataSource;
            Factory = new AbnormalValuesComputingFactory();
            SeriesComputing = Factory.CreateComputing(DataSource) as AbnormalValuesComputing;

            Infimum = SeriesComputing.ComputeInf();
            Supremum = SeriesComputing.ComputeSup();

            AbnormalValues.ChartAreas[0].AxisX.Title = "Індекс елементу";
            AbnormalValues.ChartAreas[0].AxisY.Title = "Значення";

            AbnormalValues.BorderWidth = 5;
            LineColor = Color.Orange;
            AbnormalColor = Color.Red;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var series = new double[DataSource.Series.Count];
            DataSource.Series.CopyTo(series, 0);

            foreach (var elem in series)
            {
                if (elem < Infimum || elem > Supremum)
                {
                    DataSource.Series.Remove(elem);
                }
            }

            await UploadAbnormalValuesChart();
        }

        public async Task UploadAbnormalValuesChart()
        {
            await Task.Run(() =>
            {
                AbnormalValues.Invoke(new MethodInvoker(() =>
                {
                    try
                    {
                        textBox1.Text = Infimum.ToString(Format);
                        textBox2.Text = Supremum.ToString(Format);

                        AbnormalValues.Series[0].Points.Clear();
                        AbnormalValues.Series[1].Points.Clear();
                        AbnormalValues.Series[2].Points.Clear();

                        foreach (var elem in DataSource.Series)
                        {
                            var point = new DataPoint(DataSource.Series.IndexOf(elem), elem);

                            if (elem < Infimum || elem > Supremum)
                            {
                                point.Color = AbnormalColor;
                            }

                            AbnormalValues.Series[0].Points.Add(point);
                        }

                        var lastIndex = DataSource.Series.IndexOf(DataSource.Series.Last());
                        AbnormalValues.Series[1].Points.AddXY(0, Infimum);
                        AbnormalValues.Series[1].Points.AddXY(lastIndex, Infimum);

                        AbnormalValues.Series[2].Points.AddXY(0, Supremum);
                        AbnormalValues.Series[2].Points.AddXY(lastIndex, Supremum);

                        ColorLines(LineColor);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.StackTrace, e.GetType().ToString(), MessageBoxButtons.OK);
                    }
                }));
            });
        }

        private void ColorLines(Color color)
        {
            foreach (var p in AbnormalValues.Series[1].Points)
            {
                p.Color = color;
            }

            foreach (var p in AbnormalValues.Series[2].Points)
            {
                p.Color = color;
            }
        }
    }
}
