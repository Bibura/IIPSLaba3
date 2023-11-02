using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba3
{
    public partial class ChartTree : Form
    {
        SetOfMatrix matrix = new SetOfMatrix();
        public ChartTree()
        {
            InitializeComponent();
        }

        private void ChartTree_Load(object sender, EventArgs e)
        {
            ChartArea chartArea = chart1.ChartAreas[0];

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Y");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 5;
            series.Points.DataBindY(matrix.Y);


            // Створіть другий графік
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series("X3");
            series1.ChartType = SeriesChartType.Line;
            series1.BorderWidth = 5;
            series1.Points.DataBindY(matrix.X3);

            chart1.Series.Add(series);
            chart1.Series.Add(series1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void reloadOriginalChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            ChartArea chartArea = chart1.ChartAreas[0];

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Y");
            series.ChartType = SeriesChartType.FastLine;
            series.BorderWidth = 5;
            series.Points.DataBindY(matrix.Y);


            // Створіть другий графік
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series("X3");
            series1.ChartType = SeriesChartType.FastLine;
            series1.BorderWidth = 5;
            series1.Points.DataBindY(matrix.X3);

            chart1.Series.Add(series);
            chart1.Series.Add(series1);
        }

        private void regressionEquasionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var regressionCoefficients = Fit.Line(matrix.Y, matrix.X3);

            double slope = regressionCoefficients.Item2;
            double intercept = regressionCoefficients.Item1;

            string equation1 = $"X3 = {slope} * Y + {intercept}";

            MessageBox.Show(equation1);

            chart1.Series.Clear();
            ChartArea chartArea = chart1.ChartAreas[0];

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Y");
            series.ChartType = SeriesChartType.Line;

            // Додайте дані точок для вашої прямої (приклад)
            double a = intercept;
            double b = slope;
            for (int i = 0; i < matrix.Y.Length; i++)
            {
                double y = a + b * matrix.Y[i];
                series.Points.AddXY(matrix.Y[i], y);
            }
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series("X3");
            series2.ChartType = SeriesChartType.FastPoint;
            series2.BorderWidth = 5;

            // Додайте дані до серії
            for (int i = 0; i < matrix.Y.Length; i++)
            {
                series2.Points.AddXY(matrix.Y[i], matrix.X3[i]);
            }

            // Додайте рядок до графіка
            chart1.Series.Add(series);
            // Додайте рядок до графіка
            chart1.Series.Add(series2);

            // Відобразіть графік на формі
            chart1.Dock = DockStyle.Fill;
        }
    }
}
