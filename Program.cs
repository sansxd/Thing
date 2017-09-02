using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            Console.WriteLine("Ingrese un numero");
            x = int.Parse(Console.ReadLine());
            for(int a =1; a <= x; a++)
            {
                if (x % a == 0)
                    y++;
                
            }
            if (y > 2)
            {
                Console.WriteLine("Falso ");
            }else
            {
                Console.WriteLine("verdadero ");

            }
            Console.ReadKey();
        }
    }
}
