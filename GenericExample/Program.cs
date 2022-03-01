using System;

namespace GenericExample
{
    interface IInterface<T>
    {
        void Work<T>(T param);
    }

    class List<T>
    {

    }

    delegate void Action(string str);

    delegate void Action<T>(T param);
    class Program
    {

        //static void SwapI(ref int a,ref int b)//перегрузка по аргументам
        //{
        //    int t = a;
        //    a = b;
        //    b = t;
        //}

        //static void SwapD(ref double a, ref double b)
        //{
        //    double t = a;
        //    a = b;
        //    b = t;
        //}

        //обобщения или параметризированные методы
        static void Swap<Ty>(ref Ty a, ref Ty b)
        {
            Ty t = a;
            a = b;
            b = t;
        }

        static void Main(string[] args)
        {
            Type type = typeof(int);
            double a = 4, b = 5;
            Swap(ref a,ref b);


            Console.WriteLine("Hello World!");
        }
    }
}
