namespace FuncOperationsApplication
{
    partial class FunctionsForm
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
            this.AddFuncbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DeleteFuncbtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.savebtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFuncbtn
            // 
            this.AddFuncbtn.Location = new System.Drawing.Point(460, 11);
            this.AddFuncbtn.Name = "AddFuncbtn";
            this.AddFuncbtn.Size = new System.Drawing.Size(24, 20);
            this.AddFuncbtn.TabIndex = 10;
            this.AddFuncbtn.Text = "+";
            this.AddFuncbtn.UseVisualStyleBackColor = true;
            this.AddFuncbtn.Click += new System.EventHandler(this.AddFuncbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Tag = "";
            this.textBox2.Text = "1 0;2 1;3 0";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 407);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(150, 39);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(407, 406);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // DeleteFuncbtn
            // 
            this.DeleteFuncbtn.Location = new System.Drawing.Point(485, 11);
            this.DeleteFuncbtn.Name = "DeleteFuncbtn";
            this.DeleteFuncbtn.Size = new System.Drawing.Size(24, 20);
            this.DeleteFuncbtn.TabIndex = 14;
            this.DeleteFuncbtn.Text = "-";
            this.DeleteFuncbtn.UseVisualStyleBackColor = true;
            this.DeleteFuncbtn.Click += new System.EventHandler(this.DeleteFuncbtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files|*.txt";
            this.saveFileDialog1.InitialDirectory = "../..";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files|*.txt";
            this.openFileDialog1.InitialDirectory = "../..";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(13, 421);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(52, 23);
            this.savebtn.TabIndex = 15;
            this.savebtn.Text = "save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(71, 421);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(61, 23);
            this.loadBtn.TabIndex = 16;
            this.loadBtn.Text = "load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(515, 11);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(42, 20);
            this.newbtn.TabIndex = 17;
            this.newbtn.Text = "new";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // FunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 459);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.DeleteFuncbtn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddFuncbtn);
            this.Controls.Add(this.textBox2);
            this.Name = "FunctionsForm";
            this.Text = "FunctionsForm";
            this.Load += new System.EventHandler(this.FunctionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFuncbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button DeleteFuncbtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button newbtn;
    }
}