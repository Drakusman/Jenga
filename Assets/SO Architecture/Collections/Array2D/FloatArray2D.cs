using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "FloatArray2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "float[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class FloatArray2D : Array2DCollection<float>
    {
    }
}
