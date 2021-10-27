using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 };
            ArrayList arrayList = new ArrayList();
            int result = arrayList.sumAllOdds(array);
            Console.WriteLine("Print Sum Of All odd number is:" + " " + result);

            Console.ReadLine();
        }

        public class ArrayList
        {
            public int sumAllOdds(int[] array)
            {
                int sum = 0;
                //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        sum += array[i];
                    }

                }
                return sum;

            }
        }
    }
    
}
