using AudioEditor.Interfaces;
using NAudio.Wave;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioEditor.Logics
{
    public class PlayList : AudioCollection, IPlayList
    {
        private int currentIndex = -1;

        public event EventHandler OnCurrentChage;

        public string PlayListName { get; set; } // пользовательское имя

        public IAudioStream Current => IsEmpty || currentIndex < 0 ? 
            null : Collection[currentIndex];

        public bool IsEmpty => Collection == null || Collection.Count == 0;

        public void SetCurrentIndex(int index)
        {
            if (index < 0 || index >= Collection.Count)
                throw new IndexOutOfRangeException("Неверное значение индекса!");
            currentIndex = index;
            OnCurrentChage?.Invoke(this, null);
        }

        public PlayList(string playListName = "Noname")
        {
            PlayListName = playListName;
            collection = new List<IAudioStream>();
        }

        public void Reverse()
        {
            Collection?.Reverse();
        }

        public void SortByNames()
        {
            collection = (from stream in Collection
                          orderby stream.FileName
                          select stream).ToList();
        }

        public void SortByDurations()
        {
            collection = (from stream in Collection
                          orderby stream.TotalTime
                          select stream).ToList();
        }

        public override void Add(IAudioStream item)
        {
            base.Add(item);
            if (Count > 0 || currentIndex < 0)
            {
                currentIndex = 0;
                OnCurrentChage?.Invoke(this, null);
            }
        }

        public override void Remove(IAudioStream item)
        {
            if (Current == item)
            {
                if (currentIndex > 0)
                {
                    currentIndex--;
                    OnCurrentChage?.Invoke(this, null);
                }
            }

            base.Remove(item);
            if (Count == 0)
            {
                currentIndex = -1;
                OnCurrentChage?.Invoke(this, null);
            }
        }

        public override void Clear()
        {
            base.Clear();
            currentIndex = -1;
            OnCurrentChage?.Invoke(this, null);
        }

        public void NextIndex()
        {
            if (currentIndex < 0) return;
            if (currentIndex == Count - 1) currentIndex = 0;
            else currentIndex++;
            OnCurrentChage?.Invoke(this, null);
        }
        public void PrevIndex()
        {
            if (currentIndex < 0) return;
            if (currentIndex == 0) currentIndex = Count - 1;
            else currentIndex--;
            OnCurrentChage?.Invoke(this, null);
        }

    }
}
