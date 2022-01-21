﻿
namespace Market.MarketKontrol.Mudur
{
    partial class FrmHomepage
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
            this.chartSatis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSatis
            // 
            this.chartSatis.BackColor = System.Drawing.Color.Transparent;
            this.chartSatis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartSatis.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.HorizontalBrick;
            this.chartSatis.BorderlineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "GrafikSatislar";
            this.chartSatis.ChartAreas.Add(chartArea1);
            this.chartSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackSecondaryColor = System.Drawing.Color.White;
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            legend1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            legend1.Name = "Urunler";
            legend1.Title = "Ürünler";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleFont = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Bold);
            this.chartSatis.Legends.Add(legend1);
            this.chartSatis.Location = new System.Drawing.Point(0, 0);
            this.chartSatis.MinimumSize = new System.Drawing.Size(580, 428);
            this.chartSatis.Name = "chartSatis";
            this.chartSatis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "GrafikSatislar";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Urunler";
            series1.Name = "VeriSerisi";
            series1.YValuesPerPoint = 4;
            this.chartSatis.Series.Add(series1);
            this.chartSatis.Size = new System.Drawing.Size(580, 428);
            this.chartSatis.TabIndex = 0;
            this.chartSatis.Text = "Satişlar";
            title1.BackColor = System.Drawing.Color.Gray;
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            title1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Aylık Satış Dağılımı";
            this.chartSatis.Titles.Add(title1);
            // 
            // FrmHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.chartSatis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "FrmHomepage";
            this.Text = "Ana Ekran";
            ((System.ComponentModel.ISupportInitialize)(this.chartSatis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSatis;
    }
}