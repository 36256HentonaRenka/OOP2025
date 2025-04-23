using System.Runtime.CompilerServices;

namespace Excercise02 {
    internal class Program {
        static void Main(string[] args) {

            /*int start = int.Parse(args[1]);
            int end = int.Parse(args[2]);*/

            Console.WriteLine("***変換アプリ***");
            Console.WriteLine("1.ヤードからメートル");
            Console.WriteLine("2.メートルからヤード");
            int atai = int.Parse(Console.ReadLine());

            if (atai == 1) {
                Console.Write("変更前(ヤード)：");
                int yard = int.Parse(Console.ReadLine());
                PrintYardToMeter(yard);

            } else if ( atai == 2) {
                Console.Write("変更前(メーター)：");
                int meter = int.Parse(Console.ReadLine());
                PrintMeterToYard(meter);
            } 
            
        }
        //ヤードからメートルへの変換表
        static void PrintYardToMeter(int yard) {
            double meter = yard * 0.9144;
            Console.WriteLine("変更後(メーター)：" + $"{meter:0.000}");
        }
        //メートルからヤードへの変換表
        static void PrintMeterToYard(int meter) {
            double yard = meter / 0.9144;
            Console.WriteLine("変更後(ヤード)" + $"{yard:0.000}");
        }

        
    }
}
