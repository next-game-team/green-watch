using UI.InfoPanel.controller;
using UI.InfoPanel.data;

public class ForestInfoPanelController : NatureInfoPanelController
{
    protected override void UpdateData(InfoPanelData data)
    {
        var forestData = (ForestInfoPanelData) data;
        _stateShower.ShowState(forestData.StageInfo.Color);
    }
    
    
}
