﻿
namespace Exrcise01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };


            // 3.1.1
            Exercise1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise4(numbers);

        }

        private static void Exercise1(List<int> numbers) {
            var exit = numbers.Exists(s => s% 8 == 0 || s % 9 == 0);

            if (exit) {
                Console.WriteLine("存在する");
            }else {
                Console.WriteLine("存在しない");
            }
        }

        private static void Exercise2(List<int> numbers) {
            numbers.ForEach(s => Console.WriteLine (s / 2.0));
        }

        private static void Exercise3(List<int> numbers) {
            /*var text = numbers.Where(n=> 50 <= n);
            foreach (var s in text) {
                Console.WriteLine(s);
            }*/
            numbers.Where(n => 50 <= n).ToList().ForEach(n => Console.WriteLine(n));//上の文を一行にしたもの
            //ForEachを使うためにはListにしないといけないのでToList＜＞をつかう
        }

        private static void Exercise4(List<int> numbers) {
            /*var text = numbers.Select(n => n * 2).ToList() ;
            foreach(var n in text) {
                 Console.WriteLine(n);
            }*/
            numbers.Select(n => n * 2).ToList().ForEach(Console.WriteLine);//上の文を一行にしたもの
        }
    }
}
