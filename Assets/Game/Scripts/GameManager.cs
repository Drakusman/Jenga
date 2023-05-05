using System;
using System.Collections.Generic;
using System.Linq;
using Game.Scripts.Data;
using Game.Scripts.Jenga;
using Game.Scripts.Utils;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField, FolderPath] private string path;
        [SerializeField] private List<JengaTower> generators;

        [SerializeField] private List<APIDataClass> allData = new();

        [SerializeField] private SerializedDictionary<string, List<APIDataClass>> sortedData = new();

        private void Awake()
        {
            LoadAndSortData();
            GenerateTowers();
        }


        [Button]
        public void LoadAndSortData()
        {
            allData = DataLoader.LoadData(path);

            allData.Sort((x, y) =>
            {
                var domainComparison = string.Compare(x.domain, y.domain, StringComparison.Ordinal);
                if (domainComparison != 0)
                    return domainComparison;

                var clusterComparison = string.Compare(x.cluster, y.cluster, StringComparison.Ordinal);
                if (clusterComparison != 0)
                    return clusterComparison;

                var standardIdComparison = string.Compare(x.standardid, y.standardid, StringComparison.Ordinal);
                return standardIdComparison;
            });

            foreach (var item in allData)
            {
                if (!sortedData.ContainsKey(item.grade))
                    sortedData[item.grade] = new List<APIDataClass>();

                sortedData[item.grade].Add(item);
            }
        }


        [Button]
        public void GenerateTowers()
        {
            var index = 0;
            foreach (var dataList in sortedData.TakeWhile(_ => generators.Count > index))
            {
                generators[index].GenerateTower(dataList.Value);
                index++;
            }
        }
    }
}