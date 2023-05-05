using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "BoolVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "bool",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 5)]
    public sealed class BoolVariable : StructVariable<bool>
    {
    }
}