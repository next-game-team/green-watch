using UnityEngine;

[CreateAssetMenu(fileName = "ForestStageInfo", menuName = "Create Info/ForestStageInfo")]
public class ForestStageInfo : StageInfo
{
    [SerializeField, Range(0, 1)] private float _treeCountRate;
    [SerializeField, Range(0, 1)] private float _rabbitCountRate;
    [SerializeField, Range(0, 1)] private float _foxCountRate;
    [SerializeField, Range(0, 1)] private float _owlCountRate;
    [SerializeField, Range(0, 1)] private float _lynxCountRate;
    [SerializeField] private StageColor _color;

    public float TreeCountRate => _treeCountRate;
    public float RabbitCountRate => _rabbitCountRate;
    public float FoxCountRate => _foxCountRate;
    public float OwlCountRate => _owlCountRate;
    public float LynxCountRate => _lynxCountRate;
    public StageColor Color => _color;
}
