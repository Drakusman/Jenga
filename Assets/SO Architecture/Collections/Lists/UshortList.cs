using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "UShortList.asset",
        menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "ushort",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 18)]
    public class UShortList : ListCollection<ushort>
    {
    } 
}