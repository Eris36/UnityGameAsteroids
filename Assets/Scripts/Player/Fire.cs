using UnityEngine;


namespace Asteroids
{
    public class Fire : MonoBehaviour
    {
        [SerializeField] private Transform cannon;
        [SerializeField] private PoolBullletExample poolExampleBullet;
        [SerializeField] private Example fire2;
        
        
        public Pool<Asteroid> PoolAsteroid;
        
        public int forse = 10;
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                poolExampleBullet.CreateBullet(cannon, forse);
            }
            
            if (Input.GetMouseButtonDown(1))
            {
                fire2.FireConnon2();
            }
        }
    }
}

