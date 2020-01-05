using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using BubbleShooter.Enums;
using BubbleShooter.Helpers;
using BubbleShooter.Controllers;

namespace BubbleShooter.Behaviours
{
    public class MainMenuBehaviour : BaseUIBehaviour
    {
        [SerializeField] private Button _buttonNewGame;
        [SerializeField] private Button _buttonAbout;
        [SerializeField] private Button _buttonExit;

        private void OnEnable()
        {
            _buttonNewGame.onClick.AddListener(NewGameBehaviour);
            _buttonAbout.onClick.AddListener(AboutGameBehaviour);
            _buttonExit.onClick.AddListener(ExitGameBehaviour);
        }

        private void OnDisable()
        {
            _buttonNewGame.onClick.RemoveListener(NewGameBehaviour);
            _buttonAbout.onClick.RemoveListener(AboutGameBehaviour);
            _buttonExit.onClick.RemoveListener(ExitGameBehaviour);
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }

        public override void Initialization()
        {
        }

        public override void Show()
        {
            gameObject.SetActive(true);
        }

        private void NewGameBehaviour() =>
            SceneManager.LoadSceneAsync(SceneData.GameSceneName, LoadSceneMode.Single);
        
        private void AboutGameBehaviour() =>
            SceneManager.LoadSceneAsync(SceneData.AboutSceneName, LoadSceneMode.Single);

        private void ExitGameBehaviour() =>
            UIController.Instance.Execute(StateUI.ExitDialog);
    }
}
