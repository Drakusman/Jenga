using Game.Scripts.Data;
using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace Game.Scripts.InputManager.Selector
{
    [CreateAssetMenu(fileName = nameof(SelectorEvent), menuName = "Game/Selector/" + nameof(SelectorEvent))]
    public class SelectorEvent : TypeGameEvent1<APIDataClass>
    {
    }
}