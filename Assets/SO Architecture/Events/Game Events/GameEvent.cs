using System;
using UnityEngine;
using System.Collections.Generic;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "GameEvent.asset",
        menuName = SOArchitecture_Utility.GAME_EVENT + "GameEvent",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 5)]
    public class GameEvent : ScriptableObject/*, IStackTraceObject*/
    {
        private readonly List<GameEventListener> listeners = new List<GameEventListener>();
        private readonly List<Action> actions = new List<Action>();

        private List<GameEventListener> temporaryListeners;
        private List<Action> temporaryActions;

//         public List<StackTraceEntry> StackTraces
//         {
//             get { return _stackTraces; }
//         }
//
//         private List<StackTraceEntry> _stackTraces = new List<StackTraceEntry>();
//
//         public void AddStackTrace()
//         {
// #if UNITY_EDITOR
//             if (SOArchitecturePreferences.IsDebugEnabled)
//                 _stackTraces.Insert(0, StackTraceEntry.Create());
// #endif
//         }
//
//         public void AddStackTrace(object value)
//         {
// #if UNITY_EDITOR
//             if (SOArchitecturePreferences.IsDebugEnabled)
//                 _stackTraces.Insert(0, StackTraceEntry.Create(value));
// #endif
//         }

        [Sirenix.OdinInspector.Button("Raise")]
        public void Raise()
        {
          //  AddStackTrace();
            temporaryListeners = new List<GameEventListener>(listeners);
            temporaryActions = new List<Action>(actions);


            for (var i = 0; i < temporaryListeners.Count; i++)
                temporaryListeners[i].OnEventRaised();

            for (var i = 0; i < temporaryActions.Count; i++)
                temporaryActions[i].Invoke();
        }

        public void AddListener(GameEventListener listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public void RemoveListener(GameEventListener listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }

        public void AddListener(System.Action action)
        {
            if (!actions.Contains(action))
                actions.Add(action);
        }

        public void RemoveListener(System.Action action)
        {
            if (actions.Contains(action))
                actions.Remove(action);
        }

        public virtual void RemoveAll()
        {
            listeners.RemoveRange(0, listeners.Count);
            actions.RemoveRange(0, actions.Count);
        }
    }
}