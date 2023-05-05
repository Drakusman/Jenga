using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "SByteList.asset",
        menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "sbyte",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 15)]
    public class SByteList : ListCollection<sbyte>
    {
    } 
}