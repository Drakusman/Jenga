using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace Game.Scripts.UI
{
    public class WorldText : MonoBehaviour
    {
        [SerializeField] private string text = "Hello, world!";
        [SerializeField] private TMP_FontAsset font;
        [SerializeField] private int fontSize = 24;
        [SerializeField] private Color color = Color.white;
        [SerializeField] private float lineSpacing = 1f;

        private TextMeshPro _textMesh;

        [Button]
        public void Generate()
        {
            _textMesh = gameObject.AddComponent<TextMeshPro>();

            _textMesh.text = text;
            _textMesh.font = font;
            _textMesh.fontSize = fontSize;
            _textMesh.color = color;
            _textMesh.lineSpacing = lineSpacing;

            _textMesh.sortingOrder = 1;

            _textMesh.ForceMeshUpdate();
        }
    }
}