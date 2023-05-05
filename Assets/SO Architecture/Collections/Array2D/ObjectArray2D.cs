using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ObjectArray2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "Object[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class ObjectArray2D : Array2DCollection<Object>
    {
    }
}