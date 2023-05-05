using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "AnimationCurveList.asset",
	    menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "AnimationCurve",
	    order = 120)]
	public class AnimationCurveList : ListCollection<AnimationCurve>
	{
	}
}