using AudioEditor.Interfaces;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioEditor.Logics
{
    static class ExtansionsIAudioStream
    {
        public static void TrimWavFile(this IAudioStream stream, string outPath, TimeSpan cutFromStart, TimeSpan cutFromEnd)
        {
            string inPath = stream.FileName;

            using (WaveFileReader reader = new WaveFileReader(inPath))
            {
                    using (WaveFileWriter writer = new WaveFileWriter(outPath, reader.WaveFormat))
                    {
                        int bytesPerMillisecond = reader.WaveFormat.AverageBytesPerSecond / 1000;

                        int startPos = (int)cutFromStart.TotalMilliseconds * bytesPerMillisecond;
                        startPos = startPos - startPos % reader.WaveFormat.BlockAlign;

                        int endBytes = (int)cutFromEnd.TotalMilliseconds * bytesPerMillisecond;
                        endBytes = endBytes - endBytes % reader.WaveFormat.BlockAlign;

                        int endPos = (int)reader.Length - endBytes;

                        TrimWavFile(reader, writer, startPos, endPos);
                }
            }         
        }
        private static void TrimWavFile(WaveFileReader reader, WaveFileWriter writer, int startPos, int endPos)
        {
            reader.Position = startPos;
            byte[] buffer = new byte[reader.BlockAlign * 1024];

            while (reader.Position < endPos)
            {
                int bytesRequired = (int)(endPos - reader.Position);

                if (bytesRequired > 0)
                {
                    int bytesToRead = Math.Min(bytesRequired, buffer.Length);
                    int bytesRead = reader.Read(buffer, 0, bytesToRead);

                    if (bytesRead > 0)
                    {
 
                        writer.Write(buffer, 0, bytesRead);
                        
                    }
                }
            }
        }
        public static IAudioCollection Split(this IAudioStream stream, TimeSpan[] marks)
        {
            AudioCollection splitedFileCollections = new AudioCollection();


            for (int i = 0; i <= marks.Length; i++)
            {
                TimeSpan cutFromStar = marks[i];
                TimeSpan cutFromEnd = marks[i + 1];
                splitedFileCollections.FileNames[i] = $"{stream.FileName}_{i}";

                TrimWavFile(stream, splitedFileCollections.FileNames[i], cutFromStar, cutFromEnd);

                AudioFileReader reader = new AudioFileReader(splitedFileCollections.FileNames[i]);
                IAudioStream newFile = new AudioStream(reader);

                splitedFileCollections.Add(newFile);
            }

            return splitedFileCollections;
        }

        public static void Mp3ToWav(this IAudioStream stream, string outputFile)
        {
            if (stream.Type == "mp3")
            {
                using (Mp3FileReader mp3 = new Mp3FileReader(stream.FileName))
                {
                    using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                    {
                        WaveFileWriter.CreateWaveFile(outputFile, pcm);
                    }
                }
            }
        }
       
    }
}
