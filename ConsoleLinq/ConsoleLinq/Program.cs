using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = { 10, 20, 30, 40, 11, 21, 31, 41 };
            //var query1 = from i in num
            //            where i % 2 == 0
            //            select i;

            //var query2 = num.Where(i => i % 2 == 0).OrderBy(i => i).FirstOrDefault();

            //foreach(var item in query2)
            //{
            //    Console.Write(item.ToString()+"");
            //}
            //Console.ReadKey();
            string[] names = { "abc", "ak47", "aac", "ccq", "bac" };

            var query1 = from num in names
                         where num.Contains("a")
                         orderby num
                         select num;
            foreach(var item in query1)
            {
                Console.Write(item.ToString());
            }
            Console.ReadKey();

            //            where i % 2 == 0
            //            select i;

            //foreach(var item in query2)
            //{
            //    Console.Write(item.ToString()+"");
            //}
            //Console.ReadKey();

        }
    }
}
