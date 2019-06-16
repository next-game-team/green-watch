using UnityEngine;

[CreateAssetMenu(fileName = "RiverStageInfo", menuName = "Create Info/RiverStageInfo")]
public class RiverStageInfo : StageInfo
{
    [SerializeField, Range(0, 1)] private float _pdkLimit;
    [SerializeField] private Color _riverColor;
    [SerializeField] private StageColor _color;

    public float PdkLimit => _pdkLimit;
    public Color RiverColor => _riverColor;
    public StageColor Color => _color;
}
