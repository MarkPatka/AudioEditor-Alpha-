using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using AudioEditor.Logics.Processors;
using AudioEditor.Interfaces;
using NAudio.Wave;

namespace AudioEditor.View
{
    public partial class frmMainForm : Form
    {
        bool expectation=true;

        IPlayList playListPrivate;
        IPlayList playList
        {
            get => playListPrivate;
            set
            {
                playListPrivate = value;
                PlayListRefresh();
                ButtonsLock();
            }
        }

        IAudioStream current => playList.Current;

        public frmMainForm()
        {
            InitializeComponent();

            //playList.OnCurrentChage += PlayList_OnCurrentChage;
            playList = null;
           
        }

        private void PlayList_OnCurrentChage(object sender, EventArgs e)
        {
            Vizualize(current);
        }

        private void PlayListRefresh()
        {
            lbPlayList.Items.Clear();
            if(playList != null)
            {
                foreach(var str in playList.FileNames)
                {
                    string fileName = Path.GetFileName(str);
                    lbPlayList.Items.Add(fileName);
                }
                lbNameOfPlayList.Text = playList.PlayListName;
            }
            lbPlayList.Refresh();
        }

        private void ButtonsLock()
        {
            btnAddTrack.Enabled = btnCleanPlayList.Enabled = btnSavePlayList.Enabled
                = btnRemoveTrack.Enabled = (playList != null);
        }

        private void frmMainForm1_Load(object sender, EventArgs e)
        {

        }

        public string[] fileName, filePath;

        private bool GetPermissionForChangePlayList(string message)
        {
            return (playList == null || (playList != null &&
                MessageBox.Show("Текущий плейлист не пуст. " + message,
                "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK));
        }

        private void btnAddPlayList_Click(object sender, EventArgs e)
        {
            if(GetPermissionForChangePlayList("Заменить его на пустой?"))
            {
                playList = PlayListProcessor.GetNewPlayList();
            }
        }

        private void lbNameOfPlayList_Click(object sender, EventArgs e)
        {
            InputBox input = new InputBox("Введите название плей-листа", "Ввод названия", this);
            if (input.ShowDialog() == DialogResult.OK)
            {
                playList.PlayListName = input.Value;
                lbNameOfPlayList.Text = playList.PlayListName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfdSavePlayList.ShowDialog() == DialogResult.OK)
            {
                PlayListProcessor.SavePlayList(sfdSavePlayList.FileName, playList);
                MessageBox.Show("Плей-лист успешно сохранен!", "Сохранен",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCleanPlayList_Click(object sender, EventArgs e)
        {
            if (GetPermissionForChangePlayList("Очистить его?"))
            {
                playList = PlayListProcessor.ClearPlayList(playList);
            }
        }

        private void btnRemoveTrack_Click(object sender, EventArgs e)
        {
            if (lbPlayList.SelectedIndex < 0) return;
            IAudioStream selectedItem = playList[lbPlayList.SelectedIndex];
            if(selectedItem != null)
            {
                playList = PlayListProcessor.RemoveAudioFromPlayList(selectedItem, playList);
            }
        }

        private void lbPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            current.Stop();
            playList.SetCurrentIndex(lbPlayList.SelectedIndex);
            current.Play();
        }

        private void btnOpenPlayList_Click(object sender, EventArgs e)
        {
            if (GetPermissionForChangePlayList("Открыть другой без сохранения текущего?"))
            {
                if (ofdOpenPlayList.ShowDialog() == DialogResult.OK)
                {
                    playList = PlayListProcessor.OpenPlayList(ofdOpenPlayList.FileName);
                }
            }
        }

        private void cwvWaveVizualisator_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            current.Play();
            cwvWaveVizualisator.WaveStream = new WaveFileReader(ofdOpenAudio.FileName);
            cwvWaveVizualisator.FitToScreen();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            current.Pause();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current.Stop();
            playList.NextIndex();
            current.Play();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            current.Stop();
            playList.PrevIndex();
            current.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            current.Stop();
        }

        private void Vizualize(IAudioStream audio)
        {
            cwvWaveVizualisator.WaveStream = new WaveFileReader(ofdOpenAudio.FileName);
            cwvWaveVizualisator.FitToScreen();
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            if (playList == null) return;

            ofdOpenAudio.InitialDirectory = "C:\\Users\\@username@\\Music";
            if(ofdOpenAudio.ShowDialog() == DialogResult.OK)
            {
                playList = PlayListProcessor.AddAudioInPlayList(ofdOpenAudio.FileNames, playList);
            }


        }
    }
}
