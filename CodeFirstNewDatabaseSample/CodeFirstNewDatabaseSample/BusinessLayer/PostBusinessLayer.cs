﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirstNewDatabaseSample.Models;
using CodeFirstNewDatabaseSample.DataAccessLayer;

namespace CodeFirstNewDatabaseSample.BusinessLayer
{
    public class PostBusinessLayer
    {
        public void Add(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(post).State = EntityState.Added;

                db.SaveChanges();
            }
        }
        public void Delete(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(post).State = EntityState.Deleted;

                db.SaveChanges();
            }
        }
        public Post QueryPost(int id)
        {
            using (var db = new BloggingContext())
            {
                return db.Posts.Find(id);
            }
        }
        
        public void Updata(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(post).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public List<Post> ListQuery(string title)
        {
            using (var db = new BloggingContext())
            {
                //var query = db.Posts.Where(b => (b.Title.Contains(title)));
                var query = from i in db.Posts
                            where i.Title.Contains(title)
                            select i;

                return query.ToList();
            }
        }
        public List<Post> Query(int blogId)
        {
            using (var db = new BloggingContext())
            {
                var query = from b in db.Posts
                            where b.BlogId == blogId
                            select b;

                return query.ToList();
            }
        }
    }
}
