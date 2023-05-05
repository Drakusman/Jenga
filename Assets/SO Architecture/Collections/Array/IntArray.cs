using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "IntArray.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "int[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class IntArray : ArrayCollection<int>
    {
    }
}