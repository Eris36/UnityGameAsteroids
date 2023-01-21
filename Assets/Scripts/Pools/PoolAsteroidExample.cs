using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids
{
    public class PoolAsteroidExample : MonoBehaviour
    {
        [SerializeField] private int poolCount =3;
        [SerializeField] private bool autoExpand = false;
        [SerializeField] private Asteroid asteroidPrefab;
        private Rigidbody2D _rb;

        public Pool<Asteroid> pool;

        private void Start()
        {
            this.pool = new Pool<Asteroid>(this.asteroidPrefab, this.poolCount, this.transform);
            this.pool.autoExpand = this.autoExpand;
        }
        
        public void CreateAsteroid(Transform respawn, int force)
        {
            var bullet = this.pool.GetFreeElement();
            _rb = bullet.GetComponent<Rigidbody2D>();
            bullet.transform.rotation = respawn.rotation;
            bullet.transform.position = respawn.position;
            _rb.AddForce(respawn.up * force);
            
        }
        
        public bool HasFreeElement()
        {
            if(pool.FreeElement())
            {
                return true;
            }
            return false;
        }
    }
}