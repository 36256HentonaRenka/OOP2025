using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var filePath = "";

            var count = CountClass(filePath);

        }
        //Exercise01.10.1
        public static int CountClass(string filePath) {
            int count = 0;

            using var reader = new StreamReader(filePath, Encoding.UTF8);
            while (!reader.EndOfStream) {
                var line = reader.ReadLine();
                if (line.Contains("class")) {
                    count++;
                }
            }
            return count;
        }
    }
}

