using SO_Architecture.Collections.Custom;
using UnityEngine;

namespace ScriptableObjectArchitecture
{
    [CreateAssetMenu(
        fileName = "SceneList.asset",
        menuName = SOArchitecture_Utility.ADVANCED_LIST_SUBMENU + "Scene",
        order = 120)]
    public class SceneList : ListCollection<SceneInfo>
    {

    }
}