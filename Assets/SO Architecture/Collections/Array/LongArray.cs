using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "LongArray.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY_SUBMENU + "long[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class LongArray : ArrayCollection<long>
    {
    }
}
