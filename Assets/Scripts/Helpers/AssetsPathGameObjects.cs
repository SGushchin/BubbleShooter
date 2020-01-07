using System.Collections.Generic;
using BubbleShooter.Enums;

namespace BubbleShooter.Helpers
{
    public static class AssetsPathGameObjects
    {
        public static readonly Dictionary<GameObjectTypes, string> ObjectTypes = new Dictionary<GameObjectTypes, string>
        {
            {
                GameObjectTypes.Bubble, "Bubble"
            },
            {
                GameObjectTypes.Launcher, ""
            }
        };
    }
}
