using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "GameObjectGameEvent.asset",
        menuName = SOArchitecture_Utility.GAME_EVENT + "GameObject",
        order = 120)]
    public sealed class GameObjectGameEvent : TypeGameEvent1<GameObject>
    {
    } 
}