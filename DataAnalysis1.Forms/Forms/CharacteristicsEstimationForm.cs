using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAnalysis1.Computing;
using DataAnalysis1.Computing.Computing;
using DataAnalysis1.Computing.Enums;
using DataAnalysis1.Computing.Factories;
using DataAnalysis1.DataSource;

namespace DataAnalysis1.Forms.Forms
{
    public partial class CharacteristicsEstimationForm : Form
    {
        public StatisticsEstimationFactory Factory { get; set; }
        public PointEstimationCharacteristicsComputing PointEstimationComputing { get; set; }
        public IntervalEstimationCharacteristicsComputing IntervalEstimationComputing { get; set; }
        public StandartDeviationComputing StandartDeviationComputing { get; set; }
        private const string Format = "F5";

        public CharacteristicsEstimationForm()
        {
            InitializeComponent();
            Factory = new StatisticsEstimationFactory();
        }

        public async Task FillCharacteristicsEstimationScheme(VariationalSeries dataSource)
        {
            await Task.Run(() =>
            {
                dataGridView2.Invoke(new MethodInvoker(() =>
                {
                    try
                    {
                        Factory.GeneratingStrategy = Strategy.Point;
                        PointEstimationComputing = Factory.CreateComputing(dataSource) as PointEstimationCharacteristicsComputing;

                        Factory.GeneratingStrategy = Strategy.Interval;
                        IntervalEstimationComputing = Factory.CreateComputing(dataSource) as IntervalEstimationCharacteristicsComputing;

                        Factory.GeneratingStrategy = Strategy.StandartDeviation;
                        StandartDeviationComputing = Factory.CreateComputing(dataSource) as StandartDeviationComputing;

                        dataGridView2.Rows.Clear();

                        dataGridView2.Rows.Add("Середнє арифметичне", PointEstimationComputing.ComputeAverage().ToString(Format),
                            StandartDeviationComputing.ComputeForAverage().ToString(Format),
                            TupleToInterval(IntervalEstimationComputing.ComputeIntervalForAverage()));

                        dataGridView2.Rows.Add("Медіана", PointEstimationComputing.ComputeMedian(),
                            " - ", TupleToInterval(IntervalEstimationComputing.ComputeIntervalForMedian()));

                        dataGridView2.Rows.Add("Середньоквадратичне відхилення", PointEstimationComputing.ComputeStandartDeviation().ToString(Format),
                            StandartDeviationComputing.ComputeForStandartDeviation().ToString(Format),
                            TupleToInterval(IntervalEstimationComputing.ComputeIntervalForStandartDeviation()));

                        dataGridView2.Rows.Add("Коефіціент асиметрії", PointEstimationComputing.ComputeSkewnessCoefficient().ToString(Format),
                            StandartDeviationComputing.ComputeForSkewness().ToString(Format),
                            TupleToInterval(IntervalEstimationComputing.ComputeIntervalForSkewness()));

                        dataGridView2.Rows.Add("Коефіціент ексцесу", PointEstimationComputing.ComputeKurtosisCoefficient().ToString(Format),
                            StandartDeviationComputing.ComputeForKurtosis().ToString(Format),
                            TupleToInterval(IntervalEstimationComputing.ComputeIntervalForKurtosis()));

                        dataGridView2.Rows.Add("Коефіціент контрексцесу", PointEstimationComputing.ComputeAntikurtosisCoefficient().ToString(Format), "-", "-");

                        dataGridView2.Rows.Add("Максимум", PointEstimationComputing.GetMax(), "-", "-");

                        dataGridView2.Rows.Add("Мінімум", PointEstimationComputing.GetMin(), "-", "-");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.StackTrace, e.GetType().ToString(), MessageBoxButtons.OK);
                    }
                }));
            });
        }

        private string TupleToInterval(Tuple<double, double> tuple)
        {
            return $"[ {tuple.Item1.ToString(Format)} : {tuple.Item2.ToString(Format)} ]";
        }
    }
}
