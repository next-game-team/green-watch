namespace UI.InfoPanel.data
{
    public class RiverInfoPanelData : NatureInfoPanelData
    {
        public RiverInfoPanelData(RiverStageInfo stageInfo,
            OnUpdateEvent onUpdateEvent,
            RiverManager riverManager) : base(onUpdateEvent, riverManager)
        {
            StageInfo = stageInfo;
        }

        public RiverStageInfo StageInfo { get; }
    }
}