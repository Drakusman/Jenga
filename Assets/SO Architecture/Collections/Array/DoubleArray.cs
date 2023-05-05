using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "DoubleArray.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY_SUBMENU + "Double[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class DoubleArray : ArrayCollection<Color>
    {
    }
}