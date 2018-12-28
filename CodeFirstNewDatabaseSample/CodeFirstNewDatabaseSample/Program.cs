using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstNewDatabaseSample.Models;
using CodeFirstNewDatabaseSample.DataAccessLayer;
using CodeFirstNewDatabaseSample.BusinessLayer;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            AddPost();
            //CreateNewBlog();
            //QueryBlog();
            //Updata();
            //Delete();
            //QueryBlog();
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
        static void Delete()
        {
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            Console.Write("请输入一个博客id:");
            int id = int.Parse(Console.ReadLine());
            Blog blog = bbl.Query(id);
            bbl.Delete(blog);
        }


        //显示博客列表
        //用户选择某个博客（id）
        //显示指定博客的帖子列表
        //根据指定到博客信息创建新帖子            
        //显示指定博客的帖子列表
        static void AddPost()
        {
            QueryBlog();
            AddTitle();
            DeleteTitle();
            //UpdataTitle();
        }
        static int GetBlogId()
        {
            Console.WriteLine("请输入博客id:");

            int id = int.Parse(Console.ReadLine());
            return id;
        }
        static void DisplayPosts(int blogId)
        {
            Console.WriteLine(blogId + "的帖子列表{0}");
            //BlogBusinessLayer bbl = new BlogBusinessLayer();
            //Blog blog = bbl.Query(blogId);
            //Console.WriteLine(blog.Name);
            List<Post> list = null;
            using (var db = new BloggingContext())
            {
                Blog blog = db.Blogs.Find(blogId);
                list = blog.Posts.ToList();
            }       
            foreach(var item in list)
            {
                Console.WriteLine("博客ID:{0}---帖子标题:{1}", item.PostId ,item.Title);
            }
        }
        static void AddTitle()
        {
            int blogId = GetBlogId();
            DisplayPosts(blogId);
            Console.WriteLine("添加一个帖子的标题:");
            string title = Console.ReadLine();
            Console.WriteLine("添加帖子的内容:");
            string content = Console.ReadLine();
            Post post = new Post();
            post.BlogId = blogId;
            post.Title = title;
            post.Content = content;

            using (var db = new BloggingContext())
            {
                db.Posts.Add(post);
                db.SaveChanges();
            }
        }
        static void DeleteTitle()
        {
            PostBusinessLayer pbl = new PostBusinessLayer();
            Console.Write("请输入一个帖子id:");
            int id = int.Parse(Console.ReadLine());
            Post post = pbl.QueryPost(id);
            pbl.Delete(post);
        }

        static void UpdataTitle()
        {
            PostBusinessLayer pbl=new PostBusinessLayer();
            Console.Write("请输入帖子id:");
            int id = int.Parse(Console.ReadLine());
            Post post = pbl.QueryPost(id);
            Console.Write("请输入新的帖子标题:");
            string title = Console.ReadLine();
            Console.Write("请输入需要跟新的帖子内容:");
            string content = Console.ReadLine();
            post.Title = title;
            post.Content = content;
            pbl.Updata(post);
        }

        static void QueryPostForTitle()
        {
            Console.WriteLine("请输入将要查找的博客名称:");
            string title = Console.ReadLine();
            PostBusinessLayer pbl = new BusinessLayer.PostBusinessLayer();
            
        }
    }
}
