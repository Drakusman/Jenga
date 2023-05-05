using UltEvents;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    public sealed class GameEventListener : MonoBehaviour
    {
        
        [SerializeField] private GameEvent gameEvent = null;
        [SerializeField] private UltEvent response = new UltEvent();

        private void OnEnable() => gameEvent.AddListener(this);
        private void OnDisable() => gameEvent.RemoveListener(this);
        public void OnEventRaised() => response.Invoke();
        
    }
}