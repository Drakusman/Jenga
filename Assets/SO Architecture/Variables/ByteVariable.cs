using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ByteVariable.asset",
        menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "byte",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 6)]
    public class ByteVariable : NumericStructVariable<byte>
    {
        public override void Add(byte t)
        {
            throw new System.NotImplementedException();
        }

        public override void Subtract(byte t)
        {
            throw new System.NotImplementedException();
        }

        public override void Multiply(byte t)
        {
            throw new System.NotImplementedException();
        }

        public override void Divide(byte t)
        {
            throw new System.NotImplementedException();
        }
    } 
}