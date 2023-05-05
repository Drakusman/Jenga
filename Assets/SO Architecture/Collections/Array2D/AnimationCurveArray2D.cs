using SO_Architecture.Collections.Custom;
using UnityEngine;


namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "AnimationCurveArray2D.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY2D_SUBMENU + "AnimationCurve[,]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class AnimationCurveArray2D : Array2DCollection<AnimationCurve>
    {
    }
}

