namespace FuncOperationsApplication
{
    partial class StartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Interesectionbtn = new System.Windows.Forms.Button();
            this.UnionBtn = new System.Windows.Forms.Button();
            this.moreFbtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.showAllbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 41);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(496, 432);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Interesectionbtn
            // 
            this.Interesectionbtn.Location = new System.Drawing.Point(15, 12);
            this.Interesectionbtn.Name = "Interesectionbtn";
            this.Interesectionbtn.Size = new System.Drawing.Size(95, 23);
            this.Interesectionbtn.TabIndex = 3;
            this.Interesectionbtn.Text = "Пересечениие";
            this.Interesectionbtn.UseVisualStyleBackColor = true;
            this.Interesectionbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UnionBtn
            // 
            this.UnionBtn.Location = new System.Drawing.Point(116, 12);
            this.UnionBtn.Name = "UnionBtn";
            this.UnionBtn.Size = new System.Drawing.Size(95, 23);
            this.UnionBtn.TabIndex = 4;
            this.UnionBtn.Text = "Объединение";
            this.UnionBtn.UseVisualStyleBackColor = true;
            this.UnionBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // moreFbtn
            // 
            this.moreFbtn.Location = new System.Drawing.Point(217, 12);
            this.moreFbtn.Name = "moreFbtn";
            this.moreFbtn.Size = new System.Drawing.Size(85, 23);
            this.moreFbtn.TabIndex = 9;
            this.moreFbtn.Text = "more functions";
            this.moreFbtn.UseVisualStyleBackColor = true;
            this.moreFbtn.Click += new System.EventHandler(this.moreFbtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(462, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // showAllbtn
            // 
            this.showAllbtn.Location = new System.Drawing.Point(397, 11);
            this.showAllbtn.Name = "showAllbtn";
            this.showAllbtn.Size = new System.Drawing.Size(59, 23);
            this.showAllbtn.TabIndex = 11;
            this.showAllbtn.Text = "Show all";
            this.showAllbtn.UseVisualStyleBackColor = true;
            this.showAllbtn.Click += new System.EventHandler(this.showAllbtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 485);
            this.Controls.Add(this.showAllbtn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.moreFbtn);
            this.Controls.Add(this.UnionBtn);
            this.Controls.Add(this.Interesectionbtn);
            this.Controls.Add(this.chart1);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Interesectionbtn;
        private System.Windows.Forms.Button UnionBtn;
        private System.Windows.Forms.Button moreFbtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button showAllbtn;
    }
}

