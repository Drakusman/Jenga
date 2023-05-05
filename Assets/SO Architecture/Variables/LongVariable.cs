using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "LongVariable.asset",
        menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "long",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 9)]
    public class LongVariable : NumericStructVariable<long>
    {
        public override void Add(long t)
        {
            Value += t;
        }

        public override void Subtract(long t)
        {
            Value -= t;
        }

        public override void Multiply(long t)
        {
            Value *= t;
        }

        public override void Divide(long t)
        {
            Value /= t;
        }
    }
}