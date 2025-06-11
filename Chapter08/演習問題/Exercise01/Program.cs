﻿
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();

            Exercise2(text);

        }

        private static void Exercise1(string text) {
            var Dict = new Dictionary<char, int>();
            foreach(var ch in text.ToUpper()) {
                if ('A' <= ch && ch <= 'Z') { 
                    if (Dict.ContainsKey(ch)) {
                        Dict[ch]++;
                    } else {
                        Dict[ch] = 1;
                    }

                } 
            }
            foreach(var item in Dict.OrderBy(s=> s.Key)) {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }

        private static void Exercise2(string text) {
            
        }
    }
}
