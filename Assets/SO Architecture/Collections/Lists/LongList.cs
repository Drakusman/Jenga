using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "LongList.asset",
        menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "long",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 9)]
    public class LongList : ListCollection<long>
    {
    } 
}