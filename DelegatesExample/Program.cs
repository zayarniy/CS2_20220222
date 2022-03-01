using System;
/*
 * Условие задачи
Напишите программу поиска номера первого из двух последовательных элементов в целочисленном массиве из 30 элементов, 
 * сумма которых максимальна. Если таких элементов несколько, то вывести номер первой пары.
 */
namespace DelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();//10    20   30
            string[] s = str.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int[] a = Array.ConvertAll<string, int>(s, Convert.ToInt32);
            Console.WriteLine("Hello World!");
        }
    }
}
