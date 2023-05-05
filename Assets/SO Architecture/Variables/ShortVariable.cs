using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public class ShortEvent : UnityEvent<short>
    {
    }

    [CreateAssetMenu(
        fileName = "ShortVariable.asset",
        menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "short",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 14)]
    public class ShortVariable : NumericStructVariable<short>
    {
        public override void Add(short t)
        {
            Value += t;
        }

        public override void Subtract(short t)
        {
            Value -= t;
        }

        public override void Multiply(short t)
        {
            Value *= t;
        }

        public override void Divide(short t)
        {
            Value /= t;
        }
    }
}