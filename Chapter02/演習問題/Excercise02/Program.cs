using System.Runtime.CompilerServices;

namespace Excercise02 {
    internal class Program {
        static void Main(string[] args) {

            //int start = int.Parse(args[1]);
            //int end = int.Parse(args[2]);
            Console.WriteLine("***変換アプリ***");
            Console.WriteLine("1.インチからメートル");
            Console.WriteLine("2.メートルからインチ");
            int atai = int.Parse(Console.ReadLine());

            if (atai >= 3) {

                Console.WriteLine("エラー");

            } else if (atai > 0) {
                Console.Write("はじめ：");
                int start = int.Parse(Console.ReadLine());

                Console.Write("おわり：");
                int end = int.Parse(Console.ReadLine());

                if (atai == 1) {
                    PrintInchToMeter(start, end);
                } else if (atai == 2) {
                    PrintMeterToInch(start, end);
                }
            }
        }
        //インチからメートルへの変換表
        static void PrintInchToMeter(int start, int end) {
            for (int inch = start; inch <= end; inch++) {
                double meter = inch * 0.0254;
                Console.WriteLine($"{inch}inch = {meter:0.0000}m");
            }
        }
        //メートルからインチへの変換表
        static void PrintMeterToInch(int start, int end) {
            for (int meter= start; meter <= end; meter++) {
                double inch = meter / 0.0254;
                Console.WriteLine($"{meter}m = {inch:0.0000}inch");
            }
        }

        
    }
}
