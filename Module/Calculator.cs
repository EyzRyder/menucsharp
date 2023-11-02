using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace menucsharp.Module
{
    public static class Calc
    {
        private static int GetInt()
        {
            string x;
            int value = 0;
            do
            {
                x = Console.ReadLine();
            } while (!int.TryParse(x, out value));
            return value;
        }
        public static void sum()
        {
            Console.WriteLine("Digite o primeiro numero");
            int x = GetInt();
            Console.WriteLine("Digite o segundo numero");
            int y = GetInt();

            int result = x + y;

            Console.WriteLine($"{x} + {y} = {result}");
            Console.Read();
        }
        public static void sub()
        {
            Console.WriteLine("Digite o primeiro numero");
            int x = GetInt();
            Console.WriteLine("Digite o segundo numero");
            int y = GetInt();

            int result = x - y;

            Console.WriteLine($"{x} - {y} = {result}");
            Console.Read();
        }
        public static void mult()
        {
            Console.WriteLine("Digite o primeiro numero");
            int x = GetInt();
            Console.WriteLine("Digite o segundo numero");
            int y = GetInt();

            int result = x * y;

            Console.WriteLine($"{x} x {y} = {result}");
            Console.Read();
        }
        public static void divid()
        {
            Console.WriteLine("Digite o primeiro numero");
            int x = GetInt();
            Console.WriteLine("Digite o segundo numero");
            int y = GetInt();

            int result = x / y;

            Console.WriteLine($"{x} / {y} = {result}");
            Console.Read();
        }
    }
}