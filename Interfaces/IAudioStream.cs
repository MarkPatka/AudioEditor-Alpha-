using AudioEditor.Logics;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioEditor.Interfaces
{
    public interface IAudioStream
    {
        AudioFileReader Stream { get; }
        WaveFormat WaveFormat { get; }
        string FileName { get; }
        string Type { get; }
        float Volume { get; set; }
        long Position { get; set; }
        long Length { get; }
        TimeSpan CurrentTime { get; set; }
        TimeSpan TotalTime { get; }
        bool CanRead { get; }

        PlaybackState State { get; }

        int Read(byte[] buffer, int offset, int count);
        void Open(string fileName); 
        void Play();
        void Stop();
        void Pause();
        void Dispose();
        void SetPlayMark(TimeSpan playMark);

    }
}
