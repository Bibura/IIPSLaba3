using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    public class SetOfMatrix
    {
        public double[] Y;
        public double[] X1;
        public double[] X2;
        public double[] X3;

        public SetOfMatrix()
        {
            Y = new double[] {31.92, 26.1,31.31,31.4,31.93,32.91,32.9,28.5,36.13,36.85,26.39,30.57 };
            X1 = new double[] {19.27,15.07,16.08,15.86,14.19,13.69,20.14,18.9,16.62,15.01,17.28,19.78  };
            X2 = new double[] {16.18,13.39,18.68,16.55,13.68,13.33,13.26,13.32,12.9,12.63,15.78,18.65};
            X3 = new double[] {8.82,9.62,9.83,14.36,15.12,7.55,13.79,9.12,14.44,8.16,16.48,15.36};
        }
        public double CountR1()
        {
            double Yser = 0;
            for (int i = 0; i < Y.Length; i++)
            {
                Yser += Y[i];
            }
            Yser = Yser / Y.Length;
            double X1ser = 0;
            for (int i = 0; i < X1.Length; i++)
            {
                X1ser += X1[i];
            }
            X1ser = X1ser / X1.Length;
            double upperPart = 0;

            for (int i = 0; i < X1.Length; i++)
            {
                upperPart += ((X1[i] - X1ser) * (Y[i] - Yser));
            }

            double lowerPart = 0;

            double Xsquare = 0;
            for (int i = 0; i < X1.Length; i++)
            {
                Xsquare += (Math.Pow(X1[i] - X1ser, 2));
            }
            double Ysquare = 0;
            for (int i = 0; i < Y.Length; i++)
            {
                Ysquare += (Math.Pow(Y[i] - Yser, 2));
            }
            lowerPart = Math.Sqrt(Xsquare * Ysquare);

            double r = upperPart / lowerPart;
            return r;
        }
        public double CountR2()
        {
            double Yser = 0;
            for (int i = 0; i < Y.Length; i++)
            {
                Yser += Y[i];
            }
            Yser = Yser / Y.Length;
            double X2ser = 0;
            for (int i = 0; i < X2.Length; i++)
            {
                X2ser += X1[i];
            }
            X2ser = X2ser / X2.Length;
            double upperPart = 0;

            for (int i = 0; i < X2.Length; i++)
            {
                upperPart += ((X2[i] - X2ser) * (Y[i] - Yser));
            }

            double lowerPart = 0;

            double Xsquare = 0;
            for (int i = 0; i < X2.Length; i++)
            {
                Xsquare += (Math.Pow(X2[i] - X2ser, 2));
            }
            double Ysquare = 0;
            for (int i = 0; i < Y.Length; i++)
            {
                Ysquare += (Math.Pow(Y[i] - Yser, 2));
            }
            lowerPart = Math.Sqrt(Xsquare * Ysquare);

            double r = upperPart / lowerPart;
            return r;
        }
        public double CountR3()
        {
            double Yser = 0;
            for (int i = 0; i < Y.Length; i++)
            {
                Yser += Y[i];
            }
            Yser = Yser / Y.Length;
            double X3ser = 0;
            for (int i = 0; i < X3.Length; i++)
            {
                X3ser += X1[i];
            }
            X3ser = X3ser / X2.Length;
            double upperPart = 0;

            for (int i = 0; i < X3.Length; i++)
            {
                upperPart += ((X3[i] - X3ser) * (Y[i] - Yser));
            }

            double lowerPart = 0;

            double Xsquare = 0;
            for (int i = 0; i < X3.Length; i++)
            {
                Xsquare += (Math.Pow(X3[i] - X3ser, 2));
            }
            double Ysquare = 0;
            for (int i = 0; i < Y.Length; i++)
            {
                Ysquare += (Math.Pow(Y[i] - Yser, 2));
            }
            lowerPart = Math.Sqrt(Xsquare * Ysquare);

            double r = upperPart / lowerPart;
            return r;
        }
    }
}
