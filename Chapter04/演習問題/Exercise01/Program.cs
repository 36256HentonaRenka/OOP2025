
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
   　　　　 "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
    　　　　"JavaScript", "Swift", "Go",
　　　　　　];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);

        }

        private static void Exercise1(List<string> langs) {
            //foreach
            var where = langs.Where(s => s.Contains('S')).ToArray();
            foreach(var s in where) {
                Console.WriteLine(s);
            }
            //for
            for (int a = 0; a < langs.Count; a++) {
                if (langs[a].Contains('S')) {
                    Console.WriteLine(langs[a]);
                }
            }
            //while
            int i = 0;
            while (i < langs.Count) {
                if (langs[i].Contains('S')) {
                    Console.WriteLine(langs[i]);
                }
                i++;
            }
        }
            



        private static void Exercise2(List<string> langs) {
            
        }

        private static void Exercise3(List<string> langs) {
            
        }
    }
}
