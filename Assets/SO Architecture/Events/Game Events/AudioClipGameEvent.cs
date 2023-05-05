using SO_Architecture.Events.Game_Events;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    [CreateAssetMenu(
        fileName = "AudioClipGameEvent.asset",
        menuName = SOArchitecture_Utility.ADVANCED_GAME_EVENT + "AudioClip",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_EVENTS + 5)]
    public sealed class AudioClipGameEvent : TypeGameEvent1<AudioClip>
    {

    }
}
