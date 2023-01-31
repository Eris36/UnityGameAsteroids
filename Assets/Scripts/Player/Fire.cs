using UnityEngine;


namespace Asteroids
{
    public class Fire : MonoBehaviour
    {
        [SerializeField] private Transform cannon;
        [SerializeField] private PoolBullletExample poolExampleBullet;
        [SerializeField] private Example fire2;
        [SerializeField] private bool fuse = false;
        
        
        
        public Pool<Asteroid> PoolAsteroid;
        
        public int forse = 10;
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0) & !fuse)
            {
                poolExampleBullet.CreateBullet(cannon, forse);
            }
            
            if (Input.GetMouseButtonDown(1) & !fuse)
            {
                fire2.FireConnon2();
            }
        }
    }
}

