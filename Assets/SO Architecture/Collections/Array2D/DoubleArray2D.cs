using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "DoubleArray2D.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY2D_SUBMENU + "Double[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class DoubleArray2D : Array2DCollection<Color>
    {
    }
}