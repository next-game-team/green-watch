using UnityEngine;

public class OnClickBuild : MonoBehaviour
{
    [SerializeField] private Animator _animPanel;
    [SerializeField] private CameraMove _camMove;
    private bool isStopMove;

    void Start()
    {
        gameObject.layer = 9;

        isStopMove = false;
        if(!isStopMove)
        {
            _camMove.enabled = true;
        }
    }

    void OnMouseDown()
    {
        if(CursorStateManager.Instance.stateC == StateCursor.GameObjects)
        {
            _animPanel.SetTrigger("Open");
            isStopMove = true;

            BoxCollider2D col1 = GetComponent<BoxCollider2D>();
            if(col1 != null)
            {
                col1.enabled = false;
            } else {
                var col2 = GetComponent<PolygonCollider2D>();
                col2.enabled = false;
            }

            
            if(isStopMove)
            {
                _camMove.enabled = false;
            }
        }
    }
}
