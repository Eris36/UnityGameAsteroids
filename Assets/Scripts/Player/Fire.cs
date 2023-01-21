using UnityEngine;


namespace Asteroids
{
    public class Fire : MonoBehaviour
    {
        [SerializeField] private Transform cannon;
        [SerializeField] private PoolBullletExample poolExampleBullet;
        [SerializeField] private PoolAsteroidExample poolExampleAsteroid;
        
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
                if (poolExampleAsteroid.HasFreeElement())
                {
                    poolExampleAsteroid.CreateAsteroid(cannon, forse);
                }
                else
                {
                    Debug.Log("Нету свободных");
                }
            }
        }
    }
}

