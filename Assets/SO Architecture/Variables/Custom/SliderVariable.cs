using SO_Architecture.Variables.Custom;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjectArchitecture
{
    /// <summary>
    /// Reference to UI Slider component
    /// </summary>
    [CreateAssetMenu(
        fileName = "SliderVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Slider",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 0)]
    public sealed class SliderVariable : SerializeFieldClassVariable<Slider>
    {
    }
}