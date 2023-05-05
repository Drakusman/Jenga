using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;

namespace SO_Architecture.Collections.Custom
{
    public abstract class Collection<CollectionType, Type> : UnityEngine.ScriptableObject, IEnumerable, ICollectionCount
        where CollectionType : ICollection
    {
        [ShowInInspector, HideInEditorMode] protected CollectionType collection = default;
        [NonSerialized] protected bool Initialized = false;

        public int Count { get { InitCollectionIfNotInitialized(); return collection.Count; } }

        public IEnumerator GetEnumerator()
        {
            InitCollectionIfNotInitialized();
            return collection.GetEnumerator();
        }

        protected abstract void InitCollectionIfNotInitialized();

        private readonly List<Action> _changeActions = new List<Action>();
        private readonly List<Action<Type>> _addActions = new List<Action<Type>>();
        private readonly List<Action<Type>> _removeActions = new List<Action<Type>>();

        private List<Action> _temporaryChangeActions;
        private List<Action<Type>> _temporaryAddActions;
        private List<Action<Type>> _temporaryRemoveActions;

        public void AddOnChangeListener(Action action) => _changeActions.Add(action);
        public void RemoveOnChangeListener(Action action) => _changeActions.Remove(action);

        public void AddOnAddListener(Action<Type> listener) => _addActions.Add(listener);
        public void RemoveOnAddListener(Action<Type> listener) => _addActions.Remove(listener);

        public void AddOnRemoveListener(Action<Type> listener) => _removeActions.Add(listener);
        public void RemoveOnRemoveListener(Action<Type> listener) => _removeActions.Remove(listener);

        protected void ChangeRaise()
        {
            _temporaryChangeActions = new List<Action>(_changeActions);

            for (var i = 0; i < _temporaryChangeActions.Count; i++)
                _temporaryChangeActions[i].Invoke();
        }

        protected void AddRaise(Type t)
        {
            _temporaryAddActions = new List<Action<Type>>(_addActions);

            for (var i = 0; i < _temporaryAddActions.Count; i++)
                _temporaryAddActions[i].Invoke(t);

            ChangeRaise();
        }

        protected void RemoveRaise(Type t)
        {
            _temporaryRemoveActions = new List<Action<Type>>(_removeActions);

            for (var i = 0; i < _temporaryRemoveActions.Count; i++)
                _temporaryRemoveActions[i].Invoke(t);

            ChangeRaise();
        }
    }
}