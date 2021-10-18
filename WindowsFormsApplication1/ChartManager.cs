using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;


namespace FuncOperationsApplication
{
    public static class ChartManager
    {
        public static void ShowChart(Chart chart, IEnumerable<PointF> fpoints, string seriesName = "Series1", bool doOptimize = true)
        {
            if (doOptimize) fpoints = OptimizePointsV2(fpoints);
            chart.ChartAreas[0].AxisY.Maximum = 1;
            chart.Series.FindByName(seriesName);
            var series = chart.Series.FindByName(seriesName);
            if (series == null)
            {
                AddChart(chart, fpoints, seriesName);
                return;
            }

            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 5;
            series.Points.Clear();
            fpoints.ToList().ForEach(p => series.Points.AddXY(p.X, p.Y));
        }

        public static void AddChart(Chart chart, IEnumerable<PointF> chartsPoints, string seriesName)
        {
            chart.Series.Add(seriesName);
            ShowChart(chart, chartsPoints, seriesName);
        }

        public static void ShowCharts(Chart chart, IEnumerable<PointF>[]  chartsPoints)
        {
            chart.ChartAreas[0].AxisY.Maximum = 1;
            chart.Series.Clear();
            for (int i = 0; i < chartsPoints.Count(); i++)
            {
                string name = "Series" + i;
                AddChart(chart, chartsPoints[i], name);
            }
        }
        public static void ShowCharts(Chart chart, IEnumerable<IEnumerable<PointF>> chartsPoints)
        {
            ShowCharts(chart, chartsPoints.ToArray());
        }

        public static IEnumerable<PointF> OptimizePoints(IEnumerable<PointF> points)
        {
            List<PointF> pointsList = points.ToList();
            float change1 = pointsList[1].Y - pointsList[0].Y;
            float change2 = pointsList[2].Y - pointsList[1].Y;
            int j = 1;
            for (int i = 1; i < points.Count()-3; i++)
            {
                if (change1.IsNearlyEqual(change2))
                {
                    change2 = pointsList[j + 2].Y - pointsList[j + 1].Y;
                    pointsList.RemoveAt(j);
                    continue;
                }
                j++;
                change1 = change2;
                change2 = pointsList[j + 2].Y - pointsList[j + 1].Y;
            }
            return pointsList;
        }

        public static IEnumerable<PointF> OptimizePointsV2(IEnumerable<PointF> points)
        {
            List<PointF> pointsList = points.ToList();
            int j = 1;
            for (int i = 0; i < points.Count()-3; i++)
            {
                float change1 = Change(pointsList[j-1], pointsList[j]);
                float change2 = Change(pointsList[j], pointsList[j+1]); 
                if (change1.IsNearlyEqual(change2, 0.0001f))
                {
                    pointsList.RemoveAt(j);
                    j--;
                }
                j++;
            }
            return pointsList;
        }

        public static float Change(PointF a, PointF b)
        {
            return (b.Y - a.Y) / (b.X - a.X);
        }
    }
}
