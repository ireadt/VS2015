using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstNewDatabaseSample.Models;
using CodeFirstNewDatabaseSample.BusinessLayer;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateNewBlog();
            QueryBlog();
            Updata();
            QueryBlog();
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
        static void CreateNewBlog()
        {
            Console.Write("请输入一个新博客:");
            string name = Console.ReadLine();
            Blog blog = new Blog ();
            blog.Name = name;
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            bbl.Add(blog);
        }
        static void QueryBlog()
        {
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            var query = bbl.Query();
            Console.WriteLine("所有数据库中的博客:");
            foreach(var item in query)
            {
                Console.Write(item.BlogId + "");
                Console.WriteLine(item.Name);
            }
        }

        static void Updata()
        {
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            Console.Write("请输入一个博客id:");
            int id = int.Parse(Console.ReadLine());
            Blog blog = bbl.Query(id);
            Console.Write("请输入新的博客名:");
            string name = Console.ReadLine();
            blog.Name = name;
            bbl.Update(blog);
        }
    }
}
