using UI.InfoPanel.data;
using UnityEngine;

public class RiverInfoPanelController : InfoPanelController
{

    [SerializeField] private NatureStateShower _stateShower; 
    
    protected override void FillData(InfoPanelData data)
    {
        var riverData = (RiverInfoPanelData) data;
        _stateShower.ShowState(riverData.StageInfo.Color);      
    }
}
