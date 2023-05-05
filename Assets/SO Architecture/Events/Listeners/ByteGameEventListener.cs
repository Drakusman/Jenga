using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "byte Event Listener")]
    public sealed class ByteGameEventListener : TypeEventListener1<byte>
    {
        protected override ScriptableObject GameEvent { get; }
        protected override UnityEventBase Response { get; }
    }
}