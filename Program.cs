using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgoriths
{
    class ArrayBubble
    {
        public void BubbleSort()
        {
            int Min = 0;
            int Max = 900;
            Random aleatorio = new Random();

            Console.Write("Introduce tamaño del arreglo");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[number]; //{ 2, 4, 7, 3, 11, 8 };

            int upper = arr.Length - 1;
            for(int i =0; i < number; i++)
            {
                arr[i] = aleatorio.Next(Min,Max);
            }
            int temp = 0;
            for (int outer = upper; outer >= 1; outer--)
            {

                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;

                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayBubble L = new ArrayBubble();
            L.BubbleSort();
            Console.ReadLine();
        }
    }
}
