using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
public class Exercise39
{
    public static void Main()
    {
        int i, sum = 0;

        Console.Write("\n\n");
        Console.Write("Find the number and sum of all integer between 0 and 100, divisible by 3:\n");
        Console.Write("-----------------------------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Numbers between 0 and 100, divisible by 3 : \n");
        for (i = 1; i < 101; i++)
        {
            if (i % 3 == 0)
            {
                Console.Write("{0}  ", i);
                sum += i;
            }
        }

    }
}

