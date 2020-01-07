using UnityEngine;
using BubbleShooter.Interfaces;
using BubbleShooter.Models;
using BubbleShooter.Data;
using BubbleShooter.Enums;

namespace BubbleShooter.Helpers
{
    public sealed class StandartBubbleCreator : IBubbleCreator
    {
        private StandartBubbleData _settings;
        private GameObject _prefab;
        private bool _prefabIsNull = true;

        public StandartBubbleCreator(StandartBubbleData settings) =>
            _settings = settings;
        
        public BaseBubbleModel GetBubble()
        {
            if (_prefabIsNull)
            {
                _prefab = Resources.Load<GameObject>(AssetsPathGameObjects.ObjectTypes[GameObjectTypes.Bubble]);
                _prefabIsNull = false;
            }

            var instanceGameObject = Object.Instantiate(_prefab);
            
            return new StandartBubbleModel(_settings, instanceGameObject);
        }
    }
}
