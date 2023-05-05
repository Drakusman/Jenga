using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "ColorList.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_LIST + "Structs/Color",
	    order = 120)]
	public class ColorList : ListCollection<Color>
	{
	}
}