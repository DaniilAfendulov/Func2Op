using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuncOperationsApplication
{
    public partial class StartForm : Form
    {
        public LogForm LogForm;
        private List<Function> _functions;
        AddPointForm AddPointForm1;
        AddPointForm AddPointForm2;
        private readonly FunctionsForm  FunctionsForm;
        public StartForm()
        {
            InitializeComponent();
            LogForm = new LogForm();
            LogForm.Show();
            AddPointForm1 = new AddPointForm(1, this);
            AddPointForm2 = new AddPointForm(2, this);
            _functions = new List<Function>();
            _functions.Add(FuncOpParser.ParseFunction(textBox1.Text));
            _functions.Add(FuncOpParser.ParseFunction(textBox2.Text));
            FunctionsForm = new FunctionsForm(_functions, this);
            RefreshFuncs();
        }

        private void chart1_Click(object sender, EventArgs e)
        {   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFuncOpResult(FuncOp.Intersection);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowFuncOpResult(FuncOp.Union);
        }



        private void ShowFuncOpResult(Func<Function,Function, Func<float, float>> Operation)
        {
            try
            {
                RefreshFuncs();
                var f1 = _functions[0];
                var f2 = _functions[1];
                var f = Operation(f1,f2);
                var start = FuncOp.GetMin(p => p.X, f1, f2);
                var end = FuncOp.GetMax(p => p.X, f1, f2);
                int pointsNumber = (int)numericUpDown1.Value;
                var fpoints = FuncOp.GetFuncPoints(f, start, end, pointsNumber);
                ShowChart(fpoints);
            }
            catch (Exception ex)
            {
                LogForm.AddLogMsgLine(ex.Message);
            }
        }

        private void ShowFuncOpResult(Func<Function[], Func<float, float>> Operation)
        {
            try
            {
                RefreshFuncs();
                var fpoints = GetPoints(Operation);
                ShowChart(fpoints);
            }
            catch (Exception ex)
            {
                LogForm.AddLogMsgLine(ex.Message);
            }
        }

        private void AddPoint1_Click(object sender, EventArgs e)
        {
            if (AddPointForm1 == null)
            {
                AddPointForm1 = new AddPointForm(1, this);
            }
            AddPointForm1.Show();
        }

        private void AddPoint2_Click(object sender, EventArgs e)
        {
            if (AddPointForm2 == null)
            {
                AddPointForm2 = new AddPointForm(2, this);
            }
            AddPointForm2.Show();
        }

        private void Ch1Btn_Click(object sender, EventArgs e)
        {
            ShowChart(textBox1.Text);
        }

        private void Ch2Btn_Click(object sender, EventArgs e)
        {
            ShowChart(textBox2.Text);
        }

        public void AddPoint(PointF point, int id)
        {
            TextBox textBox = null;
            if (id == 1) textBox = textBox1;
            if (id == 2) textBox = textBox2;
            if (textBox != null)
            {
                textBox.AppendText((string.IsNullOrEmpty(textBox.Text)?"":";") + point.X + " " + point.Y);
            }
        }

        private void moreFbtn_Click(object sender, EventArgs e)
        {
            RefreshFuncs();
            FunctionsForm.Show();
        }

        private void RefreshFuncs() 
        {
            try
            {
                _functions[0] = FuncOpParser.ParseFunction(textBox1.Text);
                _functions[1] = FuncOpParser.ParseFunction(textBox2.Text);
            }
            catch (Exception ex)
            {
                LogForm.AddLogMsgLine(ex.Message);
            }

        }

        public void RefreshFuncs(List<Function> funcs)
        {
            _functions = funcs;
            if (_functions.Count < 2) return;

            textBox1.Text = FuncOpParser.GetFunctionText(_functions[0]);
            textBox2.Text = FuncOpParser.GetFunctionText(_functions[1]);
        }

        private IEnumerable<PointF> GetPoints(Func<Function[], Func<float, float>> Operation)
        {
            int pointsNumber = (int)numericUpDown1.Value;
            return FuncOp.GetPointsForFunctions(pointsNumber, Operation, _functions);
        }

        private void showAllbtn_Click(object sender, EventArgs e)
        {
            RefreshFuncs();
            ShowCharts(_functions.Select(f => f.Points).ToArray());
        }

        private void ShowChart(string notParsedPoints)
        {
            try
            {
                chart1.Series.Clear();
                ShowChart(FuncOpParser.ParsePoints(notParsedPoints));
            }
            catch (Exception ex)
            {
                LogForm.AddLogMsgLine(ex.Message);
            }
        }

        private void ShowChart(IEnumerable<PointF> fpoints)
        {
            ChartManager.ShowChart(chart1, fpoints);
        }

        private void ShowCharts(IEnumerable<PointF>[] fpoints)
        {
            ChartManager.ShowCharts(chart1, fpoints);
        }
    }
}
