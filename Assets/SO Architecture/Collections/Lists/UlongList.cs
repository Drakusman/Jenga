using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ULongList.asset",
        menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "ulong",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 17)]
    public class ULongList : ListCollection<ulong>
    {
    } 
}