
namespace DataAnalysis1.Forms.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.browsingFilesButton = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.VariationalSeries = new System.Windows.Forms.Button();
            this.ClassesSegregationButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ClassBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EmpiricalDistributionFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpiricalDistributionFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(182, 1055);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // browsingFilesButton
            // 
            this.browsingFilesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browsingFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.browsingFilesButton.Location = new System.Drawing.Point(0, 0);
            this.browsingFilesButton.Name = "browsingFilesButton";
            this.browsingFilesButton.Size = new System.Drawing.Size(181, 103);
            this.browsingFilesButton.TabIndex = 1;
            this.browsingFilesButton.Text = "Browse Files";
            this.browsingFilesButton.UseVisualStyleBackColor = true;
            this.browsingFilesButton.Click += new System.EventHandler(this.browsingFilesButton_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(182, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 1055);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.browsingFilesButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.VariationalSeries);
            this.splitContainer1.Panel2.Controls.Add(this.ClassesSegregationButton);
            this.splitContainer1.Size = new System.Drawing.Size(181, 808);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(0, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 104);
            this.button3.TabIndex = 4;
            this.button3.Text = "Імовірнісний папір";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(-1, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 104);
            this.button2.TabIndex = 3;
            this.button2.Text = "Аномальні значення";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(1, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 104);
            this.button1.TabIndex = 2;
            this.button1.Text = "Оцінки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VariationalSeries
            // 
            this.VariationalSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VariationalSeries.Location = new System.Drawing.Point(1, 2);
            this.VariationalSeries.Name = "VariationalSeries";
            this.VariationalSeries.Size = new System.Drawing.Size(180, 104);
            this.VariationalSeries.TabIndex = 1;
            this.VariationalSeries.Text = "Варіаційний ряд";
            this.VariationalSeries.UseVisualStyleBackColor = true;
            this.VariationalSeries.Click += new System.EventHandler(this.VariationalSeries_Click);
            // 
            // ClassesSegregationButton
            // 
            this.ClassesSegregationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ClassesSegregationButton.Location = new System.Drawing.Point(1, 112);
            this.ClassesSegregationButton.Name = "ClassesSegregationButton";
            this.ClassesSegregationButton.Size = new System.Drawing.Size(180, 104);
            this.ClassesSegregationButton.TabIndex = 0;
            this.ClassesSegregationButton.Text = "Класи";
            this.ClassesSegregationButton.UseVisualStyleBackColor = true;
            this.ClassesSegregationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(185, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 1055);
            this.panel1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ClassBar);
            this.splitContainer2.Panel2.Controls.Add(this.EmpiricalDistributionFunction);
            this.splitContainer2.Size = new System.Drawing.Size(1138, 1055);
            this.splitContainer2.SplitterDistance = 340;
            this.splitContainer2.TabIndex = 0;
            // 
            // ClassBar
            // 
            this.ClassBar.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.ClassBar.ChartAreas.Add(chartArea1);
            this.ClassBar.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ClassBar.Legends.Add(legend1);
            this.ClassBar.Location = new System.Drawing.Point(0, 0);
            this.ClassBar.Name = "ClassBar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Гістограма відносних частот";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Ядерна оцінка функції щільності розподілу";
            this.ClassBar.Series.Add(series1);
            this.ClassBar.Series.Add(series2);
            this.ClassBar.Size = new System.Drawing.Size(1138, 711);
            this.ClassBar.TabIndex = 1;
            this.ClassBar.Text = "Оцінки функції щільності розподілу";
            title1.Name = "Title1";
            title1.Text = "Оцінки функції щільності розподілу";
            this.ClassBar.Titles.Add(title1);
            this.ClassBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClassBar_MouseDoubleClick);
            // 
            // EmpiricalDistributionFunction
            // 
            chartArea2.Name = "ChartArea1";
            this.EmpiricalDistributionFunction.ChartAreas.Add(chartArea2);
            this.EmpiricalDistributionFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.EmpiricalDistributionFunction.Legends.Add(legend2);
            this.EmpiricalDistributionFunction.Location = new System.Drawing.Point(0, 0);
            this.EmpiricalDistributionFunction.Name = "EmpiricalDistributionFunction";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Legend = "Legend1";
            series3.Name = "Відносна частота";
            series3.YValuesPerPoint = 2;
            this.EmpiricalDistributionFunction.Series.Add(series3);
            this.EmpiricalDistributionFunction.Size = new System.Drawing.Size(1138, 711);
            this.EmpiricalDistributionFunction.TabIndex = 0;
            this.EmpiricalDistributionFunction.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Емпірична функція розподілу";
            this.EmpiricalDistributionFunction.Titles.Add(title2);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataAnalysis";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpiricalDistributionFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button browsingFilesButton;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmpiricalDistributionFunction;
        private System.Windows.Forms.Button ClassesSegregationButton;
        private System.Windows.Forms.Button VariationalSeries;
        private System.Windows.Forms.DataVisualization.Charting.Chart ClassBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}