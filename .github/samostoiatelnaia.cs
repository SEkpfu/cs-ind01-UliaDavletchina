//вариант 5
using System;
class Program
{
    static void Main()
    {
        int n = 17;
        int count = 0;
        double[] arr = new double[n]; 
        double[] arrF = new double[n];
        Console.WriteLine("Введите 17 чисел");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            arrF[i] = F(arr[i]);
            Console.WriteLine($"F от {i + 1} значения: ");
            Console.WriteLine(arrF[i]);
            count = Koordinati(arr[i], arrF[i]);
        }
        Console.WriteLine($"Количество точек, что вошли в заштрихованную область = {count}");
        Console.WriteLine("Расстояния невошедших точек до 0,0");
        for (int i = 0; i < n; i++)
        {
            d(arr[i], arrF[i]);
        }

    }
    public static double F(double x)
    {
        double rez = 0;
        if (x <= -2)
        {
            rez = Math.Pow((-3 - x), 2) * Math.Sin((x * Math.PI) / (x + 1)); 
        }
        else if (x <= 2)
        {
            rez = 66 / 7.0;
        }
        else
        {
            rez = ((3 * x) / ((2 * x) + (1 / (1 - x)))) * ((4 + Math.Pow(x, 3)) / (Math.Pow(x, 2) + 7));
        }
        return rez;
    }
    public static int Koordinati(double x, double y) 
    {
        int count = 0;
        double[] arr = new double[17];
        if (x*x+y*y <= 8*8 && x >= 0 && y <= 0 || x >= 0 && y >= 0 && y <= (-2*x + 8) || x >= -4 && x*x+y*y <= 64)
        {
            count++;
        }
        return count;
    }
    public static double[]d(double x,double y) 
    {
        double[] arr = new double[17];
        if (!(x*x+y*y <= 8*8 && x >= 0 && y <= 0 || x >= 0 && y >= 0 && y <= (-2*x + 8) || x >= -4 && x*x+y*y <= 64))
        {
            Console.WriteLine(Math.Sqrt(x * x + y * y));
        }
        return arr;
    }
}
