using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ColorArray2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "Structs/Color[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class ColorArray2D : Array2DCollection<Color>
    {
    }
}
