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

namespace FunctionGraphPlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
            SetupDataGridView();
        }
        private void InitializeChart()
        {
            chartFunctions.Series.Clear();

            // Добавляем серии для всех функций
            AddChartSeries("SeriesY1", "y1 = sin(x)", Color.Red);
            AddChartSeries("SeriesY2", "y2 = cos(x)", Color.Blue);
            AddChartSeries("SeriesY3", "y3 = sin(x) + cos(x)", Color.Green);
            AddChartSeries("SeriesCustom", "y = k1*sin(k2*x + k3) + k4", Color.Purple);

            // Настраиваем внешний вид графика
            chartFunctions.ChartAreas[0].AxisX.Title = "X";
            chartFunctions.ChartAreas[0].AxisY.Title = "Y";
            chartFunctions.Titles.Add("Графики функций");
        }

        private void AddChartSeries(string name, string legendText, Color color)
        {
            var series = new Series
            {
                Name = name,
                ChartType = SeriesChartType.Spline,
                BorderWidth = 1,
                Color = color,
                LegendText = legendText,
                IsVisibleInLegend = true,
                Enabled = false // По умолчанию все графики скрыты
            };
            chartFunctions.Series.Add(series);
        }

        private void SetupDataGridView()
        {
            dgvResults.AutoGenerateColumns = true;
            dgvResults.AllowUserToAddRows = false;
            dgvResults.ReadOnly = true;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            // Получаем параметры
            double a = double.Parse(tbA.Text);
            double b = double.Parse(tbB.Text);
            double step = double.Parse(tbStep.Text);

            bool hasCustomFunction = ValidateCustomFunction(out double k1, out double k2, out double k3, out double k4);

            DataTable resultsTable = CreateResultsTable(hasCustomFunction);
            ClearAllChartSeries();

            // Вычисляем значения функций и заполняем таблицу
            CalculateFunctions(a, b, step, hasCustomFunction, k1, k2, k3, k4, resultsTable);

            dgvResults.DataSource = resultsTable;
            UpdateChartVisibility();
        }

        private bool ValidateInputs()
        {
            // Проверка границ и шага
            if (!double.TryParse(tbA.Text, out double a) ||
                !double.TryParse(tbB.Text, out double b) ||
                !double.TryParse(tbStep.Text, out double step))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для границ и шага", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (a >= b)
            {
                MessageBox.Show("Левая граница должна быть меньше правой границы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (step <= 0)
            {
                MessageBox.Show("Шаг аргумента должен быть положительным числом", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateCustomFunction(out double k1, out double k2, out double k3, out double k4)
        {
            k1 = k2 = k3 = k4 = 0;

            // Проверяем, что все поля коэффициентов заполнены
            if (string.IsNullOrWhiteSpace(tbK1.Text) ||
                string.IsNullOrWhiteSpace(tbK2.Text) ||
                string.IsNullOrWhiteSpace(tbK3.Text) ||
                string.IsNullOrWhiteSpace(tbK4.Text))
            {
                return false;
            }

            // Проверяем, что все значения числовые
            if (!double.TryParse(tbK1.Text, out k1) ||
                !double.TryParse(tbK2.Text, out k2) ||
                !double.TryParse(tbK3.Text, out k3) ||
                !double.TryParse(tbK4.Text, out k4))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для всех коэффициентов", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private DataTable CreateResultsTable(bool includeCustomFunction)
        {
            DataTable table = new DataTable();
            table.Columns.Add("X", typeof(double));

            if (chbY1.Checked) table.Columns.Add("sin(x)", typeof(double));
            if (chbY2.Checked) table.Columns.Add("cos(x)", typeof(double));
            if (chbY3.Checked) table.Columns.Add("sin(x)+cos(x)", typeof(double));
            if (includeCustomFunction) table.Columns.Add($"y = {tbK1.Text}*sin({tbK2.Text}*x + {tbK3.Text}) + {tbK4.Text}", typeof(double));

            return table;
        }

        private void ClearAllChartSeries()
        {
            foreach (var series in chartFunctions.Series)
            {
                series.Points.Clear();
                series.Enabled = false;
            }
        }

        private void CalculateFunctions(double a, double b, double step, bool hasCustomFunction,
                                      double k1, double k2, double k3, double k4, DataTable resultsTable)
        {
            for (double x = a; x <= b; x += step)
            {
                DataRow row = resultsTable.NewRow();
                row["X"] = Math.Round(x, 4);

                double y1 = 0, y2 = 0, y3 = 0, yCustom = 0;

                // Вычисляем значения функций
                if (chbY1.Checked)
                {
                    y1 = Math.Sin(x);
                    row["sin(x)"] = Math.Round(y1, 4);
                    chartFunctions.Series["SeriesY1"].Points.AddXY(x, y1);
                }

                if (chbY2.Checked)
                {
                    y2 = Math.Cos(x);
                    row["cos(x)"] = Math.Round(y2, 4);
                    chartFunctions.Series["SeriesY2"].Points.AddXY(x, y2);
                }

                if (chbY3.Checked)
                {
                    y3 = Math.Sin(x) + Math.Cos(x);
                    row["sin(x)+cos(x)"] = Math.Round(y3, 4);
                    chartFunctions.Series["SeriesY3"].Points.AddXY(x, y3);
                }

                if (hasCustomFunction)
                {
                    yCustom = k1 * Math.Sin(k2 * x + k3) + k4;
                    row[$"y = {tbK1.Text}*sin({tbK2.Text}*x + {tbK3.Text}) + {tbK4.Text}"] = Math.Round(yCustom, 4);
                    chartFunctions.Series["SeriesCustom"].Points.AddXY(x, yCustom);
                }

                resultsTable.Rows.Add(row);
            }
        }

        private void UpdateChartVisibility()
        {
            // Обновляем видимость серий на графике
            chartFunctions.Series["SeriesY1"].Enabled = chbY1.Checked;
            chartFunctions.Series["SeriesY2"].Enabled = chbY2.Checked;
            chartFunctions.Series["SeriesY3"].Enabled = chbY3.Checked;

            // Проверяем, есть ли пользовательская функция
            bool hasCustomFunction = ValidateCustomFunction(out _, out _, out _, out _);
            chartFunctions.Series["SeriesCustom"].Enabled = hasCustomFunction;
        }

        private void tbK1_TextChanged(object sender, EventArgs e)
        {
            HighlightInvalidInput(tbK1);
        }

        private void tbK2_TextChanged(object sender, EventArgs e)
        {
            HighlightInvalidInput(tbK2);
        }

        private void tbK3_TextChanged(object sender, EventArgs e)
        {
            HighlightInvalidInput(tbK3);
        }

        private void tbK4_TextChanged(object sender, EventArgs e)
        {
            HighlightInvalidInput(tbK4);
        }

        private void HighlightInvalidInput(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && !double.TryParse(textBox.Text, out _))
            {
                textBox.BackColor = Color.LightPink;
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
            }
        }
    }
}
