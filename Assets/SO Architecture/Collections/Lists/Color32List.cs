using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "Color32List.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_LIST + "Structs/Color32",
	    order = 120)]
	public class Color32List : ListCollection<Color32>
	{
	}
}