using BubbleShooter.Data;
using UnityEngine;

namespace BubbleShooter.Models
{
    public sealed class StandartBubbleModel : BaseBubbleModel
    {
        public StandartBubbleModel(BaseBubbleData settings, GameObject sceneObject) : base(settings, sceneObject)
        {
            if (settings is StandartBubbleData)
                _spriteRenderer.color = (settings as StandartBubbleData).GetColor;
        }

        protected override void CollisionHandler(Collision2D collision)
        {
            return;
        }
    }
}
