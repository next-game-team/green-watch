using UnityEngine;

namespace UI.InfoPanel.data.state
{
    [CreateAssetMenu(fileName = "NatureStateInfo", menuName = "Create Info/NatureStateInfo")]
    public class NatureStateInfo : ScriptableObject
    {
        [SerializeField, Range(0, 1)] private float _imageSize;
        [SerializeField] private Color _imageColor;

        public float ImageSize => _imageSize;

        public Color ImageColor => _imageColor;
    }
}