using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "QuaternionList.asset",
        menuName = SOArchitecture_Utility.COLLECTION_LIST + "Structs/Quaternion",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 13)]
    public class QuaternionList : ListCollection<Quaternion>
    {
    } 
}