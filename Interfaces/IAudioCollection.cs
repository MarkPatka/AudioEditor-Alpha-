using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioEditor.Interfaces
{
    public interface IAudioCollection : IEnumerable<IAudioStream>
    {
        List<IAudioStream> Collection { get; }
        List<string> FileNames { get; }

        IAudioStream this[int index] { get; set; }
        IAudioStream this[string fileName] { get; set; }

        void Add(IAudioStream item);
        void Remove(IAudioStream item);
        void Clear();
    }
}
