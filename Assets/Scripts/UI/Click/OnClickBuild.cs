using UI.InfoPanel.data;
using UnityEngine;

public class OnClickBuild : MonoBehaviour
{
    [SerializeField] private InfoPanelEnum _infoPanel;
    [SerializeField] private InfoPanelDataGetter _infoPanelDataGetter;

    void Start()
    {
        gameObject.layer = 9;
    }

    void OnMouseDown()
    {
        if(GlobalInfoPanelManager.Instance.IsPanelFree 
           && CursorStateManager.Instance.stateC == StateCursor.GameObjects)
        {
            GlobalInfoPanelManager.Instance.OpenPanel(_infoPanel, _infoPanelDataGetter.GetInfoPanelData());
        }
    }
}
