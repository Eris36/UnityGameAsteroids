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
        public string health1;
        public int damage = 20;
        

        private void Start()
        {
            var health = Health.Current;
            health1 = health.ToString();
            Debug.Log("Колличество жизней " + health);
            transform.position = new Vector2(Random.Range(-10f, 10f), Random.Range(-5f, 5f));

            _rb = GetComponent<Rigidbody2D>();
            _speed = Random.Range(3000, 5000);
            Vector3 moveDirection = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0f);
            _rb.AddForce(moveDirection * _speed);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            switch (other.tag)
            {
                case "Player" :
                    other.GetComponent<Player>().Damage(20);
                    /*Destroy(gameObject);*/
                    break;
                case "Bullet":
                    other.gameObject.SetActive(false);
                    Destroy(gameObject);
                    break;
            }
       
            
            
        }
    }
}