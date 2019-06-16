using UI.InfoPanel.data;
using UnityEngine;

public class RiverManager : NatureManager
{

    private SpriteRenderer _spriteRenderer;
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        InitStage();
    }

    protected override bool IsLastStage()
    {
        return RiverStageManager.Instance.IsLastStage(GetCurrentStage());
    }
    
    protected override void OnNextStage()
    {
        _spriteRenderer.color = RiverStageManager.Instance.GetStageInfo(GetCurrentStage()).RiverColor;
    }

    protected override void OnPreviousStage()
    {
        _spriteRenderer.color = RiverStageManager.Instance.GetStageInfo(GetCurrentStage()).RiverColor;
    }

    public override InfoPanelData GetInfoPanelData()
    {
        return new RiverInfoPanelData(RiverStageManager.Instance.GetStageInfo(GetCurrentStage()),
            OnUpdateEvent, this);
    }
}
