using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector3Array2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "Structs/Vector3[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 14)]
    public class Vector3Array2D : Array2DCollection<Vector3>
    {
    }
}