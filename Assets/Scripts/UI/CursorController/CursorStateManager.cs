using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CursorStateManager : MonoBehaviour
{  
    private static CursorStateManager _instance = null;
    public static CursorStateManager Instance
    {
        get { return _instance; }
    }

    [SerializeField] private Camera _cam;

    public StateCursor stateC;

    void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
    }

    void Start()
    {
        stateC = StateCursor.Nothing;
    }

    void Update()
    {
        var data = PointerRaycast(Input.mousePosition); // пускаем луч

		if(data != null)
		{
            stateC = StateCursor.UIObjects;
		}


        Vector3 vec = _cam.ScreenToWorldPoint (Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(vec, Vector3.back);
        if (hit.collider != null && hit.collider.gameObject.layer == 9) 
        {
            if(data == null)
            {
                stateC = StateCursor.GameObjects;
            }
        }
        else if (hit.collider == null && data == null)
        {
            stateC = StateCursor.Nothing;
        }
    }


	GameObject PointerRaycast(Vector2 position)
	{
		PointerEventData pointerData = new PointerEventData(EventSystem.current);
		List<RaycastResult> resultsData = new List<RaycastResult>();
		pointerData.position = position;
		EventSystem.current.RaycastAll(pointerData, resultsData);

		if(resultsData.Count > 0)
		{
			return resultsData[0].gameObject;
		}

		return null;
	}

}

public enum StateCursor
{
    Nothing,
    GameObjects,
    UIObjects
}
