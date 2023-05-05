using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Colors
{
    [CreateAssetMenu(fileName = nameof(BlockColors), menuName = "Game/Colors/" + nameof(BlockColors))]
    public class BlockColors : ScriptableObject
    {
        [SerializeField] private List<Material> blockMaterials = new();

        public Material GetMaterial(int index)
        {
            return blockMaterials[index];
        }
    }
}