using System.Collections.Generic;
using UnityEngine;
using BubbleShooter.Interfaces;
using BubbleShooter.Helpers;


namespace BubbleShooter.Controllers
{
    public abstract class SceneLifecycleBehaviour : MonoBehaviour
    {
        private List<IInitializable> _initializeControllers = new List<IInitializable>(ConstantsHelper.MinArraySize);
        private List<IExecutable> _executeControllers = new List<IExecutable>(ConstantsHelper.MinArraySize);
        private List<ICleanup> _cleanupControllers = new List<ICleanup>(ConstantsHelper.MinArraySize);

        protected abstract void Awake();

        private void Start()
        {
            for (var index = 0; index < _initializeControllers.Count; index++)
            {
                _initializeControllers[index]?.Initialize();
            }
        }

        private void Update()
        {
            for (var index = 0; index < _executeControllers.Count; index++)
            {
                _executeControllers[index]?.Execute();
            }
        }

        private void OnDestroy()
        {
            for (var index = 0; index < _cleanupControllers.Count; index++)
            {
                _cleanupControllers[index]?.Cleanup();
            }
        }

        protected void AddControllerToList(object controller)
        {
            if (controller is IInitializable)
            {
                _initializeControllers.Add(controller as IInitializable);
            }

            if (controller is IExecutable)
            {
                _executeControllers.Add(controller as IExecutable);
            }

            if (controller is ICleanup)
            {
                _cleanupControllers.Add(controller as ICleanup);
            }
        }
    }
}
