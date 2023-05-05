using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ByteList.asset",
        menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "byte",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 6)]
    public class ByteList : ListCollection<byte>
    {
    } 
}