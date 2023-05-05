using SO_Architecture.Collections.Custom;
using UnityEngine;


namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "BoolArray.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "Bool[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class BoolArray : ArrayCollection<bool>
    {
    }
}