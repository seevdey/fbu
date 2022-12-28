﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

namespace efall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BloggingContext, Configuration>());

            using (var db = new BloggingContext())
            {
                Console.Write("Lütfen yeni bir blok ismi giriniz : ");
                var name = Console.ReadLine();
                //veritabanına kaydetme
                var blog = new Blog { Name = name}; //Yeni blog
                db.Blogs.Add(blog); 
                db.SaveChanges(); //veritabanına kaydediyoruz

                var query = from b in db.Blogs orderby b.Name select b;
                Console.WriteLine("Veri tabanındaki tüm bloklar ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("Çıkmak için bir tuşa basınız.........");
                Console.ReadKey();
            }


        }
    }
    //çoka çok olduğu zaman ikisinde de virtual diyosun

    //Blog ve Post arasında bire çok ilişki var
    //Blog ve Post u tanımlanan alanlarla birbirine bağladık 
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public virtual List<Post> Posts { get; set; } //bire çok ilişki
        public virtual BlogImage BlogImageId { get; set; } //bire bir bağlantılı


    }

    //Post ve Tag i çoka çok ilişki yapıyoruz
    public class Post
    {
        public int PostId { get; set;}
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }

        //iki tablo arasında bağlantı kurmak
        public virtual Blog Blog { get; set; }

    }

    //Blog tablosu ile BlogImage bire bir bağlı
    public class BlogImage
    {
        public int BlogImageId { get; set; }
        public byte [] Image { get; set; }
        public string Caption { get; set; }
        public virtual Blog Blog { get; set; } 

    }

    public class Tag
    {
        public int TagId { get; set; }
        public virtual List<Post> PostTags { get; set; } //çoka çok ilişki

    }

    //Bu sınıfları Entity'e tanımlayacağımız kısım burası
    //bu kodlar sql i oluşturmasını sağlıyor
    public class BloggingContext : DbContext 
    { 
        protected override void OnModelCreating(DbModelBuilder modelBuilder) //Zaten olan bir metodu eziyoruz
        {
            modelBuilder.Entity<Blog>().HasOptional(e => e.BlogImageId).WithRequired(e => e.Blog);
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set;}
        public DbSet<BlogImage> BlogImages { get; set; }

    }


}
