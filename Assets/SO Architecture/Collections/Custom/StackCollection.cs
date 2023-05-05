using System;
using System.Collections.Generic;

namespace SO_Architecture.Collections.Custom
{
    public abstract class StackCollection<T> : Collection<Stack<T>, T>
    {
        [UnityEngine.SerializeField] private Stack<T> _baseCollection = new Stack<T>();

        protected override void InitCollectionIfNotInitialized()
        {
            if (!Initialized)
            {
                Initialized = true;

                if (typeof(T).IsSubclassOf(typeof(UnityEngine.Object)))
                    collection = (Stack<T>)Activator.CreateInstance(typeof(Stack<T>), new object[] { _baseCollection });
                else
                {
                    collection = new Stack<T>();
                    if (collection == null) return;
                    
                    foreach (var item in _baseCollection)
                        collection.Push((T)Activator.CreateInstance(typeof(T), new object[] { item }));
                }
            }
        }

        public Stack<T> Value
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
                    for (var i = 0; i < collection.Count; i++)
                        RemoveRaise(collection.Pop());

                collection = value;
            }
        }


        public void Push(T t)
        {
            InitCollectionIfNotInitialized();
            collection.Push(t);
            AddRaise(t);
        }

        public void Pop()
        {
            InitCollectionIfNotInitialized();
            RemoveRaise(collection.Pop());
        }

        public T Peek()
        {
            InitCollectionIfNotInitialized();
            return collection.Peek();
        }

        public void Clear()
        {
            InitCollectionIfNotInitialized();

            for (var i = 0; i < collection.Count; i++)
                Pop();
        }
    }
}