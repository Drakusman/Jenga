using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "DoubleVariable.asset",
        menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "double",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 8)]
    public class DoubleVariable : NumericStructVariable<double>
    {
        public override void Add(double t)
        {
            Value += t;
        }

        public override void Subtract(double t)
        {
            Value -= t;
        }

        public override void Multiply(double t)
        {
            Value *= t;
        }

        public override void Divide(double t)
        {
            Value /= t;
        }
    }
}