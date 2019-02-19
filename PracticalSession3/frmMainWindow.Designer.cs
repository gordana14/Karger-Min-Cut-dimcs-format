namespace PracticalSession3
{
    partial class frmMainWindow
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKarger = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.chartBest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAll = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartBest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAll)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read Instance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKarger
            // 
            this.btnKarger.Location = new System.Drawing.Point(647, 12);
            this.btnKarger.Name = "btnKarger";
            this.btnKarger.Size = new System.Drawing.Size(75, 23);
            this.btnKarger.TabIndex = 1;
            this.btnKarger.Text = "Karger alg";
            this.btnKarger.UseVisualStyleBackColor = true;
            this.btnKarger.Click += new System.EventHandler(this.btnKarger_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(500, 41);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(235, 50);
            this.tbResult.TabIndex = 2;
            // 
            // chartBest
            // 
            chartArea1.Name = "best solution";
            this.chartBest.ChartAreas.Add(chartArea1);
            this.chartBest.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            legend1.Name = "Legend1";
            this.chartBest.Legends.Add(legend1);
            this.chartBest.Location = new System.Drawing.Point(0, 97);
            this.chartBest.Name = "chartBest";
            series1.ChartArea = "best solution";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            this.chartBest.Series.Add(series1);
            this.chartBest.Size = new System.Drawing.Size(372, 353);
            this.chartBest.TabIndex = 3;
            this.chartBest.Text = "chartBest";
            title1.Name = "Title1";
            title1.Text = "Best solution";
            this.chartBest.Titles.Add(title1);
            // 
            // chartAll
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAll.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAll.Legends.Add(legend2);
            this.chartAll.Location = new System.Drawing.Point(378, 97);
            this.chartAll.Name = "chartAll";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.CustomProperties = "LabelStyle=Top";
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Series1";
            this.chartAll.Series.Add(series2);
            this.chartAll.Size = new System.Drawing.Size(418, 353);
            this.chartAll.TabIndex = 4;
            this.chartAll.Text = "chartAll";
            title2.Name = "Obtained solution";
            title2.Text = "Obtained solution";
            this.chartAll.Titles.Add(title2);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(419, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Delete instance";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chartAll);
            this.Controls.Add(this.chartBest);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnKarger);
            this.Controls.Add(this.button1);
            this.Name = "frmMainWindow";
            this.Text = "frmMainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.chartBest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKarger;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBest;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAll;
        private System.Windows.Forms.Button btnRefresh;
    }
}