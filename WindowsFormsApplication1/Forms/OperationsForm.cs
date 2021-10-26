using FuncOperationsApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class OperationsForm : Form
    {
        StartForm _startForm;
        public OperationsForm()
        {
            InitializeComponent();
        }

        public OperationsForm(StartForm startForm) : this()
        {
            _startForm = startForm;
        }

        private void Interesectionbtn_Click(object sender, EventArgs e)
        {
            _startForm.ShowFuncOpResult(FuncOp.Intersection);
        }

        private void UnionBtn_Click(object sender, EventArgs e)
        {
            _startForm.ShowFuncOpResult(FuncOp.Union);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _startForm.GetPointsMidpoint();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _startForm.GetIntervalsMidpoint();
        }
    }
}
