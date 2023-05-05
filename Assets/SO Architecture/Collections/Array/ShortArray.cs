using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ShortArray.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY_SUBMENU + "short[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 14)]
    public class ShortArray : ArrayCollection<short>
    {
    } 
}
