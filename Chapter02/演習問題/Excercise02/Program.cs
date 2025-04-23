using System.Runtime.CompilerServices;

namespace Excercise02 {
    internal class Program {
        static void Main(string[] args) {

            
            Console.WriteLine("***変換アプリ***");
            Console.WriteLine("1.ヤードからメートル");
            Console.WriteLine("2.メートルからヤード");
            int atai = int.Parse(Console.ReadLine());

            if (atai == 1) {

                Console.WriteLine("変更前(ヤード)：");
                int yard = int.Parse(Console.ReadLine());
                PrintYardToMeter(yard);

            } else if (atai == 2) {
                Console.WriteLine("変更前(メートル)：");
                int meter = int.Parse(Console.ReadLine());
                PrintMeterToYard(meter);
            }
        }
        //インチからメートルへの変換表
        static void PrintYardToMeter(int yard) {
                double meter = yard * 0.9441;
                Console.WriteLine("変更後(メートル)："+$"{meter:0.000}m");
        }
        //メートルからインチへの変換表
        static void PrintMeterToYard(int meter) {
                double yard = meter / 09441;
                Console.WriteLine("変更後(ヤード)："+$"{yard:0.0000}yard");
        }

        
    }
}
