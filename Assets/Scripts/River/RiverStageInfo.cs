using UnityEngine;

[CreateAssetMenu(fileName = "RiverStageInfo", menuName = "Create Info/RiverStageInfo")]
public class RiverStageInfo : StageInfo
{
    [SerializeField, Range(0, 1)] private float _fosforAmount;
    [SerializeField, Range(0, 1)] private float _jelezoAmount;
    [SerializeField, Range(0, 1)] private float _no2Amount;
    [SerializeField, Range(0, 1)] private float _no3Amount;
    [SerializeField] private Color _riverColor;
    [SerializeField] private StageColor _color;

    public float FosforAmount => _fosforAmount;
    public float JelezoAmount => _jelezoAmount;
    public float No2Amount => _no2Amount;
    public float No3Amount => _no3Amount;
    public Color RiverColor => _riverColor;
    public StageColor Color => _color;
}
