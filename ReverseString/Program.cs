using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a string");
            string originalString = Console.ReadLine();
            char[] newString = new char[originalString.Length];
            int count = 0;

            

            for (int i = originalString.Length -1; i >= 0; i--)
            {
                newString[count] = originalString[i];
                count++;
                
            }

            foreach (char element in newString)
                Console.Write(element);
            Console.WriteLine();
            Console.WriteLine(originalString);
            //Console.ReadLine();
        }
    }
}
