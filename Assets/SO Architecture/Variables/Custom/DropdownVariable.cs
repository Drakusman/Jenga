using ScriptableObjectArchitecture;
using SO_Architecture.Variables.Custom;
using TMPro;
using UnityEngine;

namespace Plugins.SO_Architecture.Variables.Custom
{
    /// <summary>
    /// Reference to UI Slider component
    /// </summary>
    [CreateAssetMenu(
        fileName = "DropdownVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Dropdown",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 0)]
    public sealed class DropdownVariable : SerializeFieldClassVariable<TMP_Dropdown>
    {
    }
}