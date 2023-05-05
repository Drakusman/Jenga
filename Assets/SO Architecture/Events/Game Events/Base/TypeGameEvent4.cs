using System;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using SO_Architecture.Events.Listeners;

namespace SO_Architecture.Events.Game_Events
{
    public abstract class TypeGameEvent4<T1, T2, T3, T4> : GameEvent
    {
        private readonly List<TypeEventListener4<T1, T2, T3, T4>> typedListeners = new List<TypeEventListener4<T1, T2, T3, T4>>();
        private readonly List<Action<T1, T2, T3, T4>> typedActions = new List<Action<T1, T2, T3, T4>>();

        private List<TypeEventListener4<T1, T2, T3, T4>> temporaryTypedListeners;
        private List<Action<T1, T2, T3, T4>> temporaryTypedActions;

        [Sirenix.OdinInspector.Button("Raise Value")]
        public void Raise(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            temporaryTypedListeners = new List<TypeEventListener4<T1, T2, T3, T4>>(typedListeners);
            temporaryTypedActions = new List<Action<T1, T2, T3, T4>>(typedActions);

            for (int i = 0; i < temporaryTypedListeners.Count; i++)
                temporaryTypedListeners[i].OnEventRaised(t1, t2, t3, t4);

            for (int i = 0; i < temporaryTypedActions.Count; i++)
                temporaryTypedActions[i].Invoke(t1, t2, t3, t4);

            Raise();
        }

        public void AddListener(TypeEventListener4<T1, T2, T3, T4> listener) => typedListeners.Add(listener);
        public void AddListener(Action<T1, T2, T3, T4> listener) => typedActions.Add(listener);

        public void RemoveListener(TypeEventListener4<T1, T2, T3, T4> listener) => typedListeners.Remove(listener);
        public void RemoveListener(Action<T1, T2, T3, T4> listener) => typedActions.Remove(listener);
    }
}