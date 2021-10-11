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
        public static void ShowChart(Chart chart, IEnumerable<PointF> fpoints, string seriesName = "Series1")
        {            
            chart.ChartAreas[0].AxisY.Maximum = 1;
            var series = chart.Series[seriesName];
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
    }
}
