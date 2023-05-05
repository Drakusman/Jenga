using SO_Architecture.Variables.Custom;
using TMPro;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    /// <summary>
    /// Reference to TextMeshProUGUI component
    /// </summary>
    [CreateAssetMenu(
        fileName = "TextVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "TextMeshProUGUI",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 0)]
    public sealed class TextVariable : SerializeFieldClassVariable<TextMeshProUGUI>
    {
    }
}