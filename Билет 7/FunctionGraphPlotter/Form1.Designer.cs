namespace FunctionGraphPlotter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbY3 = new System.Windows.Forms.CheckBox();
            this.chbY2 = new System.Windows.Forms.CheckBox();
            this.chbY1 = new System.Windows.Forms.CheckBox();
            this.chartFunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbK1 = new System.Windows.Forms.TextBox();
            this.tbK2 = new System.Windows.Forms.TextBox();
            this.tbK3 = new System.Windows.Forms.TextBox();
            this.tbK4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).BeginInit();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(140, 26);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 22);
            this.tbA.TabIndex = 0;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(140, 54);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 22);
            this.tbB.TabIndex = 1;
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(140, 82);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(100, 22);
            this.tbStep.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbB);
            this.groupBox1.Controls.Add(this.tbStep);
            this.groupBox1.Controls.Add(this.tbA);
            this.groupBox1.Location = new System.Drawing.Point(659, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод исходных данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Шаг аргумента h:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Правая граница b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Левая граница a:";
            // 
            // dgvResults
            // 
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "N2";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.Location = new System.Drawing.Point(646, 187);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(284, 383);
            this.dgvResults.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.chbY3);
            this.groupBox2.Controls.Add(this.chbY2);
            this.groupBox2.Controls.Add(this.chbY1);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 59);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отображаемые графики";
            // 
            // chbY3
            // 
            this.chbY3.AutoSize = true;
            this.chbY3.Location = new System.Drawing.Point(450, 26);
            this.chbY3.Name = "chbY3";
            this.chbY3.Size = new System.Drawing.Size(124, 20);
            this.chbY3.TabIndex = 8;
            this.chbY3.Text = "y3=sin(x)+cos(x)";
            this.chbY3.UseVisualStyleBackColor = true;
            // 
            // chbY2
            // 
            this.chbY2.AutoSize = true;
            this.chbY2.Location = new System.Drawing.Point(264, 26);
            this.chbY2.Name = "chbY2";
            this.chbY2.Size = new System.Drawing.Size(86, 20);
            this.chbY2.TabIndex = 7;
            this.chbY2.Text = "y2=cos(x)";
            this.chbY2.UseVisualStyleBackColor = true;
            // 
            // chbY1
            // 
            this.chbY1.AutoSize = true;
            this.chbY1.Location = new System.Drawing.Point(45, 28);
            this.chbY1.Name = "chbY1";
            this.chbY1.Size = new System.Drawing.Size(81, 20);
            this.chbY1.TabIndex = 6;
            this.chbY1.Text = "y1=sin(x)";
            this.chbY1.UseVisualStyleBackColor = true;
            // 
            // chartFunctions
            // 
            this.chartFunctions.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.chartFunctions.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunctions.Legends.Add(legend1);
            this.chartFunctions.Location = new System.Drawing.Point(12, 114);
            this.chartFunctions.Name = "chartFunctions";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "SeriesY1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "SeriesY2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "SeriesY3";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "SeriesCustom";
            this.chartFunctions.Series.Add(series1);
            this.chartFunctions.Series.Add(series2);
            this.chartFunctions.Series.Add(series3);
            this.chartFunctions.Series.Add(series4);
            this.chartFunctions.Size = new System.Drawing.Size(628, 346);
            this.chartFunctions.TabIndex = 9;
            this.chartFunctions.Text = " ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 540);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(596, 44);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Построить график функции";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(40, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "y = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(169, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "* sin (";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(311, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "* x +";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(437, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = ") +";
            // 
            // tbK1
            // 
            this.tbK1.Location = new System.Drawing.Point(96, 494);
            this.tbK1.Name = "tbK1";
            this.tbK1.Size = new System.Drawing.Size(66, 22);
            this.tbK1.TabIndex = 6;
            // 
            // tbK2
            // 
            this.tbK2.Location = new System.Drawing.Point(236, 494);
            this.tbK2.Name = "tbK2";
            this.tbK2.Size = new System.Drawing.Size(66, 22);
            this.tbK2.TabIndex = 15;
            // 
            // tbK3
            // 
            this.tbK3.Location = new System.Drawing.Point(368, 491);
            this.tbK3.Name = "tbK3";
            this.tbK3.Size = new System.Drawing.Size(66, 22);
            this.tbK3.TabIndex = 16;
            // 
            // tbK4
            // 
            this.tbK4.Location = new System.Drawing.Point(479, 493);
            this.tbK4.Name = "tbK4";
            this.tbK4.Size = new System.Drawing.Size(66, 22);
            this.tbK4.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 598);
            this.Controls.Add(this.tbK4);
            this.Controls.Add(this.tbK3);
            this.Controls.Add(this.tbK2);
            this.Controls.Add(this.tbK1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chartFunctions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(955, 640);
            this.Name = "Form1";
            this.Text = "Приложение для построения графика функции";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbY1;
        private System.Windows.Forms.CheckBox chbY3;
        private System.Windows.Forms.CheckBox chbY2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbK1;
        private System.Windows.Forms.TextBox tbK2;
        private System.Windows.Forms.TextBox tbK3;
        private System.Windows.Forms.TextBox tbK4;
    }
}

