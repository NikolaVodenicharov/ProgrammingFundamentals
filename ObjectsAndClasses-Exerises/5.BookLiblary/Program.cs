using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _5.BookLiblary
{
    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Isbn { get; set; }

        public decimal Price { get; set; }

        public static Book ReadBook()
        {
            string[] input = Console.ReadLine().Split(' ');
            string title = input[0];
            string author = input[1];
            string publisher = input[2];
            DateTime releaseDate = new DateTime();
            releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            int isbn = int.Parse( input[4] );
            decimal price = decimal.Parse( input[5] );

            Book book = new Book()
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                ReleaseDate = releaseDate,
                Isbn = isbn,
                Price = price,
            };
            return book;
        }
    }

    class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library ();
            library.Name = "Library1";

            List<Book> books = new List<Book>();

            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputs; i++)
            {
                Book book = new Book();
                book = Book.ReadBook();
                books.Add(book);
            }

            library.Books = books;

            List<string> authors = new List<string>();
            foreach (var a in library.Books.Select(s => s.Author).Distinct())
            {
                authors.Add(a);
            }

            foreach (var author in authors)
            {
                var money = library.Books.Where(s => s.Author == author).Sum(s => s.Price);
                Console.WriteLine($"{author} -> {money:f2}");
            }

        }
    }
}
