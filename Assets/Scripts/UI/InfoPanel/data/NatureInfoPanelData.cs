namespace UI.InfoPanel.data
{
    public abstract class NatureInfoPanelData : InfoPanelData
    {
        protected NatureInfoPanelData(OnUpdateEvent onUpdateEvent, NatureManager manager)
        {
            OnUpdateEvent = onUpdateEvent;
            Manager = manager;
        }
        public OnUpdateEvent OnUpdateEvent { get; }
        public NatureManager Manager { get; }
    }
}