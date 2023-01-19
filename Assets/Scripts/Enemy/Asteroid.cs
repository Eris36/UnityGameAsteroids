
using System;
using UnityEngine;

namespace Asteroids
{
    public sealed class Asteroid : Enemy
    {
        private void Start()
        {
            var health1 = Health.Current;
            Debug.Log("Колличество жизней " + health1);
        }
    }
}