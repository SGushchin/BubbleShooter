using BubbleShooter.Models;
using BubbleShooter.Data;


namespace BubbleShooter.Interfaces
{
    public interface IBubbleCreator
    {
        BaseBubbleModel GetBubble();
    }
}
