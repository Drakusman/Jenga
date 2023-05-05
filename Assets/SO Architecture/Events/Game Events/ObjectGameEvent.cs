using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "ObjectGameEvent.asset",
        menuName = SOArchitecture_Utility.GAME_EVENT + "Object",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 1)]
    public class ObjectGameEvent : TypeGameEvent1<Object>
    {
    } 
}