using UnityEngine;

namespace BubbleShooter.Data
{
    [CreateAssetMenu (fileName = "NewStandartBubble", menuName = "Data/Create bubble/Standart")]
    public sealed class StandartBubbleData : BaseBubbleData
    {
        [SerializeField] private Color _color;

        public Color GetColor { get => _color; }
    }
}
