using Game.Scripts.Utils;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace Game.Scripts.InputManager
{
    public class HUD : MonoBehaviour
    {
        [SerializeField] private GameObjectGameEvent cameraTargetChangedEvent;
        [SerializeField] private SerializedDictionary<Button, Transform> buttonToRoot = new();

        private void Awake()
        {
            Assert.IsNotNull(cameraTargetChangedEvent,"cameraTargetChangedEvent != null");
        }
    

        public void OnButtonClicked(Button sender)
        {
            cameraTargetChangedEvent.Raise(buttonToRoot[sender].gameObject);
        }
    }
}