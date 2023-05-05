using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "ShortGameEvent.asset",
        menuName = SOArchitecture_Utility.ADVANCED_GAME_EVENT + "short",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 14)]
    public sealed class ShortGameEvent : TypeGameEvent1<short>
    {
    } 
}