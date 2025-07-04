using System.ComponentModel;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //�J�[���|�[�g�Ǘ��p���X�g
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
            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,

            };
            listCarReports.Add(carReport);
            InputItemsAllClear();
        }


        private void InputItemsAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;

        }
        //�L�^�҂̗������R���{�{�b�N�X�֓o�^�i�d���Ȃ��j
        private void setCbAuthor(string author) {
            //���ɓo�^�ς݂��m�F
            if (!cbAuthor.Items.Contains(author)) {
                //���o�^�Ȃ�o�^�y�o�^�ς݂Ȃ牽�����Ȃ��z
                cbAuthor.Items.Add(author);
            }

        }
        //�Ԗ��̗������R���{�{�b�N�X�֓o�^�i�d���Ȃ��j
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }

        }

        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) return CarReport.MakerGroup.�g���^;
            if (rbNIssan.Checked) return CarReport.MakerGroup.���Y;
            if (rbSubaru.Checked) return CarReport.MakerGroup.�X�o��;
            if (rbImport.Checked) return CarReport.MakerGroup.�A����;
            return CarReport.MakerGroup.���̑�;
        }

        private void dgvRecord_Click(object sender, EventArgs e) {

            dtpDate.Value = (DateTime)dgvRecord.CurrentRow.Cells["Date"].Value;
            setRadioButtonMaker((MakerGroup)dgvRecord.CurrentRow.Cells["Maker"].Value);
            cbAuthor.Text = (string)dgvRecord.CurrentRow.Cells["Author"].Value;
            cbCarName.Text = (string)dgvRecord.CurrentRow.Cells["Maker"].Value;
            tbReport.Text = (string)dgvRecord.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecord.CurrentRow.Cells["Picture"].Value;
        }

        private void setRadioButtonMaker(MakerGroup targetMaker) {
            switch (targetMaker) {
                case MakerGroup.���Y:
                    rbNIssan.Checked = true;
                    break;
                case MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.�A����:
                    rbImport.Checked = true;
                    break;
                case MakerGroup.���̑�:
                    rbOther.Checked = true;
                    break;
            }

        }
        //�V�K�ǉ��̃C�x���g�n���h��
        private void btNewRecord_Click(object sender, EventArgs e) {
            InputItemsAllClear();
            

        }
        //�C���{�^���̃C�x���g�n���h��
        private void btRecordModify_Click(object sender, EventArgs e) {


        }
        //�폜�̃C�x���g�n���h��
        private void btRecordDelete_Click(object sender, EventArgs e) {
            //�J�[���|�[�g�Ǘ��p���X�g����A�Y���f�[�^���폜����

        }
    }
}
