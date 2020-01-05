using System;
using BubbleShooter.Enums;


namespace BubbleShooter.Interfaces
{
    public interface IButton
    {
        event Action OnClickEvent;
        ButtonTypes GetButtonType { get; }
    }
}
