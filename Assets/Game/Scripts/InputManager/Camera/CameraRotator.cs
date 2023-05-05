using System;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.Assertions;

namespace Game.Scripts.InputManager.Camera
{
    public class CameraRotator : MonoBehaviour
    {
        [SerializeField] private GameObjectGameEvent cameraTargetChangedEvent;

        [SerializeField] private float rotateSpeed = 5.0f;
        [SerializeField] private Transform target;
        [SerializeField] private float distance = 5.0f;
        [SerializeField] private float heightOffset = 1f;

        private float currentX = 0.0f;
        private float currentY = 0.0f;

        private void Awake()
        {
            Assert.IsNotNull(cameraTargetChangedEvent, "cameraTargetChangedEvent != null");
            cameraTargetChangedEvent.AddListener(OnCameraTargetChangedEvent);
        }

        private void OnDestroy()
        {
            cameraTargetChangedEvent.RemoveListener(OnCameraTargetChangedEvent);
        }

        private void OnCameraTargetChangedEvent(GameObject newTarget)
        {
            target = newTarget.transform;
        }

        void Start()
        {
            currentX = transform.eulerAngles.y;
        }

        void LateUpdate()
        {
            if (UnityEngine.Input.GetMouseButton(0))
            {
                currentX += UnityEngine.Input.GetAxis("Mouse X") * rotateSpeed;
                currentY += UnityEngine.Input.GetAxis("Mouse Y") * rotateSpeed;

                currentY = Mathf.Clamp(currentY, -90f, 90f);

                Quaternion rotation = Quaternion.Euler(-currentY, currentX, 0);
                Vector3 position = rotation * new Vector3(0.0f, heightOffset, -distance) + target.position;

                transform.rotation = rotation;
                transform.position = position;
            }
        }
    }
}