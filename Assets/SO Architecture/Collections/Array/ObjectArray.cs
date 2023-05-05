using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ObjectArray.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "Object[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class ObjectArray : ArrayCollection<Object>
    {
    }
}