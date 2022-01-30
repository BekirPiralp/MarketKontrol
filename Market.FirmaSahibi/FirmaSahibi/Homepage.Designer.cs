
namespace Market.FirmaSahibi.FirmaSahibi
{
    partial class Homepage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartBayi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartBayi)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBayi
            // 
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chartBayi.ChartAreas.Add(chartArea4);
            this.chartBayi.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Bayiler";
            legend4.Title = "Bayiler";
            legend4.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chartBayi.Legends.Add(legend4);
            this.chartBayi.Location = new System.Drawing.Point(0, 0);
            this.chartBayi.Name = "chartBayi";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Bayiler";
            series4.Name = "Veri";
            this.chartBayi.Series.Add(series4);
            this.chartBayi.Size = new System.Drawing.Size(580, 428);
            this.chartBayi.TabIndex = 0;
            this.chartBayi.Text = "Satışa Göre Bayiler";
            title4.BackColor = System.Drawing.Color.White;
            title4.Font = new System.Drawing.Font("Monotype Corsiva", 25F);
            title4.Name = "Title1";
            title4.Text = "Bu Ay ki Ençok Satan İlk 20 Bayi";
            this.chartBayi.Titles.Add(title4);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 428);
            this.Controls.Add(this.chartBayi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(580, 428);
            this.Name = "Homepage";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBayi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBayi;
        private System.Windows.Forms.Timer timer1;
    }
}