using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "CharList.asset",
        menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "char",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 7)]
    public class CharList : ListCollection<char>
    {
    } 
}