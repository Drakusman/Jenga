using System;
using SO_Architecture.Variables.Custom;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "ButtonVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Button",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS)]
    public class ButtonVariable : SerializeFieldClassVariable<Button>
    {
        public void ButtonAddListener(Action method)
        {
            if (Value != null)
                Value.onClick.AddListener(method.Invoke);
        }

        public void ButtonRemoveListener(Action method)
        {
            if (Value != null)
                Value.onClick.RemoveListener(method.Invoke);
        }

        public void ButtonRemoveAllListeners()
        {
            if (Value != null)
                Value.onClick.RemoveAllListeners();
        }
    }
}