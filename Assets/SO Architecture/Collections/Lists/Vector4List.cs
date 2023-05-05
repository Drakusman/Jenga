using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector4List.asset",
        menuName = SOArchitecture_Utility.COLLECTION_LIST + "Structs/Vector4",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 12)]
    public class Vector4List : ListCollection<Vector4>
    {
    } 
}