using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksInLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book book1 = new Book("Pod igoto");
                book1.PrintName();

                Console.WriteLine("----------------------------------------------");

                Console.Write("Vavedi n = ");
                int n = int.Parse(Console.ReadLine());

                List<Book> books = new List<Book>();
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Vavedi dannite:");
                    var danni = Console.ReadLine().Split().ToList();
                    Book book = new Book(danni[0], danni[1], danni[2], int.Parse(danni[3]));
                    books.Add(book);
                }

                books.ForEach(x => x.PrintAllOfThem());

                Console.WriteLine("------------------------------------");

                books.OrderBy(x => x.Age).First().PrintAllOfThem();

                Console.WriteLine("------------------------------------");

                books.OrderBy(x => x.Name).ToList().ForEach(book => book.PrintAllOfThem());

                Console.WriteLine("-------------------------------------");

                Console.Write("Vavedi avtor: ");
                string avtor = Console.ReadLine();

                books.Where(x=>x.Avtor==avtor).ToList().ForEach(x => x.PrintAllOfThem());
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
