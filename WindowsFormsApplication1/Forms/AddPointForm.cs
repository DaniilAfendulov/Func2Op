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
        int _id;
        StartForm _parantForm;
        public AddPointForm(int id, StartForm parantForm)
        {
            InitializeComponent();
            points = new List<PointF>();
            _id = id;
            _parantForm = parantForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var point = new PointF(float.Parse(textBox1.Text), float.Parse(textBox2.Text));
                _parantForm.AddPoint(point, _id);
            }
            catch (Exception ex)
            {
                _parantForm.LogForm.AddLogMsgLine(ex.Message);
            }


        }
    }
}
