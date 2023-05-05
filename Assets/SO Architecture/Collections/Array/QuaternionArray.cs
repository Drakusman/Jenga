using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "QuaternionArray.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "Structs/Quaternion[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class QuaternionArray : ArrayCollection<Quaternion>
    {
    }
}