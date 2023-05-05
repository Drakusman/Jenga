using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Color32Array.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "Structs/Color32[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class Color32Array : ArrayCollection<Color32>
    {
    }
}