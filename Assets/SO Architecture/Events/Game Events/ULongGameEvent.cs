using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "UnsignedLongGameEvent.asset",
        menuName = SOArchitecture_Utility.ADVANCED_GAME_EVENT + "ulong",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 17)]
    public sealed class ULongGameEvent : TypeGameEvent1<ulong>
    {
    } 
}