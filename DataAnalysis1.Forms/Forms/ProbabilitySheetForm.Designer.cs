
namespace DataAnalysis1.Forms.Forms
{
    partial class ProbabilitySheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ProbabilitySheet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilitySheet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProbabilitySheet
            // 
            chartArea1.Name = "ChartArea1";
            this.ProbabilitySheet.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ProbabilitySheet.Legends.Add(legend1);
            this.ProbabilitySheet.Location = new System.Drawing.Point(5, 1);
            this.ProbabilitySheet.Name = "ProbabilitySheet";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ProbabilitySheet.Series.Add(series1);
            this.ProbabilitySheet.Size = new System.Drawing.Size(1140, 511);
            this.ProbabilitySheet.TabIndex = 0;
            this.ProbabilitySheet.Text = "chart1";
            // 
            // ProbabilitySheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 515);
            this.Controls.Add(this.ProbabilitySheet);
            this.Name = "ProbabilitySheetForm";
            this.Text = "ProbabilitySheetForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilitySheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ProbabilitySheet;
    }
}