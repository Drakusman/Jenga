using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "FloatList.asset",
        menuName = SOArchitecture_Utility.COLLECTION_LIST + "float",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 3)]
    public class FloatList : ListCollection<float>
    {
    } 
}