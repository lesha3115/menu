using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;
            string vibor = " ";
            Console.WriteLine("- ввести А\r\n- ввести В\r\n- выполнить операцию “+”\r\n- выполнить операцию “-”\r\n- выполнить операцию “*”\r\n- выполнить операцию “/”\r\n");
            vibor = Console.ReadLine();
            switch(vibor)
            {
                case "выполнить операцию -":
                    C = A - B;
                    Console.WriteLine("Результат: " + C);
                    break;
            }
            Console.ReadKey();
        }
      
    }
}
