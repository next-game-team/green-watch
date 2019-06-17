using UI.InfoPanel.controller;
using UI.InfoPanel.data;

public class ForestInfoPanelController : NatureInfoPanelController
{
    protected override void UpdateData(InfoPanelData data)
    {
        var forestData = (ForestInfoPanelData) data;
        _stateShower.ShowState(forestData.StageInfo.Color);
        _rightProgressBar1.fillAmount = forestData.StageInfo.RabbitCountRate;
        _rightProgressBar2.fillAmount = forestData.StageInfo.FoxCountRate;
        _rightProgressBar3.fillAmount = forestData.StageInfo.OwlCountRate;
        _rightProgressBar4.fillAmount = forestData.StageInfo.LynxCountRate;
    }
    
    
}
