using UnityEngine;


namespace BubbleShooter.Interfaces
{
    public interface IModel
    {
        GameObject GetGameObject { get; }
        Transform GetTransform { get; }
    }
}
