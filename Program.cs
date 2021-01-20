using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> newList = new List<string> { };

            string[] bloggEn = new string[4];
            bool run = true;
            while (run)
            {

                Console.WriteLine("Welcome to the blog");
                Console.WriteLine("1. Write a blogg topic");
                Console.WriteLine("2. Serach for blogg post");
                Console.WriteLine("3. Write out all posts in blogg");
                Console.WriteLine("4. Exit");

                int val;
                int.TryParse(Console.ReadLine(), out val);

                switch (val)
                {
                    case 1:
                        Console.WriteLine("Add title to blog");

                            bloggEn[2] = Console.ReadLine();

                            Console.WriteLine("Add your text ");
                            bloggEn[1] = Console.ReadLine();

                            foreach (string blogg in bloggEn)
                            {
                            Console.WriteLine(blogg);

                            }
                            break;
                    case 2:
                        Console.WriteLine("Search for blog post");
                        bool search = Int32.TryParse(Console.ReadLine(), out item.Lenght);
                        if (search == true)
                        {

                        }
                        break;
                    case 3:
                        for (int i = 0; i < bloggEn.Length; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 4:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Enter an option from menu");
                        break;

                }
            }

        }

        static void MyBlogg(string topics)
        {

        }
    }
}
