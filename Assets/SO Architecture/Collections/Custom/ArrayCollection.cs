using System;
using System.Collections.Generic;
using System.Linq;

namespace SO_Architecture.Collections.Custom
{
    public abstract class ArrayCollection<T> : Collection<T[], T>
    {
        [UnityEngine.SerializeField] private T[] baseCollection = Array.Empty<T>();

        protected override void InitCollectionIfNotInitialized()
        {
            if (!Initialized)
            {
                Initialized = true;

                if (typeof(T).IsSubclassOf(typeof(UnityEngine.Object)))
                    collection = (T[])Activator.CreateInstance(typeof(T[]), new object[] { baseCollection });
                else
                {
                    collection = new T[baseCollection.Length];
                    if (collection == null) return;

                    for (var i = 0; i < baseCollection.Length; i++)
                        collection[i] = (T)Activator.CreateInstance(typeof(T), new object[] { baseCollection[i] });
                }
            }
        }

        public T[] Value
        {
            get
            {
                InitCollectionIfNotInitialized();
                return collection;
            }
            set
            {
                if (!Initialized)
                    Initialized = true;
                else
                    collection = Array.Empty<T>();

                collection = value;
            }
        }


        public T this[int index]
        {
            get
            {
                InitCollectionIfNotInitialized();
                return collection[index];
            }
            set
            {
                InitCollectionIfNotInitialized();
                collection[index] = value;
                ChangeRaise();
            }
        }

        public void Clear()
        {
            InitCollectionIfNotInitialized();

            collection = Array.Empty<T>();
        }

        public bool Contains(T item)
        {
            InitCollectionIfNotInitialized();
            return collection.Contains(item);
        }

        public int IndexOf(T item)
        {
            InitCollectionIfNotInitialized();
            return Array.IndexOf(collection, item);
        }

        public void Reverse()
        {
            Array.Reverse(collection);
        }

        public void Sort()
        {
            Array.Sort(collection);
        }

        public List<T> ToList()
        {
            return collection.ToList();
        }

        public override string ToString()
        {
            return "Collection<" + typeof(T) + ">(" + Count + ")";
        }
    }
}