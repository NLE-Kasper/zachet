using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachet1
{
    class Program
    {
        static void Main(string[] args)
        {
        link:
            string stringVariable = Console.ReadLine();
            int max = 0, len = 0;
            for (int i = 0; i < stringVariable.Length; i++)
            {
                if (stringVariable[i] == ' ')
                {
                    len++;
                    if (len > max)
                        max = len;
                }
                else
                    len = 0;
            }
            Console.WriteLine(max);
            goto link;
        }
    }
}
