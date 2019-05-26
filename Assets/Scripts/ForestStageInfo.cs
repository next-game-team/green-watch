using UnityEngine;

[CreateAssetMenu(fileName = "ForestStageInfo", menuName = "Create Info/ForestStageInfo")]
public class ForestStageInfo : ScriptableObject
{
    [SerializeField, Range(0, 1)] private float _treeCountRate;
    [SerializeField, Range(0, 1)] private float _commonAnimalCountRate;
    [SerializeField, Range(0, 1)] private float _rareAnimalCountRate;
    [SerializeField] private ForestStageColor _color;

    public float TreeCountRate => _treeCountRate;
    public float CommonAnimalCountRate => _commonAnimalCountRate;
    public float RareAnimalCountRate => _rareAnimalCountRate;
    public ForestStageColor Color => _color;
}

// Colors order is equals to order of forest stages in the table
public enum ForestStageColor
{
    Green,
    Yellow,
    Orange,
    Red,
    Maroon,
    Black
}
