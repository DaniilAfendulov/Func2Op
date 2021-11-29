using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncOperationsApplication.Models;
using FuncOperationsApplication;

namespace Sugeno
{
    public partial class Form1 : Form
    {
        BuildParams _buildParameters;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Func<float, float> f = x0 => (float)Math.Sin(1 / x0) * (float)Math.Cos(x0);
            //Func<float, float> f = x0 => x0 * x0 * x0;
            //float start, step;
            //float[] x, y, a;
            //SymmetricTriangleFunction[] membershipFunctions;
            ////enteredX = float.Parse(textBox1.Text);
            //start = float.Parse(textBox2.Text);
            //step = float.Parse(textBox3.Text);
            //int stepsAmount = int.Parse(textBox5.Text);
            _buildParameters = new BuildParams()
            {
                f = x0 => x0 * x0*x0,
                start = float.Parse(textBox2.Text),
                step = float.Parse(textBox3.Text),
                stepsAmount = int.Parse(textBox5.Text),
                k = 10
            };

            _buildParameters = BuildTask(_buildParameters);
            int k = _buildParameters.k;
            PointF[] result = new PointF[_buildParameters.stepsAmount* k];
            PointF[] oldF = new PointF[_buildParameters.stepsAmount * k];
            PointF[][] membershipFunctions = new PointF[_buildParameters.stepsAmount * k][];
            //for (int i = 0; i < x.Length; i++)
            //{
            //    result[i] = new PointF(x[i], FindY(x[i], a, x, y, membershipFunctions));
            //    oldF[i] = new PointF(x[i], y[i]);
            //}
            int membFunLenght = _buildParameters.MembershipFunctions.Length;
            for (int i = 0; i < _buildParameters.stepsAmount * k; i++)
            {
                float xi = _buildParameters.start + (_buildParameters.step / k) * i;
                result[i] = new PointF(xi, FindY(xi, _buildParameters));
                oldF[i] = new PointF(xi, _buildParameters.f(xi));
                membershipFunctions[i] = new PointF[membFunLenght];
                for (int j = 0; j < membFunLenght; j++)
                {

                }
            }
            _buildParameters.Y = _buildParameters.FX.Select(x => FindY(x, _buildParameters)).ToArray();
            //Parallel.For(0, 100 * stepsAmount, i =>
            //{
            //    float xi = start + (step / 100) * i;
            //    result[i] = new PointF(xi, FindY(xi, a, x, y, membershipFunctions));
            //    oldF[i] = new PointF(xi, f(xi));
            //});
            ChartManager.ShowChart(chart123, oldF, "функция");
            ChartManager.ShowChart(chart123, result, "первое приближение");
            var b = chart123.Series;
        }

        /// <summary>
        /// Инициализация стартовых значений для функции f
        /// </summary>
        /// <param name="f">исходная функция</param>
        /// <param name="start">первый x</param>
        /// <param name="step">шаг</param>
        /// <param name="stepsAmount">количесво шагов</param>
        /// <param name="outY">значения исходная функции для каждого икса</param>
        /// <param name="outX">список иксов</param>
        /// <param name="outA">первые значения для a </param>
        /// <param name="outMembershipFunctions">правила</param>
        private void InitValues(Func<float,float> f, float start, float step, int stepsAmount,
            out float[] outY,
            out float[] outX,
            out float[] outA,
            out SymmetricTriangleFunction[] outMembershipFunctions)
        {
            float[] y = new float[stepsAmount+1];
            float[] x = new float[stepsAmount + 1];
            float[] a = new float[stepsAmount + 1];
            SymmetricTriangleFunction[] membershipFunctions = new SymmetricTriangleFunction[stepsAmount + 1];
            Parallel.For(0, stepsAmount, i =>
            {
                x[i] = start + i * step;
            });
            for (int i = 0; i < x.Length; i++)
            {
                membershipFunctions[i] = SymmetricTriangleFunction.FactoryMethod(x[i], 1.75f * step, 1, 0);
                y[i] = f(x[i]);
                a[i] = y[i] / x[i]==0?1:x[i];
            }

            outX = x;
            outY = y;
            outA = a;
            outMembershipFunctions = membershipFunctions;        
        }

        private BuildParams BuildTask(BuildParams parameters) 
        {
            var stepsAmount = parameters.stepsAmount;
            var start = parameters.start;
            var step = parameters.step;
            var f = parameters.f;

            float[] y = new float[stepsAmount+1];
            float[] x = new float[stepsAmount + 1];
            float[] a = new float[stepsAmount + 1];
            SymmetricTriangleFunction[] membershipFunctions = new SymmetricTriangleFunction[stepsAmount + 1];
            Parallel.For(0, stepsAmount, i =>
            {
                x[i] = start + i * step;
            });
            for (int i = 0; i < x.Length; i++)
            {
                membershipFunctions[i] = SymmetricTriangleFunction.FactoryMethod(x[i], 1.75f * step, 1, 0);
                y[i] = f(x[i]);
                a[i] = y[i] / x[i]==0?1:x[i];
            }

            parameters.FX = x;
            parameters.FY = y;
            parameters.A = a;
            parameters.MembershipFunctions = membershipFunctions;
            return parameters;
        }


        private float FindY(float enteredX,float[] a, float[] x, float[] y,  SymmetricTriangleFunction[] membershipFunctions)
        {
            // Второй шаг – Находятся альфы и индивидуальные выходы правил
            float[] y1 = new float[x.Length]; // индивидуальные выходы правил
            float[] alpha = new float[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                alpha[i] = membershipFunctions[i].GetFunc()(enteredX);
                y1[i] = a[i] * enteredX;
            }

            // Третий шаг. Определяется четкое значение переменной вывода
            float res = 0;
            for (int i = 0; i < x.Length; i++)
            {
                res += alpha[i] * y1[i];
            }
            return res / alpha.Sum();
        }

        private float FindY(float x, BuildParams parameters)
        {
            // Второй шаг – Находятся альфы и индивидуальные выходы правил
            return FindY(x, parameters.A, parameters.FX, parameters.FY, parameters.MembershipFunctions);
        }

        private float[] CorrectA(float[] prevA, float[] prevY, float[] y) 
        {
            float[] newA = new float[prevA.Length];
            Parallel.For(0, newA.Length, i =>
            {
                newA[i] = (float)(prevA[i] * (Math.Abs(prevY[i]) < 0.000001 ? (y[i] + 1) / (prevY[i] + 1) : y[i] / prevY[i]) * 0.5 + 0.5 * prevA[i]);
            });
            return newA;
        }
        private float[] CorrectA(BuildParams parameters)
        {
            return CorrectA(parameters.A, parameters.Y, parameters.FY);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _buildParameters.A = CorrectA(_buildParameters);
            var k = _buildParameters.k;
            var stepsAmount = _buildParameters.stepsAmount;
            PointF[] result = new PointF[_buildParameters.stepsAmount * k];
            for (int i = 0; i < stepsAmount * k; i++)
            {
                float xi = _buildParameters.start + (_buildParameters.step / k) * i;
                result[i] = new PointF(xi, FindY(xi, _buildParameters));
            }
            _buildParameters.Y = _buildParameters.FX.Select(x => FindY(x, _buildParameters)).ToArray();
            ChartManager.ShowChart(chart123, result, "новое приближение");
        }

        private class BuildParams
        {
            public Func<float, float> f;
            public float start, step;
            public int stepsAmount, k;
            public float[] FY, FX, A, Y;
            public SymmetricTriangleFunction[] MembershipFunctions;
        }


    }
}
