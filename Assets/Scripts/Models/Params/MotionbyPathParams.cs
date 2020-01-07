using System;
using UnityEngine;

namespace BubbleShooter.Models
{
    [Serializable]
    public class MotionbyPathParams : TweeningParams
    {
        public Vector3[] Path;
    }
}
