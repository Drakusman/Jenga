using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Object Event Listener")]
    public class ObjectGameEventListener : TypeEventListener1<Object>
    {
        protected override ScriptableObject GameEvent { get; }
        protected override UnityEventBase Response { get; }
    }
}