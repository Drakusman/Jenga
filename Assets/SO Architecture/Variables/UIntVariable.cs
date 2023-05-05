using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "UnsignedIntVariable.asset",
        menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "uint",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 16)]
    public class UIntVariable : NumericStructVariable<uint>
    {
        public override void Add(uint t)
        {
            Value += t;
        }

        public override void Subtract(uint t)
        {
            Value -= t;
        }

        public override void Multiply(uint t)
        {
            Value *= t;
        }

        public override void Divide(uint t)
        {
            Value /= t;
        }
    }
}