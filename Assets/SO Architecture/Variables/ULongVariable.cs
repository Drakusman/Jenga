using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public class ULongEvent : UnityEvent<ulong> { }

    [CreateAssetMenu(
        fileName = "UnsignedLongVariable.asset",
        menuName = SOArchitecture_Utility.ADVANCED_VARIABLE_SUBMENU + "ulong",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 17)]
    public class ULongVariable : Variable<ulong>
    {
        protected override ulong Init()
        {
            return Value;
        }
    } 
}