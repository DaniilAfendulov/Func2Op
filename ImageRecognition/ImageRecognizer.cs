using FuncOperationsApplication.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lf = System.Func<float, float>;

namespace ImageRecognition
{
    public class ImageRecognizer
    {

        public float CheckWithImage(lf[][] membershipFunctions, int[][] pixels)
        {
            float sum = 0;
            for (int i = 0; i < pixels.Length; i++)
            {
                for (int j = 0; j < pixels[i].Length; j++)
                {
                    sum += membershipFunctions[i][j](pixels[i][j]);
                }
            }
            int count = 0;
            for (int i = 0; i < pixels.Length; i++)
            {
                count += pixels[i].Length;
            }
            return sum / count;
        }

        public lf[][] GetMembershipFunctions(int[][] pixels)
        {
            lf[][] result = new lf[pixels.Length][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new lf[pixels[i].Length];
            }
            Parallel.For(0, result.Length, (i) =>
            {
                Parallel.For(0, result.Length, (j) =>
                {
                    var maxY = 1.0f;
                    //if (pixels[i][j] > 250) maxY = 0.9f;
                    result[i][j] = SymmetricTriangleFunction.FactoryMethod(pixels[i][j], 130.0f, maxY, 0.0f).GetFunc();
                });
            });
            return result;
        }

        public int GetCodeColor(Color color)
        {
            return (color.R + color.G + color.B) / 3;
        }


        public int[][] GetImagePixels(Bitmap image)
        {
            int[][] result = new int[image.Width][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new int[image.Height];
            }
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    result[i][j] = _imageRecognizer.GetCodeColor(image.GetPixel(i, j));
                }
            }
            return result;
        }
    }
}
