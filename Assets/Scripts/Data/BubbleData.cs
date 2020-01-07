using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BubbleShooter.Data
{
    public abstract class BaseBubbleData : ScriptableObject
    {
        [SerializeField] private int _id;
        [SerializeField] private Sprite _sprite;

        public int GetID { get => _id; }
        public Sprite GetSprite { get => _sprite; }
    }
}
