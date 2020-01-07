using System;
using UnityEngine;

namespace BubbleShooter.Models
{
    public sealed class BubbleBehaviour : MonoBehaviour
    {
        public event Action<Collision2D> OnCollisionEnter2DEvent;

        private void OnCollisionEnter2D(Collision2D collision) =>
            OnCollisionEnter2DEvent?.Invoke(collision);
    }
}
