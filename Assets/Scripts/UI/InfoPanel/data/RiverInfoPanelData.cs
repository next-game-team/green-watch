namespace UI.InfoPanel.data
{
    public class RiverInfoPanelData : InfoPanelData
    {
        public RiverInfoPanelData(RiverStageInfo stageInfo)
        {
            StageInfo = stageInfo;
        }

        public RiverStageInfo StageInfo { get; }
    }
}