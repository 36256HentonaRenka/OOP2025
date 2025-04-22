namespace Excercise02 {
    internal class Program {
        static void Main(string[] args) {

            int start = int.Parse(args[1]);
            int end = int.Parse(args[2]);
            
            //範囲
            if (args.Length >= 1 && args[0] == "-tom") {
                PrintInchToMeter(start, end);
            
            }
        }
        //インチからメートルへの変換表
        static void PrintInchToMeter(int start, int end) {
            for (int inch = start; inch <= end; inch++) {
                double meter = inch * 0.0254;
                Console.WriteLine($"{inch}inch = {meter:0.0000}m");
            }
        }
        
    }
}
