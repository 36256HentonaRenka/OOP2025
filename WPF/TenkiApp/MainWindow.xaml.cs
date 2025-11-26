using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WeatherApp {
    public partial class MainWindow : Window {

        Dictionary<string, (double lat, double lon)> prefectureCenters =
            new Dictionary<string, (double, double)> {
                {"北海道", (43.06417, 141.34694)}, {"青森県", (40.82444, 140.74)}, {"岩手県", (39.70361, 141.1525)},
                {"宮城県", (38.26889, 140.87194)}, {"秋田県", (39.71861, 140.1025)}, {"山形県", (38.24056, 140.36333)},
                {"福島県", (37.75, 140.46778)}, {"茨城県", (36.34139, 140.44667)}, {"栃木県", (36.56583, 139.88361)},
                {"群馬県", (36.39111, 139.06083)}, {"埼玉県", (35.85694, 139.64889)}, {"千葉県", (35.60472, 140.12333)},
                {"東京都", (35.68944, 139.69167)}, {"神奈川県", (35.44778, 139.6425)}, {"新潟県", (37.90222, 139.02361)},
                {"富山県", (36.69528, 137.21139)}, {"石川県", (36.59444, 136.62556)}, {"福井県", (36.06528, 136.22194)},
                {"山梨県", (35.66389, 138.56833)}, {"長野県", (36.65139, 138.18111)}, {"岐阜県", (35.39111, 136.72222)},
                {"静岡県", (34.97694, 138.38306)}, {"愛知県", (35.18028, 136.90667)}, {"三重県", (34.73028, 136.50861)},
                {"滋賀県", (35.00444, 135.86833)}, {"京都府", (35.02139, 135.75556)}, {"大阪府", (34.68639, 135.52)},
                {"兵庫県", (34.69139, 135.18306)}, {"奈良県", (34.68528, 135.83278)}, {"和歌山県", (34.22611, 135.1675)},
                {"鳥取県", (35.50361, 134.23833)}, {"島根県", (35.47222, 133.05056)}, {"岡山県", (34.66167, 133.935)},
                {"広島県", (34.39639, 132.45944)}, {"山口県", (34.18583, 131.47139)}, {"徳島県", (34.06583, 134.55944)},
                {"香川県", (34.34028, 134.04333)}, {"愛媛県", (33.84167, 132.76611)}, {"高知県", (33.55972, 133.53111)},
                {"福岡県", (33.60639, 130.41806)}, {"佐賀県", (33.24944, 130.29889)}, {"長崎県", (32.74472, 129.87361)},
                {"熊本県", (32.78972, 130.74167)}, {"大分県", (33.23806, 131.6125)}, {"宮崎県", (31.91111, 131.42389)},
                {"鹿児島県", (31.56028, 130.55806)}, {"沖縄県", (26.2125, 127.68111)}
            };

        public MainWindow() {
            InitializeComponent();
            PrefectureCombo.ItemsSource = prefectureCenters.Keys;
        }

        private async void PrefectureCombo_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (PrefectureCombo.SelectedItem == null) return;
            string prefecture = PrefectureCombo.SelectedItem.ToString();
            var (lat, lon) = prefectureCenters[prefecture];
            await FetchWeather(lat, lon, prefecture);
        }

        private void UpdateBackground(string weatherText) {
            string imagePath = "C:/Users/infosys/Desktop/default.jpg"; // デフォルト背景

            if (weatherText.Contains("晴れ"))
                imagePath = "C:/Users/infosys/Desktop/sunny.jpeg";
            else if (weatherText.Contains("曇り"))
                imagePath = "C:/Users/infosys/Desktop/cloudy.jpg";
            else if (weatherText.Contains("雨"))
                imagePath = "C:/Users/infosys/Desktop/rain.jpg";
            else if (weatherText.Contains("雪"))
                imagePath = "C:/Users/infosys/Desktop/snow.jpg";
            else if (weatherText.Contains("雷"))
                imagePath = "C:/Users/infosys/Desktop/thunder.jpg";

            // 背景を変更
            var brush = new ImageBrush {
                ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri(imagePath, UriKind.Relative)),
                Stretch = System.Windows.Media.Stretch.UniformToFill
            };
            this.MainGrid.Background = brush; // XAML側で Grid に x:Name="MainGrid" を付けておく
        }


        private async System.Threading.Tasks.Task FetchWeather(double lat, double lon, string prefecture) {
            string url =
                $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}" +
                "&hourly=temperature_2m,relative_humidity_2m,weathercode" +
                "&daily=temperature_2m_max,temperature_2m_min,weathercode" +
                "&timezone=Asia/Tokyo";

            try {
                using HttpClient client = new HttpClient();
                string json = await client.GetStringAsync(url);
                ShowWeather(json, lat, lon, prefecture);
            }
            catch (Exception ex) {
                MessageBox.Show("天気取得失敗\n" + ex.Message);
            }
        }

        public class WeatherInfo {
            public string Time { get; set; }
            public string Temp { get; set; }
            public string Hum { get; set; }
            public string Weather { get; set; }
        }

        public class DailyWeatherInfo {
            public string Date { get; set; }
            public string Weather { get; set; }
            public string TempRange { get; set; }
        }

        private string SimplifiedWeather(int code) {
            if (code == 0 || code == 1) return "晴れ ☀️";
            else if (code == 2 || code == 3 || code == 45 || code == 48) return "曇り ☁️";
            else if (new[] { 51, 53, 55, 56, 57, 61, 63, 65, 66, 67, 80, 81, 82 }.Contains(code)) return "雨 🌧️";
            else if (new[] { 71, 73, 75, 77, 85, 86 }.Contains(code)) return "雪 ❄️";
            else if (new[] { 95, 96, 99 }.Contains(code)) return "雷 ⚡";
            else return "不明";
        }

        private void ShowWeather(string json, double lat, double lon, string prefecture) {
            var root = JObject.Parse(json);

            // ---- 時間ごとのデータ ----
            var times = root["hourly"]["time"];
            var temps = root["hourly"]["temperature_2m"];
            var hums = root["hourly"]["relative_humidity_2m"];
            var codes = root["hourly"]["weathercode"];

            CoordText.Text = $"{prefecture} (緯度:{lat:F3} 経度:{lon:F3}) の天気";

            var weatherData = new List<WeatherInfo>();
            DateTime now = DateTime.Now;
            DateTime end = now.AddHours(24);

            for (int i = 0; i < times.Count(); i++) {
                DateTime t = DateTime.Parse(times[i].ToString());
                if (t >= now && t <= end) {
                    int code = (int)codes[i];
                    string weatherText = SimplifiedWeather(code);

                    weatherData.Add(new WeatherInfo {
                        Time = t.ToString("MM/dd HH:mm"),
                        Temp = temps[i].ToString(),
                        Hum = hums[i].ToString(),
                        Weather = weatherText
                    });
                }
            }

            WeatherItems.ItemsSource = weatherData;

            if (weatherData.Count > 0) {
                CurrentWeatherText.Text = $"現在の天気: {weatherData[0].Weather}";
            }

            // ---- 明日の予報 ----
            var dailyTimes = root["daily"]["time"];
            var dailyMax = root["daily"]["temperature_2m_max"];
            var dailyMin = root["daily"]["temperature_2m_min"];
            var dailyCodes = root["daily"]["weathercode"];

            DateTime tomorrow = DateTime.Today.AddDays(1);

            for (int i = 0; i < dailyTimes.Count(); i++) {
                DateTime d = DateTime.Parse(dailyTimes[i].ToString());
                if (d.Date == tomorrow.Date) {
                    int code = (int)dailyCodes[i];
                    string weatherText = SimplifiedWeather(code);

                    TomorrowForecastText.Text =
                        $"明日の天気: {weatherText}　最低気温: {dailyMin[i]}℃　最高気温: {dailyMax[i]}℃";
                    break;
                }
            }

            // ---- 週間予報 ----
            var weeklyData = new List<DailyWeatherInfo>();
            for (int i = 0; i < dailyTimes.Count(); i++) {
                DateTime d = DateTime.Parse(dailyTimes[i].ToString());
                int code = (int)dailyCodes[i];
                string weatherText = SimplifiedWeather(code);

                weeklyData.Add(new DailyWeatherInfo {
                    Date = d.ToString("MM/dd"),
                    Weather = weatherText,
                    TempRange = $"最低 {dailyMin[i]}℃ / 最高 {dailyMax[i]}℃"
                });
            }

            if (weatherData.Count > 0) {
                string currentWeather = weatherData[0].Weather;
                CurrentWeatherText.Text = $"現在の天気: {currentWeather}";

                // 背景更新
                UpdateBackground(currentWeather);
            }


            WeeklyItems.ItemsSource = weeklyData;
        }
    }
}
