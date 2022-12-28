using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statikclass
{
    static class User //Böyle yazdığın zaman nesne tanımlamana gerek kalmıyor. Class ı sabitlenmiş oluyorsun --> User u = new User();
    {
        public static string name;
        public static string location;
        public static int age;
        public static void Detail()
        {
            Console.WriteLine("Static Method");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User.name = "Serdar";
            User.location = "İstanbul";
            User.age = 32;
            Console.WriteLine("Name : {0}", User.name);
            Console.WriteLine("Location : {0}", User.location);
            Console.WriteLine("Age : {0}", User.age);

            User.Detail();
            Console.ReadLine();
        }
    }
}
