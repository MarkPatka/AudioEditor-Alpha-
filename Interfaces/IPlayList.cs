using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioEditor.Interfaces
{
    public interface IPlayList : IAudioCollection
    {
        IAudioStream Current { get; }
        void SetCurrentIndex(int index);
        void PrevIndex();
        void NextIndex();
        string PlayListName { get; set; }
        void Reverse();
        void SortByNames();
        void SortByDurations();

        event EventHandler OnCurrentChage;
    }
}
