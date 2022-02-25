using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AbstractFunctions
// Универсальный метод вывода таблицы значений функции можно реализовать с помощью 
// абстрактного базового класса, содержащего два метода: метод вывода таблицы и абстрактный
// метод, задающий вид вычисляемой функции.
{

    interface IFunc
    {
        double CalculateFunc(double x);
    }

    abstract class TableFun
    {


        public void Table(double a, double b, double h,IFunc func)
        {
            Console.WriteLine("----- X ----- Y -----");
            double x = a;
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, func.CalculateFunc(x));
                x += h;
            }
            Console.WriteLine("---------------------");
        }
    }


    class SimpleFun : IFunc, ICloneable, IComparable
    {
 

        public double CalculateFunc(double x)
        {
            return x * x;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }


    class SinFun : IFunc
    {
        public double CalculateFunc(double x)
        {
            return Math.Sin(x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TableFun tableFun = new TableFun();

            TableFun a = new SinFun();
            Console.WriteLine("Таблица функции Sin:");
            a.Table(-2, 2, 0.1);
            a = new SimpleFun();
            Console.WriteLine("Таблица функции Simple:");
            a.Table(0, 3, 0.5);
        }
    }
}
