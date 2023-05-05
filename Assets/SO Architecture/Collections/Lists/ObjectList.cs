using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ObjectList.asset",
        menuName = SOArchitecture_Utility.COLLECTION_LIST + "Object",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 1)]
    public class ObjectList : ListCollection<Object>
    {
    } 
}