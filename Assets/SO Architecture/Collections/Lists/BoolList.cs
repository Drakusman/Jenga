using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "BoolList.asset",
        menuName = SOArchitecture_Utility.COLLECTION_LIST + "bool",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 5)]
    public class BoolList : ListCollection<bool>
    {
    } 
}