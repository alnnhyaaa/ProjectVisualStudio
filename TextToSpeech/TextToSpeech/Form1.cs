using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Linq.Expressions;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer voice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Speak_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cb_Select.SelectedIndex)
                {
                    case 0:
                        voice.SelectVoiceByHints(VoiceGender.NotSet); break;
                    case 1:
                        voice.SelectVoiceByHints(VoiceGender.Male); break;
                    case 2:
                        voice.SelectVoiceByHints(VoiceGender.Female); break;
                    case 3:
                        voice.SelectVoiceByHints(VoiceGender.Neutral); break;

                }
                voice.SpeakAsync(txt_Content.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            voice = new SpeechSynthesizer();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            try
            {
                if (voice != null && voice.State == SynthesizerState.Speaking)
                    voice.Pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Resume_Click(object sender, EventArgs e)
        {
            try
            {
                if (voice != null && voice.State == SynthesizerState.Paused)
                    voice.Resume();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Content.Text))
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Wave Files|*.wav";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string savePath = saveFileDialog.FileName;
                            voice.SetOutputToWaveFile(savePath);
                            voice.Speak(txt_Content.Text);
                            voice.SetOutputToDefaultAudioDevice();
                            MessageBox.Show("Suara telah disimpan.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Teks kosong. Masukkan teks sebelum menyimpan suara.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }  
}
