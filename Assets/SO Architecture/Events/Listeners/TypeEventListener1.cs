﻿using System.Collections.Generic;
using SO_Architecture.Events.Game_Events;
using UltEvents;
using UnityEngine;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace ScriptableObjectArchitecture
{
    public abstract class TypeEventListener1<T1> : DebuggableGameEventListener
    {
        [SerializeReference] private TypeGameEvent1<T1> gameEvent = null;
        [SerializeField] private UltEvent<T1> response = new UltEvent<T1>();

        private void OnEnable() => gameEvent.AddListener(this);
        private void OnDisable() => gameEvent.RemoveListener(this);
        public void OnEventRaised(T1 t) => response.Invoke(t);
        
    }
    public abstract class DebuggableGameEventListener : SOArchitectureBaseMonobehaviour, IStackTraceObject
    {
#pragma warning disable 0414
        [SerializeField]
        private bool _showDebugFields = false;
        [SerializeField]
        private bool _enableGizmoDebugging = true;
        [SerializeField]
        private Color _debugColor = Color.cyan;
#pragma warning restore

        public List<StackTraceEntry> StackTraces { get { return _stackTraces; } }
        private List<StackTraceEntry> _stackTraces = new List<StackTraceEntry>();

        protected abstract ScriptableObject GameEvent { get; }
        protected abstract UnityEventBase Response { get; }

        public void AddStackTrace(object obj)
        {
#if UNITY_EDITOR
            StackTraces.Insert(0, StackTraceEntry.Create(obj));
#endif
        }
        public void AddStackTrace()
        {
#if UNITY_EDITOR
            StackTraces.Insert(0, StackTraceEntry.Create());
#endif
        }
        protected void CreateDebugEntry(UnityEventBase response)
        {
#if UNITY_EDITOR
            for (int i = 0; i < response.GetPersistentEventCount(); i++)
            {
                GameObject gameObjectTarget = GetGameObject(response.GetPersistentTarget(i));

                if (gameObject == null || gameObjectTarget == null)
                    continue;

                if (Vector3.Distance(gameObject.transform.position, gameObjectTarget.transform.position) <= EVENT_MIN_DISTANCE)
                    continue;

                string targetName = gameObject ? gameObject.name : "Null";

                string functionName = string.Format("{0} ({1})", targetName, response.GetPersistentMethodName(i));

                _debugEntries.Add(new DebugEvent(gameObjectTarget, functionName));
            }
#endif
        }

#if UNITY_EDITOR
        private const float DOTTED_LINE_LENGTH = 5;
        private const float DOT_LENGTH = 0.5f;
        private const float DOT_WIDTH = 3;
        private const float EVENT_MOVEMENT_SPEED = 3;
        private const float EVENT_MIN_DISTANCE = 0.3f;

        private List<DebugEvent> _debugEntries = new List<DebugEvent>();

        private static class Styles
        {
            static Styles()
            {
                TextStyle = new GUIStyle();
                TextStyle.alignment = TextAnchor.UpperCenter;
            }

            public static GUIStyle TextStyle;
        }
        private void OnDrawGizmos()
        {
            UpdateDebugInfo();
        }
        private void UpdateDebugInfo()
        {
            Handles.color = _debugColor;
            Styles.TextStyle.normal.textColor = _debugColor;

            DrawLine();
            DrawEvents();
        }
        private void DrawEvents()
        {
            for (int i = _debugEntries.Count - 1; i >= 0; i--)
            {
                DrawEvent(i);
            }
        }
        private void DrawEvent(int index)
        {
            DebugEvent debugEvent = _debugEntries[index];

            if (debugEvent.Target == null)
                return;

            debugEvent.Offset += EVENT_MOVEMENT_SPEED * Time.deltaTime;

            Vector3 delta = (debugEvent.Target.transform.position - gameObject.transform.position).normalized;
            Vector3 position = gameObject.transform.position + (delta * debugEvent.Offset);

            DrawPoint(position, delta);
            DrawText(position, debugEvent);

            if (debugEvent.Offset >= Vector3.Distance(gameObject.transform.position, debugEvent.Target.transform.position))
            {
                _debugEntries.RemoveAt(index);
            }
        }
        private void DrawText(Vector3 position, DebugEvent debugEvent)
        {
            if (!EnableGizmoDebuggin())
                return;

            string text = string.Join("\n", new string[] { GameEvent.name, debugEvent.FunctionName });

            Handles.Label(position, text, Styles.TextStyle);
        }
        private void DrawLine()
        {
            if (!EnableGizmoDebuggin())
                return;

            List<GameObject> listeningObjects = new List<GameObject>();

            for (int i = 0; i < Response.GetPersistentEventCount(); i++)
            {
                AddObject(listeningObjects, Response.GetPersistentTarget(i));
            }

            foreach (GameObject obj in listeningObjects)
            {
                if (gameObject == obj)
                    continue;

                Handles.DrawDottedLine(transform.position, obj.transform.position, DOTTED_LINE_LENGTH);
            }
        }
        private void DrawPoint(Vector3 position, Vector3 direction)
        {
            if (EnableGizmoDebuggin())
                Handles.DrawAAPolyLine(DOT_WIDTH, position, position + (direction.normalized * DOT_LENGTH));
        }
        private bool EnableGizmoDebuggin()
        {
            if (!SOArchitecturePreferences.AreGizmosEnabled)
                return false;

            return _enableGizmoDebugging;
        }
        private void AddObject(List<GameObject> listeningObjects, Object obj)
        {
            GameObject toAdd = GetGameObject(obj);

            if (!listeningObjects.Contains(toAdd) && toAdd != null)
            {
                listeningObjects.Add(toAdd);
            }
        }
        private GameObject GetGameObject(Object obj)
        {
            if (obj is Component)
            {
                Component component = obj as Component;

                return component.gameObject;
            }
            else if (obj is GameObject)
            {
                return obj as GameObject;
            }
            else
            {
                return null;
            }
        }
        private class DebugEvent
        {
            public DebugEvent(GameObject target, string methodName)
            {
                FunctionName = methodName;
                Target = target;
                Offset = 0;
            }

            public float Offset;
            public GameObject Target;
            public string FunctionName;
        }
#endif
    } 
}