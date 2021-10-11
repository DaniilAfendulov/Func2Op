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
        private readonly FunctionsForm  FunctionsForm;
        public StartForm()
        {
            InitializeComponent();
            LogForm = new LogForm();
            LogForm.Show();
            _functions = new List<Function>();
            FunctionsForm = new FunctionsForm(_functions, this);
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
                var fpoints = GetPoints(Operation);
                ShowChart(fpoints);
            }
            catch (Exception ex)
            {
                LogForm.AddLogMsgLine(ex.Message);
            }
        }

        private void moreFbtn_Click(object sender, EventArgs e)
        {
            FunctionsForm.Show();
        }


        public void RefreshFuncs(List<Function> funcs)
        {
            _functions = funcs;
        }

        private IEnumerable<PointF> GetPoints(Func<Function[], Func<float, float>> Operation)
        {
            int pointsNumber = (int)numericUpDown1.Value;
            return FuncOp.GetPointsForFunctions(pointsNumber, Operation, _functions);
        }

        private void showAllbtn_Click(object sender, EventArgs e)
        {
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
