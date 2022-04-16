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
    public class AudioCollection : IAudioCollection
    {

        protected List<IAudioStream> collection;
        public List<IAudioStream> Collection
        {
            get => collection;
            private set => collection = value;
        }

        public List<string> FileNames => 
            Collection.Select(t => t.FileName).ToList();

        public int Count => Collection.Count;
      
        public IEnumerator<IAudioStream> GetEnumerator() => 
            Collection.GetEnumerator() as IEnumerator<IAudioStream>;
        IEnumerator IEnumerable.GetEnumerator() =>
            Collection.GetEnumerator();

        public IAudioStream this[int index]
        {
            get => Collection[index];
            set => Collection[index] = value;
        }

        public IAudioStream this[string fileName]
        {
            get => Collection.Find(t => t.FileName.Contains(fileName));
            set
            {
                IAudioStream stream = Collection.Find(t => t.FileName.Contains(fileName));
                if (stream != null) stream = value;
            }
        }

        public virtual void Add(IAudioStream item)
        {
            Collection.Add(item);
        }

        public virtual void Remove(IAudioStream item)
        {
            Collection.Remove(item);            
        }

        public virtual void Clear()
        {
            collection.Clear();
        }

    }
}
