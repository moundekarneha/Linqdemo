using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqdemo
{
    internal class Program
    {
        static int count;
        
        static void Main(string[] args)
        {
           
            int[] arr = new int[] { 10, 23, 35, 80, 2, 4, 5, 56 };
            
            int index=0;
            int[] brr = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 45)
                {
                    brr[index] = arr[i];
                    index++;
                  
                }
            }

            Array.Sort(brr);
            Array.Reverse(brr);

            for (int i = 0; i<brr.Length; i++)
            {
                
            }
            var arr2 = from i in arr select i;

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            var b = from i in arr where i > 45 select i;
            Console.WriteLine("Greater than 45");
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            var bb = from i in arr where i > 45 orderby i select i;
            Console.WriteLine("Greater than 45 and order by");
            foreach (var item in bb)
            {
                Console.WriteLine(item);
            }



            var bbd = from i in arr where i > 45 orderby i descending select i;
            Console.WriteLine("Greater than 45 and order by and descending");
            foreach (var item in bbd)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();


        }
    }
}
