using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Quaternion Event Listener")]
    public sealed class QuaternionGameEventListener : TypeEventListener1<Quaternion>
    {
        protected override ScriptableObject GameEvent { get; }
        protected override UnityEventBase Response { get; }
    }
}