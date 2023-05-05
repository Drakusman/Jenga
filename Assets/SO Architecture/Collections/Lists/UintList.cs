using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "UIntList.asset",
        menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "uint",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 16)]
    public class UIntList : ListCollection<uint>
    {
    } 
}