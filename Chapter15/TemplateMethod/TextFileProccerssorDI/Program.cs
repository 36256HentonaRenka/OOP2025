namespace TextFileProccerssorDI {
    internal class Program {
        static void Main(string[] args) {
            //var service = new LineCounterService();
            //var processor = new TextFileProccessor(service);
            //var service = new LineOutputService();
            //var processor = new TextFileProccessor(service);
            var service = new LineToHalfNumberService();
            var processor = new TextFileProccessor(service);
            
            Console.Write("パスの入力:");
            processor.Run(Console.ReadLine());
        }
    }
}
