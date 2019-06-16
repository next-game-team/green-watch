using UnityEngine;

public abstract class InfoPanelController : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Show(InfoPanelData data)
    {
        _animator.SetTrigger("Open");
        FillData(data);
    }

    protected abstract void FillData(InfoPanelData data);

    public void OnClose()
    {
        GlobalInfoPanelManager.Instance.ClosePanel();
    }
    
    public void Close()
    {
        _animator.SetTrigger("Close");
    }
}
