using System.ComponentModel;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRecord.DataSource = listCarReports;
        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPickFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPickFileOpen.FileName);
            }
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btRecordAdd_Click(object sender, EventArgs e) {
            if ((string.IsNullOrWhiteSpace(cbAuthor.Text)) || (string.IsNullOrWhiteSpace(cbCarName.Text))) {
                tsslbMessage.Text = "記入者名、または車の名前が未入力です";
                return;
            }

            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,

            };
            listCarReports.Add(carReport);
            setCbAuthor(cbAuthor.Text); //コンボボックスへ登録
            setCbCarName(cbCarName.Text);
            InputItemsAllClear();//登録後クリア

        }

        //入力項目をすべてクリア
        private void InputItemsAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;

        }
        //記録者の履歴をコンボボックスへ登録（重複なし）
        private void setCbAuthor(string author) {
            //既に登録済みか確認
            if (!cbAuthor.Items.Contains(author)) {
                //未登録なら登録【登録済みなら何もしない】
                cbAuthor.Items.Add(author);
            }

        }
        //車名の履歴をコンボボックスへ登録（重複なし）
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }

        }

        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) return CarReport.MakerGroup.トヨタ;
            if (rbNIssan.Checked) return CarReport.MakerGroup.日産;
            if (rbSubaru.Checked) return CarReport.MakerGroup.スバル;
            if (rbImport.Checked) return CarReport.MakerGroup.輸入車;
            return CarReport.MakerGroup.その他;
        }

        private void dgvRecord_Click(object sender, EventArgs e) {
            if (dgvRecord.CurrentRow is null) return;

            dtpDate.Value = (DateTime)dgvRecord.CurrentRow.Cells["Date"].Value;
            setRadioButtonMaker((MakerGroup)dgvRecord.CurrentRow.Cells["Maker"].Value);
            cbAuthor.Text = (string)dgvRecord.CurrentRow.Cells["Author"].Value;
            cbCarName.Text = (string)dgvRecord.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecord.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecord.CurrentRow.Cells["Picture"].Value;
        }

        private void setRadioButtonMaker(MakerGroup targetMaker) {
            switch (targetMaker) {
                case MakerGroup.日産:
                    rbNIssan.Checked = true;
                    break;
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                case MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
            }

        }
        //新規追加のイベントハンドラ
        private void btNewRecord_Click(object sender, EventArgs e) {
            InputItemsAllClear();

        }
        //修正ボタンのイベントハンドラ
        private void btRecordModify_Click(object sender, EventArgs e) {
            if (dgvRecord.Rows.Count == 0) return;

            int index = dgvRecord.CurrentRow.Index;
            listCarReports[index].Author = cbAuthor.Text;
            listCarReports[index].Date = dtpDate.Value;
            listCarReports[index].CarName = cbCarName.Text;
            listCarReports[index].Report = tbReport.Text;
            listCarReports[index].Picture = pbPicture.Image;
            listCarReports[index].Maker =GetRadioButtonMaker();

            dgvRecord.Refresh();
        }
        //削除のイベントハンドラ
        private void btRecordDelete_Click(object sender, EventArgs e) {
            //選択されていない場合は処理を行わない
            if ((dgvRecord.CurrentRow is null)
               || (!dgvRecord.CurrentRow.Selected)) return;

            //カーレポート管理用リストから、該当データを削除する
            int index = dgvRecord.CurrentRow.Index;     
            listCarReports.RemoveAt(index);
        }

        private void Form1_Load(object sender, EventArgs e) {

            InputItemsAllClear();

        }
    }
}
