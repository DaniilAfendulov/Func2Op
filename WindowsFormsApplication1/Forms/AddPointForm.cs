using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncOperationsApplication
{
    public partial class AddPointForm : Form
    {
        IEnumerable<PointF> points;
        FunctionsForm _parentForm;
        public AddPointForm(FunctionsForm parentForm)
        {
            InitializeComponent();
            points = new List<PointF>();
            _parentForm = parentForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var point = new PointF(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
                _parentForm.AddPoint(point);
            }
            catch (Exception ex)
            {
                _parentForm.Log(ex.Message);
            }


        }
    }
}
