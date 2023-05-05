using SO_Architecture.Collections.Custom;
using UnityEngine;


namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "BoolArray2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "Bool[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class BoolArray2D : Array2DCollection<bool>
    {
    }
}