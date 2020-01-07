using System;
using System.Collections.Generic;
using UnityEngine;
using BubbleShooter.Interfaces;



namespace BubbleShooter.Helpers
{
    public sealed class PoolObjects //: IDisposable
    {
        //private Queue<GameObject> poolQueue = new Queue<GameObject>();

        //public PoolObjects(int size)
        //{
        //    poolQueue = new Queue<GameObject>(size);

        //    for (int i = 0; i < size; i++)
        //    {
        //        var temp = _factory.GetInstance();
        //        temp.SetActive(false);
        //        poolQueue.Enqueue(temp);
        //    }
        //}

        ///// <summary>
        ///// Получить объект из пула
        ///// </summary>
        ///// <param name="activateOnReturn"></param>
        ///// <returns></returns>
        //public GameObject GetObject(bool activateOnReturn = false)
        //{
        //    var obj = poolQueue.Count > 0 ? poolQueue.Dequeue() : _factory.GetInstance();

        //    if (activateOnReturn)
        //    {
        //        obj.SetActive(true);
        //    }

        //    return obj;
        //}

        ///// <summary>
        ///// Вернуть объект в пул
        ///// </summary>
        ///// <param name="gameObject"></param>
        //public void ReturnToPool(GameObject poolObject)
        //{
        //    poolObject.SetActive(false);
            
        //    poolQueue.Enqueue(poolObject);
        //}

        ///// <summary>
        ///// Получить размер пула
        ///// </summary>
        ///// <returns></returns>
        //public int GetPoolSize() => poolQueue.Count;
        
        //public void Dispose()
        //{
        //    while (poolQueue.Count != 0)
        //    {
        //        GameObject.Destroy(poolQueue.Dequeue());
        //    }
        //}
    }


}
