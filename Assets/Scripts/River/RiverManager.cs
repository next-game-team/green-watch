using UnityEngine;

public class RiverManager : NatureManager
{

    private SpriteRenderer _spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        InitStage();
    }

    protected override void OnNextStage()
    {
        _spriteRenderer.color = RiverStageManager.Instance.GetStageInfo(GetCurrentStage()).RiverColor;
    }

    protected override void OnPreviousStage()
    {
        _spriteRenderer.color = RiverStageManager.Instance.GetStageInfo(GetCurrentStage()).RiverColor;
    }
}
