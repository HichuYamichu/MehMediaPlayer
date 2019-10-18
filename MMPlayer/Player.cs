using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace MMPlayer
{
    class Player
    {
        public bool isPlaying => this.outputDevice.PlaybackState == PlaybackState.Playing;
        public string currentlyPlaying => this.playlist[currentSongIndex];
        private WaveOutEvent outputDevice = new WaveOutEvent();
        private AudioFileReader audioFile;
        private string[] playlist;
        private int currentSongIndex = 0;

        public Player(string[] playlist)
        {
            outputDevice.PlaybackStopped += OnPlaybackStopped;
            this.playlist = playlist;
            this.audioFile = new AudioFileReader(playlist[currentSongIndex]);
            this.outputDevice.Init(audioFile);
        }

        public void Play()
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }

            if (this.audioFile == null)
            {
                this.audioFile = new AudioFileReader(playlist[currentSongIndex]);
                outputDevice.Init(audioFile);
            }
            
            outputDevice.Play();
        }

        public void Next()
        {
            outputDevice.Stop();
        }

        public void Previous()
        {
            currentSongIndex = currentSongIndex - 2;
            outputDevice.Stop();
        }

        public void Pause()
        {
            this.outputDevice?.Stop();
        }


        public void setVolume(int vol)
        {
            this.outputDevice.Volume = vol / 100f;
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            this.outputDevice.Dispose();
            this.outputDevice = null;
            this.audioFile.Dispose();
            this.audioFile = null;
            this.currentSongIndex++;
            Play();
        }
    }
}
