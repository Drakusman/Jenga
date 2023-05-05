using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector4Array2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "Structs/Vector4[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 14)]
    public class Vector4Array2D : Array2DCollection<Vector4>
    {
    }
}