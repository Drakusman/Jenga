using SO_Architecture.Variables.Base;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{

    [CreateAssetMenu(
        fileName = "SByteVariable.asset",
        menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "sbyte",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 15)]
    public class SByteVariable : NumericStructVariable<sbyte>
    {
        public override void Add(sbyte t)
        {
            throw new System.NotImplementedException();
        }

        public override void Subtract(sbyte t)
        {
            throw new System.NotImplementedException();
        }

        public override void Multiply(sbyte t)
        {
            throw new System.NotImplementedException();
        }

        public override void Divide(sbyte t)
        {
            throw new System.NotImplementedException();
        }
    } 
}