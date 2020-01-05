using BubbleShooter.Helpers;
using BubbleShooter.Enums;
using BubbleShooter.Behaviours;


namespace BubbleShooter.Controllers
{
    public sealed class UIController
    {
        private BaseUIBehaviour _currentWindow;
        private readonly UIFactory _uiFactory;
        private static UIController _instance;

        private UIController()
        {
            _uiFactory = new UIFactory();
        }

        public static UIController Instance
        {
            get => _instance ?? (_instance = new UIController());
        }

        public void Execute(StateUI stateUI)
        {
            if (_currentWindow != null) _currentWindow.Hide();

            switch (stateUI)
            {
                case StateUI.None:
                    break;

                default:
                    break;
            }

            if (_currentWindow != null) _currentWindow.Show();
        }
    }
}
