using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lf = System.Func<float, float>;

namespace FuncOperationsApplication
{
    public static class FuncOp
    {
        #region Union
        public static lf Union(params Function[] functions)
        {
            return Union(functions.Select(f => f.GetFunc()).ToArray());
        }

        public static lf Union(params lf[] functions)
        {
            return x => functions.Select(f => f(x)).Max();
            #region safe variant
            //return x => functions.Where(f => IsExist(f, x)).Select(f => f(x)).Max();
            //return x =>
            //{
            //    float max = 0f;
            //    bool firstFlag = true;
            //    float y;
            //    foreach (var f in functions)
            //    {
            //        try
            //        {
            //            y = f(x);
            //            if (firstFlag)
            //            {
            //                max = y;
            //                firstFlag = false;
            //                continue;
            //            }
            //            if (y > max) max = y;
            //        }
            //        catch { }
            //    }
            //    if (!firstFlag) return max;
            //    throw new ArithmeticException();
            //};
            #endregion
        }

        public static lf Union(Function f1, params lf[] f2)
        {
            var f = f2.ToList();
            f.Add(f1.GetFunc());
            return Union(f.ToArray());
        }

        public static lf Union(lf f1, params Function[] f2)
        {
            var f = f2.Select(ff => ff.GetFunc()).ToList();
            f.Add(f1);
            return Union(f.ToArray());
        }

        public static lf Union(Function[] functions1, lf[] functions2)
        {
            return Union(functions2.Concat(functions1.Select(f => f.GetFunc())).ToArray());
        }
        #endregion

        #region Intersection
        public static lf Intersection(lf f1, lf f2)
        {
            return x => Math.Min(f1(x), f2(x));
        }

        public static lf Intersection(params lf[] f)
        {
            return x => f.Select(f1 => f1(x)).Min();
        }

        public static lf Intersection(Function f1, lf f2)
        {
            return Intersection(f1.GetFunc(), f2);
        }

        public static lf Intersection(Function f1, Function f2)
        {
            return Intersection(f1.GetFunc(), f2.GetFunc());
        }
        #endregion

        public static lf LineF(PointF f1, PointF f2)
        {
            float a = (f1.Y - f2.Y) / (f1.X - f2.X);
            float b = f1.Y - a * f1.X;
            return x => a * x + b;
        }

        public static Function GetFunc (PointF[] points)
        {
            var lenght = points.Length;
            if (lenght == 2 || lenght == 4) return new LineFunc(points);
            if (lenght == 3 || lenght == 5) return new TriangleFunc(points);
            else return new Function(points);
        }

        #region GetFuncPoints
        public static IEnumerable<PointF> GetFuncPoints(lf f, float start, float end, int pointsNumber)
        {
            float step = (end - start) / pointsNumber;
            var points = new List<PointF>();

            points.Add(new PointF(start, f(start)));

            for (int i = 1; i <= pointsNumber - 2; i++)
            {
                float x = start + i * step;
                float y;
                try
                {
                    y = f(x);
                }
                catch (Exception)
                {
                    y = points.Last().Y;
                }
                points.Add(new PointF(x, y));
            }
            points.Add(new PointF(end, f(end)));
            return points;
        }

        public static IEnumerable<PointF> GetFuncPoints(Function f, float start, float end, int pointsNumber)
        {
            return GetFuncPoints(f.GetFunc(), start, end, pointsNumber);
        }
        #endregion

        #region GetPointsForFunctions
        public static IEnumerable<PointF> GetPointsForFunctions(int pointsNumber, Func<Function[], lf> Operation, params Function[] functions)
        {
            float start = GetMin(p => p.X, functions);
            float end = GetMax(p => p.X, functions);
            lf f = Operation(functions);
            return GetFuncPoints(f, start, end, pointsNumber);
        }
        public static IEnumerable<PointF> GetPointsForFunctions(int pointsNumber, Func<Function[], lf> Operation, IEnumerable<Function> functions)
        {
            return GetPointsForFunctions(pointsNumber, Operation, functions.ToArray());
        }
        #endregion

        private static IEnumerable<PointF> AllPoints(params Function[] fs)
        {
            return fs.SelectMany(f => f.Points);
        }

        #region GetMin
        public static float GetMin(Func<PointF, float> selector, params Function[] fs)
        {
            return AllPoints(fs).Min(selector);
        }
        public static float GetMin(Func<PointF, float> selector, IEnumerable<Function> fs)
        {
            return GetMin(selector, fs.ToArray());
        }
        #endregion

        #region GetMax
        public static float GetMax(Func<PointF, float> selector, params Function[] fs)
        {
            return AllPoints(fs).Max(selector);
        }
        public static float GetMax(Func<PointF, float> selector, IEnumerable<Function> fs)
        {
            return GetMax(selector, fs.ToArray());
        }
        #endregion

        public static bool IsExist(lf f, float x)
        {
            try
            {
                f(x);
                return true;
            }
            catch(NullReferenceException)
            {
                return false;
            }
        }
    }
}
