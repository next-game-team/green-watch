using UI.InfoPanel.data.state;
using UnityEngine;

public class GlobalNatureStateManager : Singleton<GlobalNatureStateManager>
{
    [SerializeField] private NatureStateDictionary _stateDictionary;

    public NatureStateInfo GetStateInfo(StageColor stageColor)
    {
        return _stateDictionary[stageColor];
    }
}