
namespace DataAnalysis1.Forms.Forms
{
    partial class CharacteristicsEstimationForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Charasteristic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandartDeviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrustedInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Charasteristic,
            this.Value,
            this.StandartDeviation,
            this.TrustedInterval});
            this.dataGridView2.Location = new System.Drawing.Point(0, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1125, 281);
            this.dataGridView2.TabIndex = 1;
            // 
            // Charasteristic
            // 
            this.Charasteristic.HeaderText = "Оцінка";
            this.Charasteristic.MinimumWidth = 6;
            this.Charasteristic.Name = "Charasteristic";
            this.Charasteristic.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значення";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // StandartDeviation
            // 
            this.StandartDeviation.HeaderText = "Середньоквадратичне відхилення";
            this.StandartDeviation.MinimumWidth = 6;
            this.StandartDeviation.Name = "StandartDeviation";
            this.StandartDeviation.ReadOnly = true;
            // 
            // TrustedInterval
            // 
            this.TrustedInterval.HeaderText = "95% довірчий інтервал";
            this.TrustedInterval.MinimumWidth = 6;
            this.TrustedInterval.Name = "TrustedInterval";
            this.TrustedInterval.ReadOnly = true;
            // 
            // CharacteristicsEstimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 377);
            this.Controls.Add(this.dataGridView2);
            this.Name = "CharacteristicsEstimationForm";
            this.Text = "CharacteristicsEstimationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charasteristic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandartDeviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrustedInterval;
    }
}