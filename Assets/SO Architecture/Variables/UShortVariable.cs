using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "UnsignedShortVariable.asset",
        menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "ushort",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 18)]
    public class UShortVariable : NumericStructVariable<ushort>
    {
        public override void Add(ushort t)
        {
            Value += t;
        }

        public override void Subtract(ushort t)
        {
            Value -= t;
        }

        public override void Multiply(ushort t)
        {
            Value *= t;
        }

        public override void Divide(ushort t)
        {
            Value /= t;
        }
    }
}