using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication
{
    public static class FuncOpParser
    {
        private static readonly IPointParser _pointParser;
        private static readonly IFunctionParser _functonParser;
        static FuncOpParser()
        {
            _pointParser = new PointParser();
            _functonParser = new FunctionParser(_pointParser);
        }

        //public static PointF[] ParsePoints(string s) => _pointParser.ParsePoints(s);
        //public static PointF ParsePoint(string s) => _pointParser.ParsePoint(s);
        //public static string GetPointText(PointF point) => _pointParser.GetPointText(point);
        //public static string GetPointsText(IEnumerable<PointF> points) => _pointParser.GetPointsText(points);

        //public static Function ParseFunction(string line) => _functonParser.ParseFunction(line);
        //public static IEnumerable<Function> ParseFunctions(string[] lines) => _functonParser.ParseFunctions(lines);
        //public static string GetFunctionText(Function f) => _functonParser.GetFunctionText(f);
        //public static string[] GetFunctionsText(IEnumerable<Function> functions) => _functonParser.GetFunctionsText(functions);

        public static PointF[] ParsePoints(string s) 
        {
            return _pointParser.ParsePoints(s);       
        }
        public static PointF ParsePoint(string s)
                {
                    return _pointParser.ParsePoint(s);
        }

        public static string GetPointText(PointF point) 
                    {
                        return _pointParser.GetPointText(point);
        }
        public static string GetPointsText(IEnumerable<PointF> points) 
                    {
                        return _pointParser.GetPointsText(points);
        }

        public static Function ParseFunction(string line)
                    {
                        return _functonParser.ParseFunction(line);
        }
        public static IEnumerable<Function> ParseFunctions(string[] lines)
                    {
                        return _functonParser.ParseFunctions(lines);
        }
        public static string GetFunctionText(Function f)
                    {
                        return _functonParser.GetFunctionText(f);
        }
        public static string[] GetFunctionsText(IEnumerable<Function> functions) 
                    {
                        return _functonParser.GetFunctionsText(functions);
        }
    }
}
