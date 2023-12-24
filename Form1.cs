using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        int i = 0;
        string filePath;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Play";
            button2.Text = "Pause/Resume";
            button3.Text = "Stop";
            button4.Text = "Select Music";
            mediaPlayer1.uiMode = "none";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mediaPlayer1.URL = filePath;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                mediaPlayer1.Ctlcontrols.pause();
                i++;
            }
            else
            {
                mediaPlayer1.Ctlcontrols.play();
                i = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mediaPlayer1.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media File(*.wav,*.mpg,*.avi,*.dat,*.mp3,*.mp4,*.wmv)|*.wav;*.mp3;*.avi;*.mpg;*.dat;*.wmv";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "Muzik Sec";
            openFileDialog1.ShowDialog();

            filePath = openFileDialog1.FileName;

        }
    }
}
