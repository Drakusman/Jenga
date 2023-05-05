using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "Vector2GameEvent.asset",
        menuName = SOArchitecture_Utility.GAME_EVENT + "Structs/Vector2",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 10)]
    public sealed class Vector2GameEvent : TypeGameEvent1<Vector2>
    {
    } 
}