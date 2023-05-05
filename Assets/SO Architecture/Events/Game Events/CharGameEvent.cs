using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "CharGameEvent.asset",
        menuName = SOArchitecture_Utility.ADVANCED_GAME_EVENT + "char",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 7)]
    public sealed class CharGameEvent : TypeGameEvent1<char>
    {
    } 
}