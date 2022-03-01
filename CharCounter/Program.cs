using System;
using System.Threading.Channels;

namespace CharCounter
{

    delegate bool IsIt(char c);//bool(char)
    
    class Program
    {
        
        static int CountChars(string s, IsIt isIt)
        {
            int count = 0;
            foreach (char c in s)
                if (isIt(c)) count++;
            return count;
        }

        static int CountChars(string s, Func<char, bool> isIt)
        {
            int count = 0;
            foreach (char c in s)
                if (isIt(c)) count++;
            return count;
        }


        static int CountCharDigits(string s)
        {
            int count = 0;
            foreach (char c in s)
                if (char.IsDigit(c)) count++;
            return count;
        }

        static int CountCharRus(string s)
        {
            int count = 0;
            foreach (char c in s)
                if (c>='А' && c<='Я' || c>='а' && c<='я' || c=='ё' || c=='Ё') count++;
            return count;
        }

        static bool IsRus(char c)
        {
            return c >= 'А' && c <= 'Я' || c >= 'а' && c <= 'я' || c == 'ё' || c == 'Ё';
        }

        static void Main(string[] args)
        {
           string str= "В этом предложении есть как русские так и латинские буквы. А так же цифры 0123456789";

           Console.WriteLine(CountChars(str, new IsIt(char.IsDigit)));
           IsIt isRus = new IsIt(IsRus);
           isRus += IsRus;
           isRus -= IsRus;
            isRus('c');
            isRus.Invoke('c');
            Console.WriteLine(isRus.GetInvocationList().Length);
           Console.WriteLine(CountChars(str, isRus));

        }
    }
}
