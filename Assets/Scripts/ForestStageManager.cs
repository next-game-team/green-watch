using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestStageManager : Singleton<ForestStageManager>
{
    public const int MaxStage = 6;
    
    [SerializeField] private List<ForestStageInfo> _stageList;

    public ForestStageInfo GetStageInfo(int stage)
    {
        return _stageList[stage];
    }
}
