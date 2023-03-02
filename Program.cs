using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your password : ");
        int password = int.Parse(Console.ReadLine());

        if (password >= 0 && password <= 999999)
        {
            Console.Write("Enter your code: ");
            string code = Console.ReadLine();
            
            int unit = password % 10;
            int ten = (password / 10) % 10;
            int hundred = (password / 100) % 10;
            int thousand = (password / 1000) % 10;
            int tenthousand = (password / 10000) % 10;
            int hundredthousand = password / 100000;

            if (code == "CIA")
            {
                if (unit % 3 == 0 && ten != 1 && ten != 3 && ten != 5 && thousand >= 6 && thousand != 8)
                {
                    Console.WriteLine("True");
                }
                else 
                {
                    Console.WriteLine("False");
                }
            }
            else if (code == "FBI")
            {
                if (hundred % 2 == 0 && hundred != 6 && tenthousand % 2 != 0 && hundredthousand >= 4 && hundredthousand <= 7)
                {
                    Console.WriteLine("True");
                }
                else 
                {
                    Console.WriteLine("False");
                }
            }
            else if (code == "NSA")
            {
                if (unit == 7 || ten == 7 || thousand == 7 || hundred == 7 || tenthousand == 7 || hundredthousand == 7 && unit % 30 == 0 && hundred % 3 == 0 && hundred % 2 != 0)
                {
                    Console.WriteLine("True");
                }
                else 
                {
                    Console.WriteLine("False");
                }
            }
            else 
            {
                Console.WriteLine("False");
            }
        }
        else 
        {
            Console.WriteLine("False");
        }
    }
}