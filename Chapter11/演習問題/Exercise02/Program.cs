﻿using System.Text.RegularExpressions;
namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            string filePath = "sample.txt";
            Pickup3DigitalNumber(filePath);
        }

        private static void Pickup3DigitalNumber(string filePath) {
            foreach (var line in File.ReadLines(filePath)) {
                var matches = Regex.Matches(line,@"\b\d{3,}\b");
                foreach (Match m in matches) {
                    Console.WriteLine( m.Value );
                }
            }
        }
    }
}
