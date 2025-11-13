using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
    internal class LineCounterProcessor : TextProcessor{
        private int _count = 0;
        private string target = "";

        protected override void Initialize(string fname) {
            _count = 0;
            Console.Write("カウントしたい文字を入力してください: ");
            target = Console.ReadLine();
        }

        protected override void Execute(string line) {
            foreach (var item in line.Split(' ')) {
                if (item.Contains(target)) {
                    _count++;
                }
            }
        }

        protected override void Terminate() => Console.WriteLine($"{target}:{_count}");
    }
}
