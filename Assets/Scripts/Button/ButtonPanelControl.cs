using UnityEngine;

public class ButtonPanelControl : MonoBehaviour
{
    public Animator panelBtns;
    public bool isOpen;

    void Start()
    {
        isOpen = true;
    }

    public void OpenClosePanel()
    {
        isOpen = !isOpen;
        if(!isOpen)
        {
            panelBtns.SetTrigger("Close");
        } else {
            panelBtns.SetTrigger("Open");
        }
    }
}
