using UnityEngine;
using BubbleShooter.Behaviours;


namespace BubbleShooter.Helpers
{
    public sealed class UIFactory
    {
        private Canvas _canvas;
        private MainMenuBehaviour _mainMenuBehaviour;

        public UIFactory()
        {
            _canvas = Object.FindObjectOfType<Canvas>();
        }

        //public MainMenuBehaviour GetMainMenuUI()
        //{
        //    if (_mainMenuBehaviour == null)
        //    {
        //        var resources = Resources.Load<MainMenuBehaviour>(AssetsPathUI.ScreenState[StateUI.MainMenu]);
        //        _mainMenuUi = Object.Instantiate(resources, _canvas.transform.position, Quaternion.identity, _canvas.transform);
        //    }

        //    _mainMenuUi.Initialization();
        //    return _mainMenuUi;
        //}
    }
}
