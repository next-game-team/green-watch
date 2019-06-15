using UnityEngine;

public class OnClickBuild : MonoBehaviour
{
    [SerializeField] private Animator _animPanel;
    [SerializeField] private CameraMove _camMove;
    private bool isStopMove;

    void Start()
    {
        isStopMove = false;
        if(!isStopMove)
        {
            _camMove.enabled = true;
        }
    }

    void OnMouseDown()
    {
        _animPanel.SetTrigger("Open");
        isStopMove = true;
        if(isStopMove)
        {
            _camMove.enabled = false;
        }
    }
}
