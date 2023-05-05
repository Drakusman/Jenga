using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "GameObjectArray2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "GameObject[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class GameObjectArray2D : Array2DCollection<GameObject>
    {
    }
}
