using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ColorArray.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "Structs/Color[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class ColorArray : ArrayCollection<Color>
    {
    }
}
