using AudioEditor.Data;
using AudioEditor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioEditor.Logics.Processors
{
    public static class PlayListProcessor
    {
        // - дать пустой плэйлист +
        // - открыть и отдать заполненный плэйлист по имени файла плэйлиста +
        // - создать плэйлист на основе множества имен файлов - сделать на визуалке циклом,
        //   испольуя метод добавления одного файла
        // - добавление одного файла +
        // - удаление по ссылке +
        // - сохранение плэйлиста - хранится в виде путей к файлам на слое данных +
        // - сортировка по имени файла +
        // - сортировка по длительности +
        
        public static IPlayList GetNewPlayList(string playListName = "Noname")
        {
            PlayList list = new PlayList(playListName); 
            return list;
        }

        public static IPlayList OpenPlayList(string playListName)
        {
            IPlayList list = DataManager.OpenPlaylist(playListName);
            return list;
        }

        public static IPlayList SavePlayList(string playListPath, IPlayList list)
        {
            DataManager.SavePlaylist(playListPath, list);
            return list;
        }

        public static IPlayList AddAudioInPlayList(string[] fileNames, IPlayList list)
        {         
            foreach (string fileName in fileNames)
            {
                IAudioStream file = DataManager.OpenAudiofile(fileName);
                list.Add(file);
            }
            return list;
        }

        public static IPlayList RemoveAudioFromPlayList(IAudioStream item, IPlayList list)
        {
            list.Remove(item);
            return list;
        }

        public static IPlayList SortPlayListByName(IPlayList list)
        {
            list.SortByNames();
            return list;
        }

        public static IPlayList SortPlayListByDuration(IPlayList list)
        {
            list.SortByDurations();
            return list;
        }

        public static IPlayList ClearPlayList(IPlayList list)
        {
            (list as PlayList).Clear();
            return list;
        }
    }
}
