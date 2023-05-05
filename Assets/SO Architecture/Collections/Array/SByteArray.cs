using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "SByteArray.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY_SUBMENU + "sbyte[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class SByteArray : ArrayCollection<sbyte>
    {
    }
}