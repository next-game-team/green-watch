using UnityEngine;
using UnityEngine.UI;


public class ButtonPanelControl : MonoBehaviour
{
    public Animator panelBtns;
    public bool isOpen;
    public RectTransform arrowSprite;

    void Start()
    {
        isOpen = true;
        arrowSprite.transform.rotation = Quaternion.Euler(0, 0, 0);

        Canvas can = GetComponent<Canvas>();
        can.renderMode = RenderMode.ScreenSpaceCamera;
    }

    public void OpenClosePanel()
    {
        isOpen = !isOpen;
        if(!isOpen)
        {
            panelBtns.SetTrigger("Close");
            arrowSprite.transform.rotation = Quaternion.Euler(0, 0, 180);
        } else {
            panelBtns.SetTrigger("Open");
            arrowSprite.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
