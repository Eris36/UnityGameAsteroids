using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Asteroids
{
    public class Pool<T> where T: MonoBehaviour
    {
        public T prefab { get; }
        public bool autoExpand { get; set; }
        public  Transform container { get; }
        private List<T> pool;

        public Pool(T prefab, int count, Transform container)
        {
            this.prefab = prefab;
            this.container = container;
            
            this.CreatePool(count);
        }

        private void CreatePool(int count)
        {
            this.pool = new List<T>();

            for (int i = 0; i < count; i++)
                this.CreateObject();
        }

        private T CreateObject(bool isActiveByDefault = false)
        {
            var createdObject = Object.Instantiate(this.prefab, this.container);
            createdObject.gameObject.SetActive(isActiveByDefault);
            this.pool.Add(createdObject);
            return createdObject;
        }

        public bool HasFreeElement(out T element)
        {
            foreach (var obj in pool)
            {
                if (!obj.gameObject.activeInHierarchy)
                {
                    element = obj;
                    obj.gameObject.SetActive(true);
                    return true;
                }
            }
            element = null;
            return false;
        }

        //Проверка свободных объектов для вызова их на сцену
        public T GetFreeElement()
        {
            if (this.HasFreeElement(out var element))
                return element;

            if (this.autoExpand)
                return this.CreateObject(true);
            throw new Exception("Пул полный");
        }
        
        //Проверка свободных объектов без вызова на сцену
        public bool FreeElement()
        {
            foreach (var obj in pool)
            {
                if (!obj.gameObject.activeInHierarchy)
                {
                    return true;
                }
            }
            return false;
        }
    }
}












