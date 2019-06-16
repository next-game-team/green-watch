using UnityEngine;

[CreateAssetMenu(fileName = "ForestStageInfo", menuName = "Create Info/ForestStageInfo")]
public class ForestStageInfo : StageInfo
{
    [SerializeField, Range(0, 1)] private float _treeCountRate;
    [SerializeField, Range(0, 1)] private float _commonAnimalCountRate;
    [SerializeField, Range(0, 1)] private float _rareAnimalCountRate;
    [SerializeField] private StageColor _color;

    public float TreeCountRate => _treeCountRate;
    public float CommonAnimalCountRate => _commonAnimalCountRate;
    public float RareAnimalCountRate => _rareAnimalCountRate;
    public StageColor Color => _color;
}
