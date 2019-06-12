using System.Collections.Generic;
using UnityEngine;

public class StageManager<T> : Singleton<StageManager<T>> where T: StageInfo
{
    
    [SerializeField] private List<T> _stageList;

    public T GetStageInfo(int stage)
    {
        return _stageList[stage];
    }

    public int GetLastStageNum()
    {
        return _stageList.Count - 1;
    }
    
    public bool IsLastStage(int stage)
    {
        return stage == GetLastStageNum();
    }
}
