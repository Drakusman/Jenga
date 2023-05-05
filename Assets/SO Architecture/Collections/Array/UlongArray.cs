using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "UlongArray.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY_SUBMENU + "ulong[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 14)]
    public class UlongArray : ArrayCollection<ulong>
    {
    } 
}
