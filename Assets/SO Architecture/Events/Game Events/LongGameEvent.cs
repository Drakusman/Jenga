using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "LongGameEvent.asset",
        menuName = SOArchitecture_Utility.ADVANCED_GAME_EVENT + "long",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 9)]
    public sealed class LongGameEvent : TypeGameEvent1<long>
    {
    } 
}