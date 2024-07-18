using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c=0,n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            { a[i] = Convert.ToInt32(Console.ReadLine()); }
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (a[i] > a[j])
                    {
                        c = a[i];
                        a[i] = a[j];
                        a[j] = c;
                    }
                }
            }
            Console.WriteLine("Array sorted");
            for (int i=0;i<n;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
