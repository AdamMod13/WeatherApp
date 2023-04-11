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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.CountryInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CitiesList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TempChart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New City";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(12, 37);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(100, 22);
            this.CityInput.TabIndex = 1;
            // 
            // CountryInput
            // 
            this.CountryInput.Location = new System.Drawing.Point(141, 37);
            this.CountryInput.Name = "CountryInput";
            this.CountryInput.Size = new System.Drawing.Size(100, 22);
            this.CountryInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CitiesList
            // 
            this.CitiesList.FormattingEnabled = true;
            this.CitiesList.ItemHeight = 16;
            this.CitiesList.Location = new System.Drawing.Point(12, 116);
            this.CitiesList.Name = "CitiesList";
            this.CitiesList.Size = new System.Drawing.Size(229, 244);
            this.CitiesList.TabIndex = 5;
            this.CitiesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entered Values";
            // 
            // TempChart
            // 
            chartArea3.Name = "ChartArea1";
            this.TempChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.TempChart.Legends.Add(legend3);
            this.TempChart.Location = new System.Drawing.Point(273, 97);
            this.TempChart.Name = "TempChart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Current temp.";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Min. temp.";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Max. temp.";
            this.TempChart.Series.Add(series7);
            this.TempChart.Series.Add(series8);
            this.TempChart.Series.Add(series9);
            this.TempChart.Size = new System.Drawing.Size(515, 300);
            this.TempChart.TabIndex = 7;
            this.TempChart.Text = "TempChart";
            title3.Name = "Temperatures";
            title3.Text = "Temperatures";
            this.TempChart.Titles.Add(title3);
            this.TempChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(13, 373);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(228, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "SELECT AND DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TempChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CitiesList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryInput);
            this.Controls.Add(this.CityInput);
            this.Controls.Add(this.button1);
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
    }
}

