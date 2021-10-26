
namespace WindowsFormsApplication1.Forms
{
    partial class OperationsForm
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
            this.Interesectionbtn = new System.Windows.Forms.Button();
            this.UnionBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Interesectionbtn
            // 
            this.Interesectionbtn.Location = new System.Drawing.Point(12, 12);
            this.Interesectionbtn.Name = "Interesectionbtn";
            this.Interesectionbtn.Size = new System.Drawing.Size(95, 23);
            this.Interesectionbtn.TabIndex = 4;
            this.Interesectionbtn.Text = "Пересечениие";
            this.Interesectionbtn.UseVisualStyleBackColor = true;
            this.Interesectionbtn.Click += new System.EventHandler(this.Interesectionbtn_Click);
            // 
            // UnionBtn
            // 
            this.UnionBtn.Location = new System.Drawing.Point(113, 12);
            this.UnionBtn.Name = "UnionBtn";
            this.UnionBtn.Size = new System.Drawing.Size(95, 23);
            this.UnionBtn.TabIndex = 5;
            this.UnionBtn.Text = "Объединение";
            this.UnionBtn.UseVisualStyleBackColor = true;
            this.UnionBtn.Click += new System.EventHandler(this.UnionBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "средняя точка по точкам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "средняя точка по интервалам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UnionBtn);
            this.Controls.Add(this.Interesectionbtn);
            this.Name = "OperationsForm";
            this.Text = "OperationsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Interesectionbtn;
        private System.Windows.Forms.Button UnionBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}