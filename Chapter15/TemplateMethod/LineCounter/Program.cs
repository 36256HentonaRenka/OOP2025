using TextFileProcessor;

namespace LineCounter {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("ファイルパスを指定してください:");
            string path = Console.ReadLine();
            TextProcessor.Run<LineCounterProcessor>(path);
        }
    }
}
