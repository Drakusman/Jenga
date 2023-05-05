using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "IntGameEvent.asset",
        menuName = SOArchitecture_Utility.GAME_EVENT + "int",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 4)]
    public sealed class IntGameEvent : TypeGameEvent1<int>
    {
    } 
}