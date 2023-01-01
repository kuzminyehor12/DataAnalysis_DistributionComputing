
namespace DataAnalysis1.Forms.Forms
{
    partial class ClassesSegregationForm
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
            this.ClassSegregationScheme = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassLimits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelativeFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpiricalDistributionFunctionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClassSegregationScheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassSegregationScheme
            // 
            this.ClassSegregationScheme.AllowUserToAddRows = false;
            this.ClassSegregationScheme.AllowUserToDeleteRows = false;
            this.ClassSegregationScheme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassSegregationScheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassSegregationScheme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ClassLimits,
            this.Frequency,
            this.RelativeFrequency,
            this.EmpiricalDistributionFunctionValue});
            this.ClassSegregationScheme.Location = new System.Drawing.Point(0, 0);
            this.ClassSegregationScheme.Name = "ClassSegregationScheme";
            this.ClassSegregationScheme.RowHeadersWidth = 51;
            this.ClassSegregationScheme.RowTemplate.Height = 24;
            this.ClassSegregationScheme.Size = new System.Drawing.Size(1151, 270);
            this.ClassSegregationScheme.TabIndex = 3;
            // 
            // Number
            // 
            this.Number.FillWeight = 47.14846F;
            this.Number.HeaderText = "Номер класу";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // ClassLimits
            // 
            this.ClassLimits.FillWeight = 133.6898F;
            this.ClassLimits.HeaderText = "Межі класу";
            this.ClassLimits.MinimumWidth = 6;
            this.ClassLimits.Name = "ClassLimits";
            this.ClassLimits.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.FillWeight = 59.12541F;
            this.Frequency.HeaderText = "Частота";
            this.Frequency.MinimumWidth = 6;
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // RelativeFrequency
            // 
            this.RelativeFrequency.FillWeight = 98.4224F;
            this.RelativeFrequency.HeaderText = "Відносна частота";
            this.RelativeFrequency.MinimumWidth = 6;
            this.RelativeFrequency.Name = "RelativeFrequency";
            this.RelativeFrequency.ReadOnly = true;
            // 
            // EmpiricalDistributionFunctionValue
            // 
            this.EmpiricalDistributionFunctionValue.FillWeight = 161.6139F;
            this.EmpiricalDistributionFunctionValue.HeaderText = "Значення емпіричної функції розподілу";
            this.EmpiricalDistributionFunctionValue.MinimumWidth = 6;
            this.EmpiricalDistributionFunctionValue.Name = "EmpiricalDistributionFunctionValue";
            this.EmpiricalDistributionFunctionValue.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(38, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кількість класів:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(221, 276);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.ClassSegregationScheme);
            this.splitContainer1.Size = new System.Drawing.Size(937, 389);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(505, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ширина екрану:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(679, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // ClassesSegregationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 389);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ClassesSegregationForm";
            this.Text = "ClassesSegregationForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClassSegregationScheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClassSegregationScheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassLimits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelativeFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpiricalDistributionFunctionValue;
    }
}