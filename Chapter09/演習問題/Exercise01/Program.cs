using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var datetime = DateTime.Now;
            DisplayDatePattern1(datetime);
            DisplayDatePattern2(datetime);
            DisplayDatePattern3(datetime);

        }

        private static void DisplayDatePattern1(DateTime datetime) {
            //　2024/03/09　19：03
            //String.Formatを使った例
            var str = String.Format("{0:yyyy/MM/dd HH:mm}", datetime);
            Console.WriteLine(str);
            
        }

        private static void DisplayDatePattern2(DateTime datetime) {
            //　2024年３月9日　19時03分09秒
            //DateTime.ToStringを使った例

            Console.WriteLine(datetime.ToString("yyyy年MM月dd日 HH時mm分ss秒"));

        }

        private static void DisplayDatePattern3(DateTime datetime) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var str = datetime.ToString("ggy年M月d日(dddd)",culture);
            Console.WriteLine(str);

            var datestr = datetime.ToString("ggyy",culture);
            var dayofweek = culture.DateTimeFormat.GetDayName(datetime.DayOfWeek);

            var stri = string.Format($"{datestr}年{datetime.Month,2}月{datetime.Day,2}日({dayofweek})");
            Console.WriteLine(stri);

        }
    }
}
