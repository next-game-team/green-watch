using UnityEngine;

public class SelectableObject : MonoBehaviour
{

    [SerializeField, ReadOnly]
    private GameObject _selectableLine;
    
    // Start is called before the first frame update
    void Start()
    {
        _selectableLine = GetSelectableLine();
        _selectableLine.SetActive(false);
    }

    private GameObject GetSelectableLine()
    {
        return GameObjectUtils.GetChildrenWithTag(gameObject, TagEnum.SelectableLine);
    }

    public void OnSelect()
    {
        _selectableLine.SetActive(true);
    }

    public void OnUnselect()
    {
        _selectableLine.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("Pressed");
        _selectableLine.SetActive(!_selectableLine.activeSelf);
    }
    
}
