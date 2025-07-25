using Microsoft.Web.WebView2.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace RssReader {
    public partial class Form1 : Form {

        private List<ItemData> items;

        //�R���{�{�b�N�X����̑I��
        Dictionary<string, string> topic = new Dictionary<string, string> {
            { "","" },
            { "��v","https://news.yahoo.co.jp/rss/topics/top-picks.xml"},
            {"����","https://news.yahoo.co.jp/rss/topics/domestic.xml" },
            {"�G���^��","https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
            {"IT","https://news.yahoo.co.jp/rss/topics/it.xml" },
            {"�Ȋw","https://news.yahoo.co.jp/rss/topics/science.xml" },
            {"����","https://news.yahoo.co.jp/rss/topics/world.xml" },
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

                //RSS����͂��ĕK�v�ȗv�f���擾
                items = xdoc.Root.Descendants("item")
                        .Select(x =>
                        new ItemData {
                            Title = (string?)x.Element("title"),
                            Link = (string?)x.Element("link"),
                        }).ToList();

                //���X�g�{�b�N�X�փ^�C�g����\��
                lbTitles.Items.Clear();
                items.ForEach(item => lbTitles.Items.Add(item.Title ?? "�f�[�^�Ȃ�"));
            }

        }

        //�R���{�{�b�N�X�̕�������`�F�b�N���ăA�N�Z�X�\��URL��ԋp����
        private string getRssUrl(string str) {
            if (topic.Keys.Contains(str)) {
                return topic[str];
            }
            return str;
        }

        //�^�C�g����I���i�N���b�N�j�����Ƃ��ɌĂ΂��C�x���g�n���h��
        private void lbTitles_Click(object sender, EventArgs e) {
            int index = lbTitles.SelectedIndex;
            wvRssLink.Source = new Uri(items[index].Link);
        }

        private void btFavorite_Click(object sender, EventArgs e) {
            var cbrss = cbRss.Text;
            var tbfav = tbFavorite.Text;

            if (string.IsNullOrEmpty(cbrss)) {
                MessageBox.Show("URL��I�����Ă�������");
                return;
            }
            if (!topic.ContainsKey(tbfav)) {
                topic.Add(tbfav, cbrss);

                var bind = new BindingList<string>(topic.Keys.ToList());
                cbRss.DataSource = bind;
                tbFavorite.Clear();

            } else {
                MessageBox.Show("���łɓ������O������܂�");
                return;
            }
        }

        private void wvRssLink_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e) {
            btGoBack.Enabled = wvRssLink.CanGoBack;
            btGoFoward.Enabled = wvRssLink.CanGoForward;
        }

        //�����N��O�ɖ߂�
        private void btGoBack_Click(object sender, EventArgs e) {
            wvRssLink.GoBack();
        }
        //�����N��i�߂�
        private void btGoFoward_Click(object sender, EventArgs e) {
            wvRssLink.GoForward();
        }

        //�o�^����RSS���폜����@�\
        private void btDelete_Click(object sender, EventArgs e) {
            var deletekey = cbRss.Text;
            if (!string.IsNullOrEmpty(deletekey) && topic.Keys.Contains(deletekey)) {
                topic.Remove(deletekey);
                var bind = new BindingList<string>(topic.Keys.ToList());
                cbRss.DataSource = bind;

                MessageBox.Show(deletekey + "�͍폜����܂����B");
            } else {
                MessageBox.Show(deletekey + "�͓o�^����Ă��܂���B");
            }

        }
    }
}
