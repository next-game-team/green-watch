using UnityEngine;
using UnityEngine.Events;

public class OnUpdateEvent : UnityEvent<InfoPanelData>
{
}

public abstract class NatureManager : InfoPanelDataGetter
{
    [Header("Info"), SerializeField, ReadOnly] private int _currentStage;

    protected OnUpdateEvent OnUpdateEvent;

    protected virtual void Start()
    {
        OnUpdateEvent = new OnUpdateEvent();
    }

    protected void InitStage()
    {
        _currentStage = 0;
    }

    protected int GetCurrentStage()
    {
        return _currentStage;
    }

    protected abstract bool IsLastStage();

    public void NextStage()
    {
        if (IsLastStage())
        {
            Debug.LogWarning("Max stage was already reached.");
            return;
        }

        _currentStage++;
        OnNextStage();
        OnUpdateEvent.Invoke(GetInfoPanelData());
    }

    protected abstract void OnNextStage();

    public void PreviousStage()
    {
        if (_currentStage == 0)
        {
            Debug.LogWarning("Min stage was already reached.");
            return;
        }

        _currentStage--;
        OnPreviousStage();
        OnUpdateEvent.Invoke(GetInfoPanelData());
    }

    protected abstract void OnPreviousStage();
}
