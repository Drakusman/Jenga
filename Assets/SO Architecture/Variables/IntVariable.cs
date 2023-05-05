using SO_Architecture.Variables.Base;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "IntVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "int",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class IntVariable : NumericStructVariable<int>
    {
        public override void Add(int t)
        {
            Value += t;
        }

        public override void Subtract(int t)
        {
            Value -= t;
        }

        public override void Multiply(int t)
        {
            Value *= t;
        }

        public override void Divide(int t)
        {
            Value /= t;
        }
    } 
}