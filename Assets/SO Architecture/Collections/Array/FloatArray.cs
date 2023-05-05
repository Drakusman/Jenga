using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "FloatArray.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "float[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class FloatArray : ArrayCollection<float>
    {
    }
}
