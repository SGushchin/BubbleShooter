using UnityEngine;


namespace BubbleShooter.Behaviours
{
    public abstract class BaseUIBehaviour : MonoBehaviour
    {
        public abstract void Show();
        public abstract void Hide();
        public abstract void Initialization();
    }
}
