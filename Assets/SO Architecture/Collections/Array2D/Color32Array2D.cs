using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Color32Array2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "Structs/Color32[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class Color3Array2D : Array2DCollection<Color32>
    {
    }
}