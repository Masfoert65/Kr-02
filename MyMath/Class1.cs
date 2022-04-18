using static System.Math;
namespace MyMath
{
    public class MyFunc
    {
        public static double Task1(double x)

        {
            return Math.Log(3) * Math.Abs(x) + Math.Sqrt(Math.Abs(Math.Sin(x) - Math.Cos(x)));
        }

        public static double Task2(double x)
        {
            double result = 0;
            int i = 3;
            while (i <= 15)
            {
                result += Pow(Cos(Pow(i, 2) * x), 2);
                i += 2;
            }
            return result;
        }
        public static double Task3(double n)
        {
            int k = 1;
            double result = 1;
            while (k <= n)
            {
                result *= 1 + Exp(-Tan(k));
                k++;
            }
            return result;
        }
        public static int Task4(int x)
        {
            int firstNum = x / 10;
            int secondNum = x % 10;

            if ((firstNum + secondNum) == 9)
            {
                return x;
            }
            else
            {
                return 0;
            }
        }

    }
}
