using System;
using System.Collections.Generic;
using System.Linq;

namespace SO_Architecture.Collections.Custom
{
    public abstract class Array2DCollection<T> : Collection<T[,], T>
    {
        [UnityEngine.SerializeField] private T[,] baseCollection = new T[0, 0];

        protected override void InitCollectionIfNotInitialized()
        {
            if (!Initialized)
            {
                Initialized = true;

                if (typeof(T).IsSubclassOf(typeof(UnityEngine.Object)))
                    collection = (T[,])Activator.CreateInstance(typeof(T[,]), baseCollection);
                else
                {
                    collection = new T[baseCollection.GetLength(0), baseCollection.GetLength(1)];
                    if (collection == null) return;

                    for (var i = 0; i < baseCollection.GetLength(0); i++)
                    {
                        for (var j = 0; j < baseCollection.GetLength(1); j++)
                            collection[i, j] = (T)Activator.CreateInstance(typeof(T), new T[] { baseCollection[i, j] });
                    }
                }
            }
        }

        public T[,] Value
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
                    collection = new T[0, 0];

                collection = value;
            }
        }


        public T this[int index1, int index2]
        {
            get
            {
                InitCollectionIfNotInitialized();
                return collection[index1, index2];
            }
            set
            {
                InitCollectionIfNotInitialized();
                collection[index1, index2] = value;
                ChangeRaise();
            }
        }

        public void Clear()
        {
            InitCollectionIfNotInitialized();

            collection = new T[0, 0];
        }

        public bool Contains(T item)
        {
            InitCollectionIfNotInitialized();
            var index = new HashSet<T>();
            for (var i = 0; i < collection.GetLength(0); i++)
            {
                for (var j = 0; j < collection.GetLength(1); j++)
                    index.Add(collection[i, j]);
            }

            return index.Contains(item);
        }
        
        public void Reverse()
        {
            Array.Reverse(collection);
        }

        public void Sort()
        {
            Array.Sort(collection);
        }

        public override string ToString()
        {
            return "Collection<" + typeof(T) + ">(" + Count + ")";
        }
    }
}