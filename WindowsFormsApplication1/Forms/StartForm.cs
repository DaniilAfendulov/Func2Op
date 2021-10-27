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
using FuncOperationsApplication.Forms;

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
            if (_currentPoints == null) return;
            float max = _currentPoints.Select(p1 => p1.Y).Max();
            var f = new Function(_currentPoints.ToArray());
            var points = FuncOp.GetFuncPoints(f, _currentPoints.Min(p => p.X), _currentPoints.Max(p => p.X), (int)numericUpDown1.Value);
            float x = MidpontHelper.GetPointsMidpoint(points.Where(p=> p.Y.IsNearlyEqual(max)));
            ChartManager.ShowChart(chart1,new PointF[] { new PointF(x, 0), new PointF(x, max) }, "midpoint");
        }


        public void GetIntervalsMidpoint()
        {
            if (_currentPoints == null) return;
            var points = _currentPoints.ToList();
            float max = points.Max(p => p.Y);
            List<Interval> intervals = new List<Interval>();
            Interval currentInterval = new Interval();
            if (points[0].Y.IsNearlyEqual(max))
            {
                currentInterval.Start = points[0];
            }
            for (int i = 1; i < _currentPoints.Count(); i++)
            {
                if (i == _currentPoints.Count()-1)
                {
                    if (points[i].Y.IsNearlyEqual(max) && points[i-1].Y.IsNearlyEqual(max))
                    {
                        currentInterval.End = points[i];
                        intervals.Add(currentInterval);
                        break;
                    }
                }

                if (points[i].Y.IsNearlyEqual(max))
                {
                    if (points[i-1].Y.IsNearlyEqual(max))
                    {
                        if (points[i + 1].Y.IsNearlyEqual(max)) continue;
                        else
                        {
                            currentInterval.End = points[i];
                            intervals.Add(currentInterval);
                            currentInterval = new Interval();
                        }
                    }
                    else currentInterval.Start = points[i];
                }
            }

            float x = MidpontHelper.GetIntervalsMidpoint(intervals);
            ChartManager.ShowChart(chart1, new PointF[] { new PointF(x, 0), new PointF(x, max) }, "midpoint");
        }


    }
}
