using System.Globalization;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var today = DateTime.Today;　//日付
            var now = DateTime.Now; //時刻


            Console.WriteLine($"Today:{today.Month}");
            Console.WriteLine($"Now:{now}");

            //①自分の生まれた生年月日は何曜日かをプログラムを書いて調べる
            /*Console.WriteLine("***生年月日入力***");
            Console.Write("西暦：");
            var ye = Console.ReadLine();
            Console.Write("月：");
            var mon = Console.ReadLine();
            Console.Write("日：");
            var day = Console.ReadLine();

            var year = int.Parse(ye);
            var month = int.Parse(mon);
            var days = int.Parse(day);

            var birth = new DateTime(year, month, days);

            string[] weekdays = {"日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日"};

            Console.WriteLine($"{year}年{month}月{days}日は{weekdays[(int)birth.DayOfWeek]}です");*/

            Console.WriteLine("***生年月日入力***");
            Console.Write("西暦：");
            var year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            var month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            var day = int.Parse(Console.ReadLine());

            var birth = new DateTime(year, month, day);

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var str =birth.ToString("ggyy年M月d日",culture);
            var shortDayOfWeek = culture.DateTimeFormat.GetShortestDayName(birth.DayOfWeek);

            Console.WriteLine(str + birth.ToString("ddd曜日", culture));

            //③生まれてから〇○○日目です
            TimeSpan diff = DateTime.Today - birth;
            Console.WriteLine( "生まれてから"+ diff + "日です。");

            TimeSpan diffs;
            while (true) {
                diffs = DateTime.Now - birth;
                Console.Write($"\r{diffs.TotalSeconds}秒");


            }

            //④あなたは〇〇歳です
            int age = GetAge(birth, today);
            Console.WriteLine(age);

            //⑤１月１日から何日目か？






            //②うるう年の判定プログラムを作成する
            Console.WriteLine("うるう年かどうかを判定する");
            Console.Write("西暦：");
            var years = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(years)) {
                Console.WriteLine($"{years}はうるう年である");
            } else {
                Console.WriteLine($"{years}は平年である");
            }

        }

        static int GetAge(DateTime birthday,DateTime target) {
            var age = target.Year - birthday.Year;
            if(target < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }


    }
}
