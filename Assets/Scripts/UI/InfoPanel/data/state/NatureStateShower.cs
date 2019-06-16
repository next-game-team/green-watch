using UnityEngine;
using UnityEngine.UI;

public class NatureStateShower : MonoBehaviour
{
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void ShowState(StageColor stageColor)
    {
        var stateInfo = GlobalNatureStateManager.Instance.GetStateInfo(stageColor);
        _image.color = stateInfo.ImageColor;
        _image.fillAmount = stateInfo.ImageSize;
    }
}
