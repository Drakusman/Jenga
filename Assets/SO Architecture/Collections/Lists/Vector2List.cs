using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector2List.asset",
        menuName = SOArchitecture_Utility.COLLECTION_LIST + "Structs/Vector2",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 10)]
    public class Vector2List : ListCollection<Vector2>
    {
    } 
}