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
using WindowsFormsApplication1.Forms;

namespace FuncOperationsApplication
{
    public partial class StartForm : Form
    {
        public LogForm LogForm;
        private List<Function> _functions;
        private readonly FunctionsForm  FunctionsForm;
        private readonly OperationsForm OperationsForm;
        private IEnumerable<PointF> _currentPoints;
        public StartForm()
        {
            InitializeComponent();
            LogForm = new LogForm();
            LogForm.Show();
            _functions = new List<Function>();
            FunctionsForm = new FunctionsForm(_functions, this);
            OperationsForm = new OperationsForm(this);
            FunctionsForm.Show();
            OperationsForm.Show();

        }

        private void chart1_Click(object sender, EventArgs e)
        {   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        public void ShowFuncOpResult(Func<Function,Function, Func<float, float>> Operation)
        {
            try
            {
                var f1 = _functions[0];
                var f2 = _functions[1];
                var f = Operation(f1,f2);
                var start = FuncOp.GetMin(p => p.X, f1, f2);
                var end = FuncOp.GetMax(p => p.X, f1, f2);
                int pointsNumber = (int)numericUpDown1.Value;
                _currentPoints = FuncOp.GetFuncPoints(f, start, end, pointsNumber);
                chart1.Series.Clear();
                ShowChart(_currentPoints);
            }
            catch (Exception ex)
            {
                LogForm.AddLogMsgLine(ex.Message);
            }
        }

        public void ShowFuncOpResult(Func<Function[], Func<float, float>> Operation)
        {
            try
            {
                _currentPoints = GetPoints(Operation);
                chart1.Series.Clear();
                ShowChart(_currentPoints);
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
            _currentPoints = fpoints;
            ChartManager.ShowChart(chart1, fpoints);
        }

        private void ShowCharts(IEnumerable<PointF>[] fpoints)
        {
            _currentPoints = fpoints.SelectMany(p => p);
            ChartManager.ShowCharts(chart1, fpoints);
        }

        private void operationsBtn_Click(object sender, EventArgs e)
        {
            OperationsForm.Show();
        }

        public void GetPointsMidpoint()
        {
            float max = _currentPoints.Select(p1 => p1.Y).Max();
            float x = MidpontHelper.GetPointsMidpoint(_currentPoints.Where(p=> p.Y == max));
            ChartManager.ShowChart(chart1,new PointF[] { new PointF(x, 0), new PointF(x, max) }, "midpoint");
        }


        public void GetIntervalsMidpoint()
        {

        }

    }
}
