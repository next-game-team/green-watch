using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInfoPanelManager : Singleton<GlobalInfoPanelManager>
{
    [SerializeField, ReadOnly] private bool _isPanelFree; // That's mean panel can be opened if true
    [SerializeField, ReadOnly] private InfoPanelController _currentInfoPanel;
    [SerializeField] private CameraMove _camMove;
    [SerializeField] private InfoPanelDictionary _infoPanelDictionary;
    
    public bool IsPanelFree => _isPanelFree;

    private void Start()
    {
        _isPanelFree = true;
    }

    public void OpenPanel(InfoPanelEnum infoPanel)
    {
        _isPanelFree = false;
        _camMove.enabled = false;
        _currentInfoPanel = _infoPanelDictionary[infoPanel];
        _currentInfoPanel.Show();
    }
    
    public void ClosePanel()
    {
        _isPanelFree = true;
        _camMove.enabled = true;
        _currentInfoPanel = null;
    }
}

public enum InfoPanelEnum
{
    Forest,
    River,
    Player,
    Main
}
