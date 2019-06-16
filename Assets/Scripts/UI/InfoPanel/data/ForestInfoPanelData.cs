using UnityEngine.Events;

namespace UI.InfoPanel.data
{
    public class ForestInfoPanelData : NatureInfoPanelData
    {
        public ForestInfoPanelData(ForestStageInfo stageInfo,
            OnUpdateEvent onUpdateEvent,
            ForestManager forestManager) : base(onUpdateEvent, forestManager)
        {
            StageInfo = stageInfo;
        }

        public ForestStageInfo StageInfo { get; }

        public OnUpdateEvent OnUpdateEvent { get; }
    }
}