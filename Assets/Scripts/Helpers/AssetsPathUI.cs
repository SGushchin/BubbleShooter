using System.Collections.Generic;
using BubbleShooter.Enums;

namespace BubbleShooter.Helpers
{
    public static class AssetsPathUI
    {
        public static readonly Dictionary<StateUI, string> ScreenState = new Dictionary<StateUI, string>
        {
            {
                StateUI.Score, "Score"
            },
            {
                StateUI.MainMenu, "MainMenu"
            },
            {
                StateUI.ExitDialog, "ExitDialog"
            },
            {
                StateUI.About, "About"
            }
        };
    }
}
