using System;
using SO_Architecture.References;
using UnityEngine.UI;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class ButtonReference : BaseReference<Button>
    {
        public void AddListener(Action method) => Value.onClick.AddListener(method.Invoke);

        public void RemoveListener(Action method) => Value.onClick.RemoveListener(method.Invoke);

        public void RemoveAllListeners() => Value.onClick.RemoveAllListeners();
    }
}