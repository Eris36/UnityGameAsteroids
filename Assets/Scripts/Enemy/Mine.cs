using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids
{
    public sealed class Mine : Enemy
    {
        private Rigidbody2D _rb;
        private int _speed;
        private Transform respawn;
        public string health;
        public int damage = 20;
        
        private void Start()
        {
            var healthInStart = Health.Current;
            health = healthInStart.ToString();
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
                    other.gameObject.GetComponent<Player>().Damage(damage);
                    gameObject.SetActive(false);
                    break;
                case "Bullet":
                    gameObject.SetActive(false);
                    break;
            }
        }
    }
}