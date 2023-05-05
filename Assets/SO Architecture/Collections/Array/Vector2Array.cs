using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector2Array.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "Structs/Vector2[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 14)]
    public class Vector2Array : ArrayCollection<Vector2>
    {
    }
}
