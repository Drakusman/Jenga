using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "StringList.asset",
        menuName = SOArchitecture_Utility.COLLECTION_LIST + "string",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 2)]
    public class StringList : ListCollection<string>
    {
    } 
}