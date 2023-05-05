using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Vector4 Event Listener")]
    public sealed class Vector4GameEventListener : TypeEventListener1<Vector4>
    {
        protected override ScriptableObject GameEvent { get; }
        protected override UnityEventBase Response { get; }
    }
}