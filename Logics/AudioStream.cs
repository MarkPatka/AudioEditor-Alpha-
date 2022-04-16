using AudioEditor.Interfaces;
using NAudio.Wave;
using System;

namespace AudioEditor.Logics
{
    public class AudioStream : IAudioStream
    {
        public WaveOutEvent OutputDevice;
        public AudioFileReader Stream { get; set; }
        public WaveFormat WaveFormat => Stream.WaveFormat;
        public string FileName => Stream.FileName;

        public PlaybackState State => OutputDevice.PlaybackState;

        public string Type   
        {
            get
            {
                if (FileName.Contains(".wav")) return "wav";
                if (FileName.Contains(".mp3")) return "mp3";
                if (FileName.Contains(".aiff")) return "aiff";
                else return "Неизвестный формат!";
            }          
        }
        public float Volume
        {
            get => Stream.Volume;
            set
            {
                Stream.Volume = value;
            }
        }
        public long Length => Stream.Length;
        public long Position
        {
            get => Stream.Position;
            set { if (value < Stream.Length) Stream.Position = value; }
        }
        public TimeSpan CurrentTime
        {
            get => Stream.CurrentTime;
            set
            {
                if (value < TotalTime) Stream.CurrentTime = value;
            }
        }

        public TimeSpan TotalTime => Stream.TotalTime;

        public bool CanRead => Stream.CanRead;

        public AudioStream(AudioFileReader stream)
        {
            Stream = stream;
            OutputDevice = new WaveOutEvent();
        }


        public int Read(byte[] buffer, int offset, int count)
        {
            return Stream.Read(buffer, offset, count);
        }

        public void Open(string fileName)
        {
            try
            {
                AudioFileReader file = new AudioFileReader(fileName);
            }
            catch
            {
                throw new Exception("Некорректный формат файла");
            }
        }


        public void Play()
        {
            if (OutputDevice.PlaybackState == PlaybackState.Playing) return;
            Stream = new AudioFileReader(FileName);
            OutputDevice.Init(Stream);
            OutputDevice.Play();
        }

        public void Stop()
        {
            OutputDevice.Stop();
            Stream.Dispose();
        }

        public void Pause()
        {
            if (OutputDevice != null)
            {
                if (OutputDevice.PlaybackState == PlaybackState.Playing) OutputDevice.Pause();
            }
        }

        public void Dispose()
        {
            OutputDevice?.Dispose();
            Stream?.Dispose();
        }
        public void SetPlayMark(TimeSpan playMark)
        {
            CurrentTime = playMark;
        }

        public int CompareTo(AudioStream obj)
        {
             return this.FileName.CompareTo(Stream.FileName);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
