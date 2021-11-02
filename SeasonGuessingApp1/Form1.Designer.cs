
namespace SeasonGuessingApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.loadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.getGuessBtn = new System.Windows.Forms.Button();
            this.param1Lbl = new System.Windows.Forms.Label();
            this.param1TextBox = new System.Windows.Forms.TextBox();
            this.param2TextBox = new System.Windows.Forms.TextBox();
            this.param2Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(13, 13);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(172, 23);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "load data";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(191, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(597, 426);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // getGuessBtn
            // 
            this.getGuessBtn.Location = new System.Drawing.Point(13, 42);
            this.getGuessBtn.Name = "getGuessBtn";
            this.getGuessBtn.Size = new System.Drawing.Size(172, 23);
            this.getGuessBtn.TabIndex = 2;
            this.getGuessBtn.Text = "get a guess";
            this.getGuessBtn.UseVisualStyleBackColor = true;
            this.getGuessBtn.Click += new System.EventHandler(this.getGuessBtn_Click);
            // 
            // param1Lbl
            // 
            this.param1Lbl.AutoSize = true;
            this.param1Lbl.Location = new System.Drawing.Point(13, 72);
            this.param1Lbl.Name = "param1Lbl";
            this.param1Lbl.Size = new System.Drawing.Size(72, 13);
            this.param1Lbl.TabIndex = 3;
            this.param1Lbl.Text = "температура";
            // 
            // param1TextBox
            // 
            this.param1TextBox.Location = new System.Drawing.Point(16, 89);
            this.param1TextBox.Name = "param1TextBox";
            this.param1TextBox.Size = new System.Drawing.Size(169, 20);
            this.param1TextBox.TabIndex = 4;
            // 
            // param2TextBox
            // 
            this.param2TextBox.Location = new System.Drawing.Point(16, 136);
            this.param2TextBox.Name = "param2TextBox";
            this.param2TextBox.Size = new System.Drawing.Size(169, 20);
            this.param2TextBox.TabIndex = 6;
            // 
            // param2Lbl
            // 
            this.param2Lbl.AutoSize = true;
            this.param2Lbl.Location = new System.Drawing.Point(13, 119);
            this.param2Lbl.Name = "param2Lbl";
            this.param2Lbl.Size = new System.Drawing.Size(72, 13);
            this.param2Lbl.TabIndex = 5;
            this.param2Lbl.Text = "температура";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.param2TextBox);
            this.Controls.Add(this.param2Lbl);
            this.Controls.Add(this.param1TextBox);
            this.Controls.Add(this.param1Lbl);
            this.Controls.Add(this.getGuessBtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.loadBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button getGuessBtn;
        private System.Windows.Forms.Label param1Lbl;
        private System.Windows.Forms.TextBox param1TextBox;
        private System.Windows.Forms.TextBox param2TextBox;
        private System.Windows.Forms.Label param2Lbl;
    }
}

