using System.Security.Cryptography.X509Certificates;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks();

            //本の平均金額を表示
            Console.WriteLine("本の平均金額");

            Console.WriteLine((int)books.Average(b=> b.Price));

            //本のページ合計を表示
            Console.WriteLine("本のページ合計");

            Console.WriteLine((int)books.Sum(b => b.Pages));
           

            //金額の安い書籍名と金額を表示
            Console.WriteLine("金額の安い書籍名と金額");

            var min = books.Where(b => b.Price == books.Min(b=> b.Price)).First();
            Console.WriteLine(min.Title + ":" + min.Price);
            
            

            //ページが多い書籍名とページ数を表示
            Console.WriteLine("ページが多い書籍名とページ数");

            /*var page = books.Where(b=> b.Pages == books.Max(b=> b.Pages)).First();
            Console.WriteLine(page.Title + ":" + page.Pages);*/

            books.Where(b => b.Pages == books
                        .Max(x => x.Pages)).ToList()
                        .ForEach(x => Console.WriteLine($"{x.Title} : {x.Pages}ページ"));
            
            //タイトルに「物語」が含まれる書籍名をすべて表示
            Console.WriteLine("タイトルに「物語」が含まれる書籍名");

            var story = books.Where(b => b.Title.Contains("物語"));
            foreach(var b in story) {
                Console.WriteLine(b.Title);
            }
            

        }
    }
}
