﻿using System.Text.RegularExpressions;

namespace Section03 {
    internal class Program {
        static void Main(string[] args) {
            /*var text = "RegexクラスのMatchメソッドを使います";

            Match match = Regex.Match(text,@"\p{IsHiragana}+");
            if (match.Success) 
                Console.WriteLine($"{match.Index},{match.Value}");

            var matches = Regex.Matches(text,@"\p{IsKatakana}+"); 
            foreach(Match match2 in matches) {
                Console.WriteLine($"Index={match2.Index},Length={match2.Length},Value={match2.Value}");
            }*/

            var texts = "private List<string> results = new List<string>();";

            var matches2 = Regex.Matches(texts, @"\b[a-z]+\b")
                .Cast<Match>().Where(x=> x)
                .OrderBy(x => x.Length);

            foreach (Match match3 in matches2) {
                Console.WriteLine($"Index={match3.Index},Length={match3.Length},Value={match3.Value}");
            }
        }
    }
}
