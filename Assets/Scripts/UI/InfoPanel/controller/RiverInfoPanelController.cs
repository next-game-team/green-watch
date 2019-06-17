using UI.InfoPanel.controller;
using UI.InfoPanel.data;

public class RiverInfoPanelController : NatureInfoPanelController
{ 

    protected override void UpdateData(InfoPanelData data)
    {
        var riverData = (RiverInfoPanelData) data;
        _stateShower.ShowState(riverData.StageInfo.Color);
        _rightProgressBar1.fillAmount = riverData.StageInfo.FosforAmount;
        _rightProgressBar2.fillAmount = riverData.StageInfo.JelezoAmount;
        _rightProgressBar3.fillAmount = riverData.StageInfo.No2Amount;
        _rightProgressBar4.fillAmount = riverData.StageInfo.No3Amount;
    }
    
}
