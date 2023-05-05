using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "SceneArray2D.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY2D_SUBMENU + "Scene[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class SceneArray2D : Array2DCollection<sbyte>
    {
    }
}
