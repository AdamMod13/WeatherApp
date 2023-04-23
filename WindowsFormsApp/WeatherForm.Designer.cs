namespace WindowsFormsApp
{
    partial class WeatherForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.CountryInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CitiesList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.TempChart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New City";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(9, 30);
            this.CityInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(76, 20);
            this.CityInput.TabIndex = 1;
            // 
            // CountryInput
            // 
            this.CountryInput.Location = new System.Drawing.Point(106, 30);
            this.CountryInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountryInput.Name = "CountryInput";
            this.CountryInput.Size = new System.Drawing.Size(76, 20);
            this.CountryInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CitiesList
            // 
            this.CitiesList.FormattingEnabled = true;
            this.CitiesList.Location = new System.Drawing.Point(9, 94);
            this.CitiesList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CitiesList.Name = "CitiesList";
            this.CitiesList.Size = new System.Drawing.Size(173, 199);
            this.CitiesList.TabIndex = 5;
            this.CitiesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entered Values";
            // 
            // TempChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TempChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TempChart.Legends.Add(legend1);
            this.TempChart.Location = new System.Drawing.Point(205, 79);
            this.TempChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TempChart.Name = "TempChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Current temp.";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Min. temp.";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Max. temp.";
            this.TempChart.Series.Add(series1);
            this.TempChart.Series.Add(series2);
            this.TempChart.Series.Add(series3);
            this.TempChart.Size = new System.Drawing.Size(386, 244);
            this.TempChart.TabIndex = 7;
            this.TempChart.Text = "TempChart";
            title1.Name = "Temperatures";
            title1.Text = "Temperatures";
            this.TempChart.Titles.Add(title1);
            this.TempChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(10, 303);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(171, 19);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "SELECT AND DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // mapControl
            // 
            this.mapControl.Bearing = 0F;
            this.mapControl.CanDragMap = true;
            this.mapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapControl.GrayScaleMode = false;
            this.mapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapControl.LevelsKeepInMemory = 5;
            this.mapControl.Location = new System.Drawing.Point(632, 30);
            this.mapControl.MarkersEnabled = true;
            this.mapControl.MaxZoom = 2;
            this.mapControl.MinZoom = 2;
            this.mapControl.MouseWheelZoomEnabled = true;
            this.mapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapControl.Name = "mapControl";
            this.mapControl.NegativeMode = false;
            this.mapControl.PolygonsEnabled = true;
            this.mapControl.RetryLoadTile = 0;
            this.mapControl.RoutesEnabled = true;
            this.mapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapControl.ShowTileGridLines = false;
            this.mapControl.Size = new System.Drawing.Size(531, 293);
            this.mapControl.TabIndex = 9;
            this.mapControl.Zoom = 0D;
            this.mapControl.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 360);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TempChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CitiesList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryInput);
            this.Controls.Add(this.CityInput);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WeatherForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TempChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.TextBox CountryInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox CitiesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempChart;
        private System.Windows.Forms.Button DeleteButton;
        private GMap.NET.WindowsForms.GMapControl mapControl;
    }
}

