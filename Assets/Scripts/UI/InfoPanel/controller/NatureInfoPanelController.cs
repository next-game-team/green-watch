using UI.InfoPanel.data;
using UnityEngine;

namespace UI.InfoPanel.controller
{
    public abstract class NatureInfoPanelController : InfoPanelController
    {
        [SerializeField] protected NatureStateShower _stateShower;

        private NatureManager _currentManager;

        public void OnNextStage()
        {
            _currentManager.NextStage();
        }
        
        public void OnPreviousStage()
        {
            _currentManager.PreviousStage();
        }
        
        protected override void FillData(InfoPanelData data)
        {
            var natureData = (NatureInfoPanelData) data;
            natureData.OnUpdateEvent.AddListener(UpdateData);
            _currentManager = natureData.Manager;
            UpdateData(natureData);    
        }

        protected abstract void UpdateData(InfoPanelData data);

    }
}