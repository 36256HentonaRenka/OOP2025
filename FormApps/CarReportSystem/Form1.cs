using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�ݒ�N���X�̃C���X�^���X�𐶐�
        Settings settings = Settings.getInstance();

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

            tsslbMessage.Text = String.Empty;
            //if(cbAuthor.Text == String.Empty)
            if ((string.IsNullOrWhiteSpace(cbAuthor.Text)) || (string.IsNullOrWhiteSpace(cbCarName.Text))) {
                tsslbMessage.Text = "�L���Җ��A�܂��͎Ԃ̖��O�������͂ł�";
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
            setCbAuthor(cbAuthor.Text); //�R���{�{�b�N�X�֓o�^
            setCbCarName(cbCarName.Text);
            InputItemsAllClear();//�o�^��N���A

        }

        //���͍��ڂ����ׂăN���A
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
            if (dgvRecord.Rows.Count == 0) return;

            int index = dgvRecord.CurrentRow.Index;
            listCarReports[index].Author = cbAuthor.Text;
            listCarReports[index].Date = dtpDate.Value;
            listCarReports[index].CarName = cbCarName.Text;
            listCarReports[index].Report = tbReport.Text;
            listCarReports[index].Picture = pbPicture.Image;
            listCarReports[index].Maker = GetRadioButtonMaker();

            dgvRecord.Refresh();
        }
        //�폜�̃C�x���g�n���h��
        private void btRecordDelete_Click(object sender, EventArgs e) {
            //�I������Ă��Ȃ��ꍇ�͏������s��Ȃ�
            if ((dgvRecord.CurrentRow is null)
               || (!dgvRecord.CurrentRow.Selected)) return;

            //�J�[���|�[�g�Ǘ��p���X�g����A�Y���f�[�^���폜����
            int index = dgvRecord.CurrentRow.Index;
            listCarReports.RemoveAt(index);
        }

        private void Form1_Load(object sender, EventArgs e) {

            InputItemsAllClear();

            //���݂ɐF��ݒ�i�f�[�^�O���b�h�r���[�j
            dgvRecord.DefaultCellStyle.BackColor = Color.LightBlue;
            dgvRecord.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            //�ݒ�t�@�C����ǂݍ��ݔw�i�F��ݒ肷��i�t�V���A�����j
            //P286�ȍ~���Q�l�ɂ���(�t�@�C�����Fsetting.xml)
            if (File.Exists("setting.xml")) {
                try {
                    using (var reader = XmlReader.Create("setting.xml")) {
                        var serializer = new XmlSerializer(typeof(Settings));
                        var set = serializer.Deserialize(reader) as Settings;
                        //�w�i�F�̐ݒ�
                        BackColor = Color.FromArgb(set?.MainFormBackColor ?? 0);
                        //�ݒ�N���X�̃C���X�^���X�ɂ����݂̐ݒ�F��ݒ�
                        settings.MainFormBackColor = BackColor.ToArgb();
                        
                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "�ݒ�t�@�C���ǂݍ��݃G���[";
                    MessageBox.Show(ex.Message);//������̓I�ȃG���[���o��

                }
            } else {
                tsslbMessage.Text = "�ݒ�t�@�C��������܂���";
            }

            
        }

        private void tsmiExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tsmiAbout_Click(object sender, EventArgs e) {
            fmVersion fmv = new fmVersion();
            fmv.ShowDialog();
        }

        private void �F�ݒ�ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                this.BackColor = cdColor.Color;
                //�ݒ�t�@�C���֕ۑ�
                settings.MainFormBackColor = cdColor.Color.ToArgb();//�w�i�F��ݒ�

            }

        }

        //�t�@�C���I�[�v��
        private void reportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //�t�V���A�����Ńo�C�i���`������荞��
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                        ofdReportFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRecord.DataSource = listCarReports;

                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();

                        foreach (var report in listCarReports) {
                            setCbAuthor(report.Author);
                            setCbCarName(report.CarName);
                        }

                    }
                }
                catch (Exception) {
                    tsslbMessage.Text = "�t�@�C���`�����Ⴂ�܂�";

                }
            }
        }

        //�t�@�C���Z�[�u����
        private void reportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //�o�C�i���`���ŃV���A����
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011

                    using (FileStream fs = File.Open(
                                     sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "�t�@�C�������o���G���[";
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void �ۑ�ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
        }

        private void �J��ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportOpenFile();
        }

        //�t�H�[����������Ă΂��
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //�ݒ�t�@�C���֐F����ۑ����鏈���i�V���A�����j
            //���ȏ�P284�ȍ~���Q�l�ɂ���(�t�@�C�����Fsetting.xml)
            try {
                using (var writer = XmlWriter.Create("setting.xml")) {
                    var serializer = new XmlSerializer(settings.GetType());
                    serializer.Serialize(writer, settings);
                }
            }
            catch (Exception ex) {
                tsslbMessage.Text = "�ݒ�t�@�C�������o���G���[";
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
