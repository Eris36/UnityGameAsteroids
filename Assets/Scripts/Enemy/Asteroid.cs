using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids
{
    [Serializable]
    public sealed class Asteroid : Enemy
    {
        private Rigidbody2D _rb;
        public int _speed;
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _speed = Random.Range(3000, 5000);
            Vector3 moveDirection = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0f);
            _rb.AddForce(moveDirection * _speed);
        }
    }
}