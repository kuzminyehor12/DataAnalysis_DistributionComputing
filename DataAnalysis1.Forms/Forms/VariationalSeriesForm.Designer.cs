
namespace DataAnalysis1.Forms
{
    partial class VariationalSeriesForm
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
            this.VariationalSeriesScheme = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelativeFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpiricalDistributionFunctionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VariationalSeriesScheme)).BeginInit();
            this.SuspendLayout();
            // 
            // VariationalSeriesScheme
            // 
            this.VariationalSeriesScheme.AllowUserToAddRows = false;
            this.VariationalSeriesScheme.AllowUserToDeleteRows = false;
            this.VariationalSeriesScheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VariationalSeriesScheme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Value,
            this.Frequency,
            this.RelativeFrequency,
            this.EmpiricalDistributionFunctionValue});
            this.VariationalSeriesScheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariationalSeriesScheme.Location = new System.Drawing.Point(0, 0);
            this.VariationalSeriesScheme.Name = "VariationalSeriesScheme";
            this.VariationalSeriesScheme.RowHeadersWidth = 51;
            this.VariationalSeriesScheme.Size = new System.Drawing.Size(927, 296);
            this.VariationalSeriesScheme.TabIndex = 0;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер варіанти";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 125;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значення варіанти";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.Width = 125;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Частота";
            this.Frequency.MinimumWidth = 6;
            this.Frequency.Name = "Frequency";
            this.Frequency.Width = 125;
            // 
            // RelativeFrequency
            // 
            this.RelativeFrequency.HeaderText = "Відносна частота";
            this.RelativeFrequency.MinimumWidth = 6;
            this.RelativeFrequency.Name = "RelativeFrequency";
            this.RelativeFrequency.Width = 125;
            // 
            // EmpiricalDistributionFunctionValue
            // 
            this.EmpiricalDistributionFunctionValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpiricalDistributionFunctionValue.HeaderText = "Значення емпірічної функції розподілу";
            this.EmpiricalDistributionFunctionValue.MinimumWidth = 6;
            this.EmpiricalDistributionFunctionValue.Name = "EmpiricalDistributionFunctionValue";
            // 
            // VariationalSeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 296);
            this.Controls.Add(this.VariationalSeriesScheme);
            this.Name = "VariationalSeriesForm";
            this.Text = "VariationalSeriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.VariationalSeriesScheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VariationalSeriesScheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelativeFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpiricalDistributionFunctionValue;
    }
}

