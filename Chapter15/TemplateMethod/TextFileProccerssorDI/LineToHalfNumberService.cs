using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProccerssorDI {
    internal class LineToHalfNumberService : ITextFileService {
        private int _count;
        public void Initialize(string fname) {
            _count = 0;
        }

        public void Execute(string line) {
            _count++;
            Console.WriteLine(line.ToUpper());
        }

        public void Terminate() {
            
        }
    }
}

