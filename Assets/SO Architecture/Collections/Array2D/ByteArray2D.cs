using System;
using System.Collections;
using System.Collections.Generic;
using SO_Architecture.Collections.Custom;
using UnityEngine;



namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ByteArray.asset",
        menuName = SOArchitecture_Utility.ADVANCED_ARRAY_SUBMENU + "byte[]",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class ByteArray : ArrayCollection<byte>
    {
    }
}
