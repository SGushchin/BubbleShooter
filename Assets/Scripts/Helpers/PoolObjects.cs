using System.Collections.Generic;
using UnityEngine;
using BubbleShooter.Interfaces;



namespace BubbleShooter.Helpers
{
    public sealed class PoolObjects
    {
        private Queue<GameObject> poolQueue = new Queue<GameObject>();

        private GameObject _prefab;

        public PoolObjects(GameObject poolObject, int amount)
        {
            _prefab = poolObject;

            poolQueue = new Queue<GameObject>(amount);

            for (int i = 0; i < amount; i++)
            {
                var temp = Object.Instantiate(poolObject);
                temp.SetActive(false);
                poolQueue.Enqueue(temp);
            }
        }

        /// <summary>
        /// Получить объект из пула
        /// </summary>
        /// <param name="activateOnReturn"></param>
        /// <returns></returns>
        public GameObject GetObject(bool activateOnReturn = false)
        {
            var obj = poolQueue.Count > 0 ? poolQueue.Dequeue() : Object.Instantiate(_prefab);

            if (activateOnReturn)
            {
                obj.SetActive(true);
            }

            return obj;
        }

        /// <summary>
        /// Вернуть объект в пул
        /// </summary>
        /// <param name="gameObject"></param>
        public void ReturnToPool(GameObject gameObject)
        {
            if (gameObject.activeSelf)
            {
                gameObject.SetActive(false);
            }

            poolQueue.Enqueue(gameObject);
        }

        /// <summary>
        /// Получить размер пула
        /// </summary>
        /// <returns></returns>
        public int GetPoolSize() =>
            poolQueue.Count;
        

        /// <summary>
        /// Очистить пул
        /// </summary>
        public void ClearPool()
        {
            while (poolQueue.Count != 0)
            {
                Object.DestroyImmediate(poolQueue.Dequeue());
            }

            poolQueue.Clear();
        }
    }


}
