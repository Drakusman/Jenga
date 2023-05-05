using Game.Scripts.Jenga;
using UnityEngine;
using UnityEngine.Assertions;

namespace Game.Scripts.InputManager.Selector
{
    public class Selector : MonoBehaviour
    {
        [SerializeField] private SelectorEvent selectorEvent;

        private void Awake()
        {
            Assert.IsNotNull(selectorEvent, "selectorEvent != null");
        }

        void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(1))
            {
                var ray = UnityEngine.Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);

                if (!Physics.Raycast(ray, out var hit)) return;

                if (!hit.collider.TryGetComponent(out JengaBlock jengaBlock)) return;
                
                selectorEvent.Raise(jengaBlock.GetData());
            }
        }
    }
}