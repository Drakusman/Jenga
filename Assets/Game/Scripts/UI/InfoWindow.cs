using System;
using Game.Scripts.Data;
using Game.Scripts.InputManager.Selector;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;

namespace Game.Scripts.UI
{
    public class InfoWindow : MonoBehaviour
    {
        [SerializeField] private SelectorEvent selectorEvent;

        [SerializeField] private Transform windowRoot;

        [SerializeField, FoldoutGroup("Text")] private TextMeshProUGUI gradeLevelText;
        [SerializeField, FoldoutGroup("Text")] private TextMeshProUGUI domainText;
        [SerializeField, FoldoutGroup("Text")] private TextMeshProUGUI clusterText;
        [SerializeField, FoldoutGroup("Text")] private TextMeshProUGUI standardIDText;
        [SerializeField, FoldoutGroup("Text")] private TextMeshProUGUI standardDescriptionText;

        private void Awake()
        {
            Assert.IsNotNull(selectorEvent, "selectorEvent != null");
            Assert.IsNotNull(windowRoot, "windowRoot != null");

            Assert.IsNotNull(gradeLevelText, "gradeLevelText != null");
            Assert.IsNotNull(domainText, "domainText != null");
            Assert.IsNotNull(clusterText, "clusterText != null");
            Assert.IsNotNull(standardIDText, "standardIDText != null");
            Assert.IsNotNull(standardDescriptionText, "standardDescriptionText != null");

            selectorEvent.AddListener(OnSelectorEvent);
        }

        private void OnDestroy()
        {
            selectorEvent.RemoveListener(OnSelectorEvent);
        }

        private void OnSelectorEvent(APIDataClass newData)
        {
            ShowWindow(newData);
        }

        [Button]
        public void ShowWindow(APIDataClass data)
        {
            gradeLevelText.text = data.grade;
            domainText.text = data.domain;
            clusterText.text = data.cluster;
            standardIDText.text = data.standardid;
            standardDescriptionText.text = data.standarddescription;

            windowRoot.gameObject.SetActive(true);
        }

        [Button]
        public void HideWindow()
        {
            windowRoot.gameObject.SetActive(false);
        }
    }
}