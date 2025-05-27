﻿using System;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            Exercise1();
            Console.WriteLine("---");
            Exercise2();
            Console.WriteLine("---");
            Exercise3();
        
        }

        private static void Exercise1() {
            /*var line = Console.ReadLine();
            var num = int.Parse(line);

            if (num < 0) {
                Console.WriteLine(num);

            } else if (0 <= num && num <100 ) {
                Console.WriteLine(num * 2);

            } else if (100 <= num && num < 500) {
                Console.WriteLine(num * 3);

            }else if (500 <= num) {
                Console.WriteLine(num);
            }*/
            var line = Console.ReadLine();
            if(int.TryParse(line,out var num)) {
                if (num < 0 ) {
                    Console.WriteLine(num);

                } else if ( num < 100) {
                    Console.WriteLine(num * 2);

                } else if ( num < 500) {
                    Console.WriteLine(num * 3);

                } else  {
                    Console.WriteLine(num);
                }
            }
        }

        private static void Exercise2() {
            var line = Console.ReadLine();
            if (int.TryParse(line, out var num)) {
                switch (num) {
                    case < 0:
                    Console.WriteLine(num);
                        break;

                    case < 100:
                    Console.WriteLine(num * 2);
                        break;

                    case < 500:
                    Console.WriteLine(num * 3);
                        break;

                    default:
                    Console.WriteLine(num);
                        break;
                }
            }
        }

        private static void Exercise3() {
            var line = Console.ReadLine();
            if (int.TryParse(line, out var num)) {
                var text = num switch {
                    < 0 => num,
                    < 100 => num * 2,
                    < 500 => num * 3,
                    _  => num
                };
                Console.WriteLine(text);

            }
        }
    }
}
