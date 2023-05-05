using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "GameObjectArray.asset",
        menuName = SOArchitecture_Utility.COLLECTION_ARRAY + "GameObject[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class GameObjectArray : ArrayCollection<GameObject>
    {
    }
}
