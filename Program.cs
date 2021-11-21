using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkS6T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();

            int max = 0;
            int maxL = 0;
            int num = 0;


            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > max)
                {
                    maxL = stringArray[i].Length;
                    num = i;
                }
            }
            Console.WriteLine("Самое большое слово в тексте");
            Console.WriteLine(stringArray[num]);
            Console.WriteLine("В нем содержится {0} символов",maxL);

            Console.ReadKey();


        }
    }
}
