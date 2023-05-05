using Game.Scripts.Colors;
using Game.Scripts.Data;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Assertions;

namespace Game.Scripts.Jenga
{
    public class JengaBlock : MonoBehaviour
    {
        [SerializeField] private BlockColors blockColors;
        [ShowInInspector, ReadOnly] private APIDataClass _blockData;

        private Rigidbody _rigidbody;
        private MeshRenderer _meshRenderer;

        private void Awake()
        {
            Assert.IsNotNull(blockColors, "blockColors != null");

            _rigidbody = GetComponent<Rigidbody>();
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        [Button]
        public void SetData(APIDataClass newData)
        {
            _blockData = newData;
            _meshRenderer.material = blockColors.GetMaterial(newData.mastery);
        }

        public APIDataClass GetData()
        {
            return _blockData;
        }

        public void EnablePhysics()
        {
            _rigidbody.isKinematic = false;
        }

        public void DisablePhysics()
        {
            _rigidbody.isKinematic = true;
        }
    }
}