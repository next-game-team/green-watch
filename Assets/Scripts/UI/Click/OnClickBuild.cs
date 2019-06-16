using UnityEngine;

public class OnClickBuild : MonoBehaviour
{
    [SerializeField] private InfoPanelEnum _infoPanel;

    void Start()
    {
        gameObject.layer = 9;
    }

    void OnMouseDown()
    {
        if(GlobalInfoPanelManager.Instance.IsPanelFree)
        {
            GlobalInfoPanelManager.Instance.OpenPanel(_infoPanel);
        }
    }
}
