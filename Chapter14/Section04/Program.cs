using System.Threading.Tasks;

namespace Section04 {
    internal class Program {
        static async Task Main(string[] args) {
            var hc = new HttpClient();
            await GetHtmlExample(hc);
        }

        static async Task GetHtmlExample(HttpClient httpClient) {
            var url = "https://sports.yahoo.co.jp/basket/nba/";
            var text = await httpClient.GetStreamAsync(url);
            Console.WriteLine(text);
        }
    }
}
