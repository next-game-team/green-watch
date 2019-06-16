using UnityEngine;

[CreateAssetMenu(fileName = "RiverStageInfo", menuName = "Create Info/RiverStageInfo")]
public class RiverStageInfo : StageInfo
{
    [SerializeField, Range(0, 1)] private float _pdkLimit;
    [SerializeField] private Color _riverColor;
    [SerializeField] private RiverStageColor _color;

    public float PdkLimit => _pdkLimit;
    public Color RiverColor => _riverColor;
    public RiverStageColor Color => _color;
}

// Colors order is equals to order of forest stages in the table
public enum RiverStageColor
{
    Green,
    Yellow,
    Orange,
    Red,
    Maroon,
    Black
}
