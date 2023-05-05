using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "Vector3List.asset",
        menuName = SOArchitecture_Utility.COLLECTION_LIST + "Structs/Vector3",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 11)]
    public class Vector3List : ListCollection<Vector3>
    {
    } 
}