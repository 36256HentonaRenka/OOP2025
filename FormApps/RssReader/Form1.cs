using Microsoft.Web.WebView2.WinForms;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;

        //コンボボックスからの選択
        Dictionary<string, string> topic = new Dictionary<string, string> {
            { "","" },
            { "主要","https://news.yahoo.co.jp/rss/topics/top-picks.xml"},
            {"国内","https://news.yahoo.co.jp/rss/topics/domestic.xml" },
            {"エンタメ","https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
            {"IT","https://news.yahoo.co.jp/rss/topics/it.xml" },
            {"科学","https://news.yahoo.co.jp/rss/topics/science.xml" },
            {"国際","https://news.yahoo.co.jp/rss/topics/world.xml" },
            { "NBA", "https://news.yahoo.co.jp/rss/media/nrakuten/all.xml" }
        };

        private void Form1_Load(object sender, EventArgs e) {
            cbRss.DataSource = topic.Select(k => k.Key).ToList();
            btGoBack.Enabled = wvRssLink.CanGoBack;
            btGoFoward.Enabled = wvRssLink.CanGoForward;
        }

        public Form1() {
            InitializeComponent();
        }

        private async void btRssGet_Click(object sender, EventArgs e) {
            using (var hc = new HttpClient()) {
                string xml = await hc.GetStringAsync(getRssUrl(cbRss.Text));
                XDocument xdoc = XDocument.Parse(xml);

                //RSSを解析して必要な要素を取得
                items = xdoc.Root.Descendants("item")
                        .Select(x =>
                        new ItemData {
                            Title = (string?)x.Element("title"),
                            Link = (string?)x.Element("link"),
                        }).ToList();

                //リストボックスへタイトルを表示
                lbTitles.Items.Clear();
                items.ForEach(item => lbTitles.Items.Add(item.Title ?? "データなし"));
            }

        }

        //コンボボックスの文字列をチェックしてアクセス可能なURLを返却する
        private string getRssUrl(string str) {
            if (topic.Keys.Contains(str)) {
                return topic[str];
            }
            return str;
        }

        //タイトルを選択（クリック）したときに呼ばれるイベントハンドラ
        private void lbTitles_Click(object sender, EventArgs e) {
            int index = lbTitles.SelectedIndex;
            wvRssLink.Source = new Uri(items[index].Link);
        }


        //リンクを１つ進める
        //private void btGoFoward(object sender, EventArgs e) {
        //    if (wvRssLink.CanGoForward) {
        //        wvRssLink.GoForward();
        //    }
        //}

        private void wvRssLink_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e) {

        }

        private void GoFowardBtEnableSet() {

        }

        private void cbRss_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btFavorite_Click(object sender, EventArgs e) {
            string index = cbRss.Text;
            if (index is null) {
                MessageBox.Show("選択をしてください");
                return;
            }
            //tbFavorite.Text = items[index].Title;
            //wvRssLink.Source = new Uri(items[index].Link);
            //cbRss.Items.Add(items[index].Link);
            Dictionary<string, string> fav = new Dictionary<string, string> {
                { tbFavorite.Text,index }
            };
            cbRss.DataSource = fav.Select(s => s.Key);
        }

        private void wvRssLink_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e) {
            btGoBack.Enabled = wvRssLink.CanGoBack;
            btGoFoward.Enabled = wvRssLink.CanGoForward;
        }

        //リンクを前に戻す
        private void btGoBack_Click(object sender, EventArgs e) {
            wvRssLink.GoBack();
        }

        private void btGoFoward_Click(object sender, EventArgs e) {
            wvRssLink.GoForward();
        }
    }
}
