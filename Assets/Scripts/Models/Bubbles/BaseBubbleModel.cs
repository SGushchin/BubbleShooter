using System;
using UnityEngine;
using BubbleShooter.Interfaces;
using BubbleShooter.Data;
using DG.Tweening;

namespace BubbleShooter.Models
{
    public abstract class BaseBubbleModel : IModel, IDisposable
    {
        protected BubbleBehaviour _behaviour;
        protected bool _behaviourIsNull = true;
        protected SpringJoint2D _joint;
        protected bool _jointIsNull = true;
        protected Rigidbody2D _rigidbody;
        protected bool _rigidbodyIsNull = true;
        protected SpriteRenderer _spriteRenderer;
        protected bool _spriteRendererIsNull = true;

        public GameObject GetGameObject { get; }
        public Transform GetTransform { get; }
        public BaseBubbleData GetBubbleData { get; }

        public BaseBubbleModel(BaseBubbleData settings, GameObject sceneObject)
        {
            GetGameObject = sceneObject.gameObject;
            GetTransform = sceneObject.transform;
            _behaviourIsNull = !sceneObject.TryGetComponent(out _behaviour);
            _jointIsNull = !sceneObject.TryGetComponent(out _joint);
            _rigidbodyIsNull = !sceneObject.TryGetComponent(out _rigidbody);
            _spriteRendererIsNull = !sceneObject.TryGetComponent(out _spriteRenderer);

            GetBubbleData = settings;
            if (!_spriteRendererIsNull) _spriteRenderer.sprite = settings.GetSprite;
        }

        protected abstract void CollisionHandler(Collision2D collision);

        protected virtual void PreparingMotion()
        {
            DOTween.Kill(GetTransform);

            DeactivateJoint();
        }

        public virtual void SetPosition(Vector3 position) =>
            GetTransform.position = position;

        public virtual void MoveToPosition(MotionToPointParams data)
        {
            PreparingMotion();

            GetTransform.DOMove(data.Position, data.Duration).OnComplete(ActivateJoint);
        }

        public virtual void MoveByPath(MotionbyPathParams data)
        {
            PreparingMotion();

            GetTransform.DOPath(data.Path, data.Duration);
        }

        public void SetActive(bool value)
        {
            if (!_behaviourIsNull)
            {
                if (value)
                    _behaviour.OnCollisionEnter2DEvent += CollisionHandler;
                else
                    _behaviour.OnCollisionEnter2DEvent -= CollisionHandler;
            }

            GetGameObject.SetActive(value);
        }

        public void ActivateJoint()
        {
            if (_jointIsNull) return;

            _joint.enabled = true;
        }

        public void DeactivateJoint()
        {
            if (_jointIsNull) return;

            _joint.enabled = false;
        }

        public void Dispose()
        {
            if (_behaviour != null)
                _behaviour.OnCollisionEnter2DEvent -= CollisionHandler;

            GameObject.Destroy(GetGameObject);
        }
    }
}
