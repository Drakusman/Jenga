using SO_Architecture.Variables.Base;
using SO_Architecture.Variables.Custom;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{

	[CreateAssetMenu(
	    fileName = "AnimationCurveVariable.asset",
	    menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "AnimationCurve",
	    order = 120)]
	public class AnimationCurveVariable : SerializeFieldClassVariable<AnimationCurve>
	{
	
	}
}