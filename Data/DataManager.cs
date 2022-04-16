using AudioEditor.Interfaces;
using AudioEditor.Logics;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioEditor.Data
{
    public class DataManager
    {
        public static AudioStream OpenAudiofile(string fileName)
        {
            try
            {
                using (AudioFileReader file = new AudioFileReader(fileName))
                {
                    return new AudioStream(file);
                }
            }
            catch
            {
                throw new Exception("Некорректный формат файла");
            }
        }

        public static void SavePlaylist(string playListPath, IPlayList list)
        {
            //List<string> PlayListPaths = list.FileNames.ToList<string>();
            //List<string> SavedPlayList = new List<string>();

            //foreach (string Name in PlayListPaths)
            //{
            //    for (int i = 0; i < PlayListPaths.Count(); i++)
            //    {
            //        SavedPlayList.Add(Name);
            //    }
            //}
            //File.Create(playListPath);
            //File.WriteAllLines(playListPath, SavedPlayList);

            using (StreamWriter file = new StreamWriter(playListPath, false))
            {
                file.WriteLine(list.PlayListName);
                list.FileNames.ForEach(t => file.WriteLine(t));
            }
        }

        public static IPlayList OpenPlaylist(string playListPath)
        {
            IPlayList playList = new PlayList();
            using (StreamReader file = new StreamReader(playListPath))
            {
                string playListName = file.ReadLine();
                playList.PlayListName = playListName;

                while (!file.EndOfStream)
                {
                    string fileName = file.ReadLine();
                    if (File.Exists(fileName))
                    {
                        using (AudioFileReader audioFile = new AudioFileReader(fileName))
                        {
                            AudioStream astream = new AudioStream(audioFile);
                            playList.Add(astream);
                        }
                    }
                }
            }
            return playList;
        }

        public static List<Stream> SaveCollection(AudioCollection collection) // метод  должен быть войдовским
        {
            List<Stream> SavedAudioCollection = new List<Stream>();

            foreach (AudioStream stream in collection)
            {
                for (int i = 0; i < collection.Count(); i++)
                {
                    if (collection.FileNames[i].EndsWith(".mp3"))
                    {
                        byte[] audioinbytes = File.ReadAllBytes(collection.FileNames[i]);

                        using (FileStream bytesToAudio = File.Create(collection.FileNames[i] + ".mp3"))
                        {
                            bytesToAudio.Write(audioinbytes, 0, audioinbytes.Length);
                            Stream audioFile = bytesToAudio;
                            bytesToAudio.Close();
                            SavedAudioCollection.Add(audioFile);
                        }
                    }
                    else if (collection.FileNames[i].EndsWith(".wav"))
                    {
                        byte[] audioinbytes = File.ReadAllBytes(collection.FileNames[i]);

                        using (FileStream bytesToAudio = File.Create(collection.FileNames[i] + ".wav"))
                        {
                            bytesToAudio.Write(audioinbytes, 0, audioinbytes.Length);
                            Stream audioFile = bytesToAudio;
                            bytesToAudio.Close();
                            SavedAudioCollection.Add(audioFile);
                        }
                    }
                }
            }
            return SavedAudioCollection;
        }

    }
}
