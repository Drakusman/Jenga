using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "sbyte Event Listener")]
    public sealed class SByteGameEventListener : TypeEventListener1<sbyte>
    {
        protected override ScriptableObject GameEvent { get; }
        protected override UnityEventBase Response { get; }
    }
}