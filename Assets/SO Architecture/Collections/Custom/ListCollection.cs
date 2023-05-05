using System;
using System.Collections.Generic;

namespace SO_Architecture.Collections.Custom
{
    public abstract class ListCollection<T> : Collection<List<T>, T>
    {
        [UnityEngine.SerializeField] private List<T> baseCollection = new List<T>();

        protected override void InitCollectionIfNotInitialized()
        {
            if (!Initialized)
            {
                Initialized = true;

                if (typeof(T).IsSubclassOf(typeof(UnityEngine.Object)))
                    collection = (List<T>)Activator.CreateInstance(typeof(List<T>), new object[] { baseCollection });
                else
                {
                    collection = new List<T>();
                    if (collection != null)
                        foreach (var item in baseCollection)
                            collection.Add((T)Activator.CreateInstance(typeof(T), new object[] { item }));
                }
            }
        }

        public List<T> Value
        {
            get { InitCollectionIfNotInitialized(); return collection; }
            set
            {
                if (!Initialized)
                    Initialized = true;
                else
                    collection.Clear();

                collection = value;
            }
        }


        public T this[int index]
        {
            get { InitCollectionIfNotInitialized(); return collection[index]; }
            set { InitCollectionIfNotInitialized(); collection[index] = value; ChangeRaise(); }
        }

        public void Add(T item)
        {
            InitCollectionIfNotInitialized();
            collection.Add(item);
            AddRaise(item);
        }

        public void Clear()
        {
            InitCollectionIfNotInitialized();

            for (int i = 0; i < collection.Count; i++)
                RemoveRaise(collection[i]);

            collection.Clear();
        }

        public bool Contains(T item)
        {
            InitCollectionIfNotInitialized();
            return collection.Contains(item);
        }

        public int IndexOf(T item)
        {
            InitCollectionIfNotInitialized();
            return collection.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            InitCollectionIfNotInitialized();
            collection.Insert(index, item);
            AddRaise(item);
        }

        public bool Remove(T item)
        {
            InitCollectionIfNotInitialized();
            bool removed = collection.Remove(item);
            if (removed)
                RemoveRaise(item);
            return removed;
        }

        public void RemoveAt(int index)
        {
            InitCollectionIfNotInitialized();
            RemoveRaise(collection[index]);
            collection.RemoveAt(index);
        }
        
        public T[] ToArray() {
            return collection.ToArray();
        }

        public override string ToString()
        {
            return "Collection<" + typeof(T) + ">(" + Count + ")";
        }
    }
}