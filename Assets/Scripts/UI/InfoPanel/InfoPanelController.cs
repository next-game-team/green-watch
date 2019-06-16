using UnityEngine;

public class InfoPanelController : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Show()
    {
        _animator.SetTrigger("Open");
    }

    public void OnClose()
    {
        GlobalInfoPanelManager.Instance.ClosePanel();
    }
    
    public void Close()
    {
        _animator.SetTrigger("Close");
    }
}
