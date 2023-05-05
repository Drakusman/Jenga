using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "UnsignedShortGameEvent.asset",
        menuName = SOArchitecture_Utility.ADVANCED_GAME_EVENT + "ushort",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 18)]
    public sealed class UShortGameEvent : TypeGameEvent1<ushort>
    {
    } 
}