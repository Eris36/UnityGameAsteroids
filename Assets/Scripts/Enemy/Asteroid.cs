using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids
{
    [Serializable]
    public sealed class Asteroid : Enemy
    {
        
        [SerializeField] private GameStarter gameStart;
        public int damage = 20;
        
        private Rigidbody2D _rb;
        public int _speed;
        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _speed = Random.Range(3000, 5000);
            Vector3 moveDirection = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0f);
            _rb.AddForce(moveDirection * _speed);
            
            GameObject GameStarterObject = GameObject.FindWithTag("GameStarted");
            if (GameStarterObject != null)
            {
                gameStart = GameStarterObject.GetComponent<GameStarter>();
            }
            else
            {
                Debug.Log("GameStarted не найден");
            }

        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            switch (other.tag)
            {
                case "Player" :
                    other.gameObject.GetComponent<Player>().Damage(damage);
                    gameObject.SetActive(false);
                    break;
                case "Bullet":
                    gameStart.AddScore(100);
                    gameObject.SetActive(false);
                    other.gameObject.SetActive(false);;
                    break;
            }
        }
    }
}