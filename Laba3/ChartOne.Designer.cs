namespace Laba3
{
    partial class ChartOne
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reloadOriginalChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regressionEquasionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 27);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1034, 602);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadOriginalChartToolStripMenuItem,
            this.regressionEquasionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reloadOriginalChartToolStripMenuItem
            // 
            this.reloadOriginalChartToolStripMenuItem.Name = "reloadOriginalChartToolStripMenuItem";
            this.reloadOriginalChartToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.reloadOriginalChartToolStripMenuItem.Text = "Reload original chart";
            this.reloadOriginalChartToolStripMenuItem.Click += new System.EventHandler(this.reloadOriginalChartToolStripMenuItem_Click);
            // 
            // regressionEquasionToolStripMenuItem
            // 
            this.regressionEquasionToolStripMenuItem.Name = "regressionEquasionToolStripMenuItem";
            this.regressionEquasionToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.regressionEquasionToolStripMenuItem.Text = "Regression equasion";
            this.regressionEquasionToolStripMenuItem.Click += new System.EventHandler(this.regressionEquasionToolStripMenuItem_Click);
            // 
            // ChartOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 641);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChartOne";
            this.Text = "ChartOne";
            this.Load += new System.EventHandler(this.ChartOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reloadOriginalChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regressionEquasionToolStripMenuItem;
    }
}