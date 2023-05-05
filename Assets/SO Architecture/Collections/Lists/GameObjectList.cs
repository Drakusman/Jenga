using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "GameObjectList.asset",
        menuName = SOArchitecture_Utility.COLLECTION_LIST + "GameObject",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 0)]
    public class GameObjectList : ListCollection<GameObject>
    {
    } 
}
