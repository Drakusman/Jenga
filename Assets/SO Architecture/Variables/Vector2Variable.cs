using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector2Variable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Structs/Vector2",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 10)]
    public sealed class Vector2Variable : StructVariable<Vector2>
    {
    }
}