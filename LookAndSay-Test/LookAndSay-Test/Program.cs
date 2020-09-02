using System;

namespace LookAndSay_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the starting number");
            var start = long.Parse(Console.ReadLine());
            Console.WriteLine("Input the number of numbers in the sequence");
            var n = int.Parse(Console.ReadLine());

            var result = new long[n];
            result[0] = start;

            for (int i = 1; i < n; i++)
            {
                start = LookAndSay(start);
                result[i] = start;
            }

            Console.WriteLine("Result:");

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (i < result.Length - 1)
                {
                    Console.Write(", ");
                }
            }

        }

        static long LookAndSay(long numb)
        {
            var str = numb.ToString();
            var res = "";
            int count = 1;

            if (str.Length == 1)
            {
                res = $"{count}{str[0]}";
            }
            else
            {

                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == str[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        res += $"{count}{str[i]}";
                        count = 1;
                    }

                    if (i + 1 == str.Length - 1)
                    {
                        res += $"{count}{str[i + 1]}";
                        break;
                    }
                }
            }
            return long.Parse(res);
        }
    }
}
