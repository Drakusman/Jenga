using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "AudioClipList.asset",
	    menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "AudioClip",
	    order = 120)]
	public class AudioClipList : ListCollection<AudioClip>
	{
	}
}