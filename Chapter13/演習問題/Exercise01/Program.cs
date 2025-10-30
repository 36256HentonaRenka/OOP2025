
using System.Security.Cryptography.X509Certificates;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var Max = Library.Books.MaxBy(b => b.Price);
            Console.WriteLine(Max);
        }

        private static void Exercise1_3() {
            var year = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Select(group => new {
                    year = group.Key,
                    count = group.Count()
                })
                .OrderBy( g => g.year);
            foreach(var book in year) {
                Console.WriteLine($"{book.year} : {book.count}");
            }


        }

        private static void Exercise1_4() {
            var item = Library.Books
                .OrderByDescending(g => g.PublishedYear)
                .ThenByDescending(g=> g.Price);
            foreach (var books in item) {
                Console.WriteLine($"{books.PublishedYear}年 {books.Price}円 {books.Title}");
            }

        }

        private static void Exercise1_5() {
            var groups = Library.Books
                .Where(s => s.PublishedYear == 2022)
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => category.Name
                ).Distinct();
            foreach (var group in groups) {
                Console.WriteLine(group);
            }
        }

        private static void Exercise1_6() {
            /*var category = Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new { Category = c.Name, Books = books }
                )
            .OrderBy( s => s.Category);
            foreach (var item in category) {
                Console.WriteLine($"# {item.Category}");
                foreach(var book in item.Books) {
                    Console.WriteLine($" {book.Title}");
                }
            }*/

            var groups = Library.Books
                .Join(Library.Categories,
                      b => b.CategoryId,
                      s => s.Id,
                      (b, s) => new {
                          CategoryName = s.Name,
                          b.Title
                      })
                .GroupBy(x => x.CategoryName)
                .OrderBy(x => x.Key);
            foreach (var group in groups) {
                Console.WriteLine($"# {group.Key}");
                foreach (var book in group) {
                    Console.WriteLine($" {book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var category = Library.Categories
                .Where(s => s.Name.Equals("Development"))
                .Join(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, b) => new {
                    b.Title,
                    b.PublishedYear
                })
                .GroupBy(x => x.PublishedYear)
                .OrderBy(x => x.Key);
            foreach (var item in category) {
                Console.WriteLine($"#{item.Key}");
                foreach (var book in item) {
                    Console.WriteLine($" {book.Title}");
                }
            }
                
        }

        private static void Exercise1_8() {
            var groups = Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, book) => new {
                    Category = c.Name,
                    Count = book.Count()
                })
                .Where(x=> x.Count >= 4)
                .Select(x=> x.Category);
            foreach(var group in groups) {
                Console.WriteLine(group);
            }
        }
    }
}
