using System;
using System.Collections.Generic;
using Game.Scripts.Data;
using ScriptableObjectArchitecture;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;

namespace Game.Scripts.Jenga
{
    public class JengaTower : MonoBehaviour
    {
        [SerializeField] private GameEvent testMyStackEvent;

        [SerializeField] private TextMeshPro gradeText;
        [SerializeField] private GameObject blockPrefab;
        [SerializeField] private float blockSpacing;

        [ShowInInspector, ReadOnly] private readonly List<JengaBlock> _blocks = new();
        [ShowInInspector, ReadOnly] private List<APIDataClass> _sortedData = new();

        private void Awake()
        {
            Assert.IsNotNull(testMyStackEvent, "testMyStackEvent != null");
            Assert.IsNotNull(gradeText, "gradeText != null");
            Assert.IsNotNull(blockPrefab, "blockPrefab != null");

            testMyStackEvent.AddListener(OnTestMyStackEvent);
        }

        private void OnDestroy()
        {
            testMyStackEvent.RemoveListener(OnTestMyStackEvent);
        }

        private void OnTestMyStackEvent()
        {
            EnablePhysics();
            RemoveGlassBlocks();
        }

        [Button]
        public void GenerateTower(List<APIDataClass> data)
        {
            _sortedData = data;
            var height = Mathf.Ceil((float)data.Count / 3);
            var startPosition = transform.position;

            //Generate Tower
            for (var i = 0; i < height; i++)
            {
                var blockPosition = startPosition + new Vector3(0f, i * blockPrefab.transform.lossyScale.y, 0f);

                for (var j = 0; j < 3; j++)
                {
                    if (i * 3 + j >= data.Count) break;

                    var newBlock = Instantiate(blockPrefab, transform);

                    var blockComponent = newBlock.GetComponent<JengaBlock>();
                    blockComponent.SetData(data[i * 3 + j]);

                    _blocks.Add(blockComponent);

                    var offset = Vector3.zero;
                    if (i % 2 == 0)
                    {
                        offset = j switch
                        {
                            0 => new Vector3(0, 0f, 0f),
                            1 => new Vector3(blockSpacing, 0f, 0f),
                            2 => new Vector3(2 * blockSpacing, 0f, 0f),
                            _ => offset
                        };
                    }
                    else
                    {
                        offset = j switch
                        {
                            0 => new Vector3(blockSpacing, 0f, -blockSpacing),
                            1 => new Vector3(blockSpacing, 0f, 0f),
                            2 => new Vector3(blockSpacing, 0f, blockSpacing),
                            _ => offset
                        };

                        newBlock.transform.Rotate(new Vector3(0f, 90f, 0f));
                    }

                    newBlock.transform.position = blockPosition + offset;
                }
            }

            //Set grade text
            gradeText.text = data[0].grade;
        }

        [Button]
        private void EnablePhysics()
        {
            foreach (var block in _blocks)
                block.EnablePhysics();
        }

        [Button]
        private void DisablePhysics()
        {
            foreach (var block in _blocks)
                block.DisablePhysics();
        }

        [Button]
        private void RemoveGlassBlocks()
        {
            for (var i = 0; i < _blocks.Count; i++)
            {
                var currentBlock = _blocks[i];
                
                if (currentBlock.GetData().mastery != 0) continue;
                
                _blocks.RemoveAt(i);
                i--;
                Destroy(currentBlock.gameObject);
            }
        }
    }
}