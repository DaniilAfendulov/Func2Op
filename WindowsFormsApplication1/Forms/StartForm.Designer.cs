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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Interesectionbtn = new System.Windows.Forms.Button();
            this.UnionBtn = new System.Windows.Forms.Button();
            this.AddPoint1 = new System.Windows.Forms.Button();
            this.AddPoint2 = new System.Windows.Forms.Button();
            this.Ch1Btn = new System.Windows.Forms.Button();
            this.Ch2Btn = new System.Windows.Forms.Button();
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 68);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(496, 405);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1 0;2 1;3 0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "";
            this.textBox2.Text = "1 0;2 1;3 0";
            // 
            // Interesectionbtn
            // 
            this.Interesectionbtn.Location = new System.Drawing.Point(13, 39);
            this.Interesectionbtn.Name = "Interesectionbtn";
            this.Interesectionbtn.Size = new System.Drawing.Size(95, 23);
            this.Interesectionbtn.TabIndex = 3;
            this.Interesectionbtn.Text = "Пересечениие";
            this.Interesectionbtn.UseVisualStyleBackColor = true;
            this.Interesectionbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UnionBtn
            // 
            this.UnionBtn.Location = new System.Drawing.Point(114, 39);
            this.UnionBtn.Name = "UnionBtn";
            this.UnionBtn.Size = new System.Drawing.Size(95, 23);
            this.UnionBtn.TabIndex = 4;
            this.UnionBtn.Text = "Объединение";
            this.UnionBtn.UseVisualStyleBackColor = true;
            this.UnionBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPoint1
            // 
            this.AddPoint1.Location = new System.Drawing.Point(215, 12);
            this.AddPoint1.Name = "AddPoint1";
            this.AddPoint1.Size = new System.Drawing.Size(24, 20);
            this.AddPoint1.TabIndex = 5;
            this.AddPoint1.Text = "+";
            this.AddPoint1.UseVisualStyleBackColor = true;
            this.AddPoint1.Click += new System.EventHandler(this.AddPoint1_Click);
            // 
            // AddPoint2
            // 
            this.AddPoint2.Location = new System.Drawing.Point(460, 12);
            this.AddPoint2.Name = "AddPoint2";
            this.AddPoint2.Size = new System.Drawing.Size(24, 20);
            this.AddPoint2.TabIndex = 6;
            this.AddPoint2.Text = "+";
            this.AddPoint2.UseVisualStyleBackColor = true;
            this.AddPoint2.Click += new System.EventHandler(this.AddPoint2_Click);
            // 
            // Ch1Btn
            // 
            this.Ch1Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Ch1Btn.Location = new System.Drawing.Point(239, 12);
            this.Ch1Btn.Name = "Ch1Btn";
            this.Ch1Btn.Size = new System.Drawing.Size(24, 20);
            this.Ch1Btn.TabIndex = 7;
            this.Ch1Btn.Text = "Ch";
            this.Ch1Btn.UseVisualStyleBackColor = true;
            this.Ch1Btn.Click += new System.EventHandler(this.Ch1Btn_Click);
            // 
            // Ch2Btn
            // 
            this.Ch2Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Ch2Btn.Location = new System.Drawing.Point(484, 12);
            this.Ch2Btn.Name = "Ch2Btn";
            this.Ch2Btn.Size = new System.Drawing.Size(24, 20);
            this.Ch2Btn.TabIndex = 8;
            this.Ch2Btn.Text = "Ch";
            this.Ch2Btn.UseVisualStyleBackColor = true;
            this.Ch2Btn.Click += new System.EventHandler(this.Ch2Btn_Click);
            // 
            // moreFbtn
            // 
            this.moreFbtn.Location = new System.Drawing.Point(215, 39);
            this.moreFbtn.Name = "moreFbtn";
            this.moreFbtn.Size = new System.Drawing.Size(85, 23);
            this.moreFbtn.TabIndex = 9;
            this.moreFbtn.Text = "more functions";
            this.moreFbtn.UseVisualStyleBackColor = true;
            this.moreFbtn.Click += new System.EventHandler(this.moreFbtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(460, 42);
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
            this.showAllbtn.Location = new System.Drawing.Point(395, 38);
            this.showAllbtn.Name = "showAllbtn";
            this.showAllbtn.Size = new System.Drawing.Size(59, 23);
            this.showAllbtn.TabIndex = 11;
            this.showAllbtn.Text = "Show all";
            this.showAllbtn.UseVisualStyleBackColor = true;
            this.showAllbtn.Click += new System.EventHandler(this.showAllbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 485);
            this.Controls.Add(this.showAllbtn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.moreFbtn);
            this.Controls.Add(this.Ch2Btn);
            this.Controls.Add(this.Ch1Btn);
            this.Controls.Add(this.AddPoint2);
            this.Controls.Add(this.AddPoint1);
            this.Controls.Add(this.UnionBtn);
            this.Controls.Add(this.Interesectionbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Interesectionbtn;
        private System.Windows.Forms.Button UnionBtn;
        private System.Windows.Forms.Button AddPoint1;
        private System.Windows.Forms.Button AddPoint2;
        private System.Windows.Forms.Button Ch1Btn;
        private System.Windows.Forms.Button Ch2Btn;
        private System.Windows.Forms.Button moreFbtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button showAllbtn;
    }
}

