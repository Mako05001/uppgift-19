using System;
namespace Uppgift3._19
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Skriv två tal med - eller + exemepl (13-5)");
            string I = Console.ReadLine();
            if (I.Contains ("+"))
            {
                int plus = I.IndexOf ('+');
                double tal1 = double.Parse(I[..plus]);
                double tal2 = double.Parse(I[(plus + 1)..]);
                double tot = tal1 + tal2; 
                Console.WriteLine(I + "=" + tot);
            }
            else if (I.Contains ("-"))
            {
                int minus = I.IndexOf ('-');
                double tal1 = double.Parse (I[..minus]);
                double tal2 = double.Parse(I[(minus + 1)..]);
                double tot = tal2 - tal1;
                Console.WriteLine(I + "=" + tot);
            }
        }
    }
}