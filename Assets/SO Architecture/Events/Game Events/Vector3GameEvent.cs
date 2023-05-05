using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "Vector3GameEvent.asset",
        menuName = SOArchitecture_Utility.GAME_EVENT + "Structs/Vector3",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 11)]
    public sealed class Vector3GameEvent : TypeGameEvent1<Vector3>
    {
    } 
}