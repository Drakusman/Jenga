using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "UintArray2D.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY2D_SUBMENU + "uint[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 14)]
    public class UintArray2D : Array2DCollection<uint>
    {
    } 
}
