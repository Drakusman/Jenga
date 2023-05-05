using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "StringGameEvent.asset",
        menuName = SOArchitecture_Utility.GAME_EVENT + "string",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 2)]
    public sealed class StringGameEvent : TypeGameEvent1<string>
    {
    } 
}