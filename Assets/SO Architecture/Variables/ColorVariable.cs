using SO_Architecture.Variables.Base;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ColorVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Structs/Color",
        order = 120)]
    public class ColorVariable : StructVariable<Color>
    {
    }
}