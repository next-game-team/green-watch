using UnityEngine;

public abstract class NatureManager : MonoBehaviour
{
    [Header("Info"), SerializeField, ReadOnly] private int _currentStage;

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
    }

    protected abstract void OnPreviousStage();
}
