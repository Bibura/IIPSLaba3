using MathNet.Numerics;
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

namespace Laba3
{
    public partial class Form1 : Form
    {
            SetOfMatrix matrix = new SetOfMatrix();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ваш масив даних

        // Отримайте посилання на ChartArea графіка
        ChartArea chartArea = chart1.ChartAreas[0];

            // Створіть новий графік і додайте його до ChartArea
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Y");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 5;
            series.Points.DataBindY(matrix.Y);

            // Створіть другий графік
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series("X1");
            series1.ChartType = SeriesChartType.Line;
            series1.BorderWidth = 5;
            series1.Points.DataBindY(matrix.X1);

            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series("X2");
            series2.ChartType = SeriesChartType.Line;
            series2.BorderWidth = 5;
            series2.Points.DataBindY(matrix.X2);

            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series("X3");
            series3.ChartType = SeriesChartType.Line;
            series3.BorderWidth = 5;
            series3.Points.DataBindY(matrix.X3);

            // Додайте обидва графіки до Chart
            chart1.Series.Add(series);
            chart2.Series.Add(series);
            chart3.Series.Add(series);
            chart1.Series.Add(series1);
            chart2.Series.Add(series2);
            chart3.Series.Add(series3);

            for(int i = 0; i < matrix.Y.Length; i++)
            {
                dataGridView1.Rows.Add(i+1, matrix.Y[i], matrix.X1[i], matrix.X2[i], matrix.X3[i]);
            }
            
            dataGridView1.Rows[0].Cells[5].Value = "R1(Y-X1) = " + matrix.CountR1();
            dataGridView1.Rows[1].Cells[5].Value = "R2(Y-X2) = " + matrix.CountR2();
            dataGridView1.Rows[2].Cells[5].Value = "R3(Y-X3) = " + matrix.CountR3();

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            ChartOne chartOne = new ChartOne();
            chartOne.Show();
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            ChartTwo chartTwo = new ChartTwo();
            chartTwo.Show();
        }

        private void chart3_Click(object sender, EventArgs e)
        {
            ChartTree chartTree = new ChartTree();
            chartTree.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var regressionCoefficients = Fit.Line(matrix.X1, matrix.X2);

            //double slope = regressionCoefficients.Item2;
            //double intercept = regressionCoefficients.Item1;

            //string equation1 = $"X2 = {slope} * X1 + {intercept}";
            //MessageBox.Show(equation1);

            double[] X1 = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            double[] X2 = new double[] { 843, 845, 870, 880, 910, 920, 920, 930, 945, 940, 955, 950, 945, 950, 960, 950 };
            // Перевірка, чи масиви мають однаковий розмір
            if (X1.Length != X2.Length)
            {
                throw new ArgumentException("Масиви мають різний розмір.");
            }

            // Створення точок з даними
            var dataPoints = new List<DataPoint>();
            for (int i = 0; i < X1.Length; i++)
            {
                dataPoints.Add(new DataPoint(X1[i], X2[i]));
            }

            // Розрахунок лінії тренду
            var trend = Fit.Line(X1, X2);

            // Розрахунок регресивної кривої (наприклад, поліном другого ступеня)
            var regression = Fit.Polynomial(X1, X2, 2); // Змініть ступінь полінома за потреби

            // Виведення результатів
            MessageBox.Show($"Лінія тренду: y = {trend.Item2}x + {trend.Item1}");
            MessageBox.Show($"Регресивна крива: y = {regression[2]}x^2 + {regression[1]}x + {regression[0]}");
        }
    }
}
