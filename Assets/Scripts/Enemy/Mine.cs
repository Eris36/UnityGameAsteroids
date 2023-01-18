using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids
{
    public sealed class Mine : Enemy
    {
        public Rigidbody2D _rb;
        private int _speed;
        private Transform respawn;
        [SerializeField] private int health;
        

        private void Start()
        {
             var health1 = Health.Current;
             Debug.Log("Колличество жизней " + health1);
            transform.position = new Vector2(Random.Range(-10f, 10f), Random.Range(-5f, 5f));

            _rb = GetComponent<Rigidbody2D>();
            _speed = Random.Range(600, 1200);
            Vector3 moveDirection = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0f);
            _rb.AddForce(moveDirection * _speed);
        }
    }
}