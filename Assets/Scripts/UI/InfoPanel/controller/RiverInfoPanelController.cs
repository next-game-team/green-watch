using UI.InfoPanel.controller;
using UI.InfoPanel.data;

public class RiverInfoPanelController : NatureInfoPanelController
{ 

    protected override void UpdateData(InfoPanelData data)
    {
        var riverData = (RiverInfoPanelData) data;
        _stateShower.ShowState(riverData.StageInfo.Color);
    }
    
}
