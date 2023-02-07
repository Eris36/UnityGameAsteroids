using System;
using UnityEngine;

namespace Asteroids
{
    
    public class Bullet : MonoBehaviour
    {

        public void OnBecameInvisible() {
            // После выхода объекта за границы экрана возвращаем его в пул
            gameObject.SetActive(false);
        }
        
    }
}

