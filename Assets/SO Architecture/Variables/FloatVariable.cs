using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "FloatVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "float",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 3)]
    public class FloatVariable : NumericStructVariable<float>
    {
        public override void Add(float t)
        {
            Value += t;
        }

        public override void Subtract(float t)
        {
            Value -= t;
        }

        public override void Multiply(float t)
        {
            Value *= t;
        }

        public override void Divide(float t)
        {
            Value /= t;
        }
    }
}