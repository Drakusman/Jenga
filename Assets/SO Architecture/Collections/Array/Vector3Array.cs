using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector3Array.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "Structs/Vector3[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 14)]
    public class Vector3Array : ArrayCollection<Vector3>
    {
    }
}