using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "StringArray2D.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY2D + "string[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 14)]
    public class StringArray2D : Array2DCollection<string>
    {
    } 
}
