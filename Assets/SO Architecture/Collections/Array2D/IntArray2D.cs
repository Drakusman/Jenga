using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "IntArray2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "int[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class IntArray2D : Array2DCollection<int>
    {
    }
}