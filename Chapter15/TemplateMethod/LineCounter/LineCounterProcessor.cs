using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
    internal class LineCounterProcessor : TextProcessor{
        private int _count = 0;

        protected override void Initialize(string fname) => _count = 0;

        protected override void Execute(string line) {
            foreach (var item in line.Split(' ')) {
                if (item.Contains("public")) {
                    _count++;
                }
            }
        }

        protected override void Terminate() => Console.WriteLine("public : ",_count);
    }
}
