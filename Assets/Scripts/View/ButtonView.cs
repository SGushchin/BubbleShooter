using System;
using UnityEngine;
using UnityEngine.UI;
using BubbleShooter.Enums;
using BubbleShooter.Interfaces;

namespace BubbleShooter.View
{
    public sealed class ButtonView : MonoBehaviour, IButton
    {
        public event Action OnClickEvent;

        [SerializeField] private ButtonTypes _type;

        private Button _button;
        private bool _buttonIsNull = true;

        public ButtonTypes GetButtonType { get => _type; }

        private void Awake() =>
            _buttonIsNull = !TryGetComponent(out _button);

        private void OnEnable()
        {
            if (_buttonIsNull) return;

            _button.onClick.AddListener(Click);
        }

        private void OnDisable()
        {
            if (_buttonIsNull) return;

            _button.onClick.RemoveListener(Click);
        }
        
        private void Click() => OnClickEvent?.Invoke();
    }
}
