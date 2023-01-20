using Asteroids;
using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

namespace Asteroids
{
    public class Fire : MonoBehaviour
    {
        [SerializeField] private Transform cannon;
        [SerializeField] private PoolBullletExample poolExample;

        public int forse = 10;


        private void Start()
        {
            PoolBullletExample poolExample = GetComponent<PoolBullletExample>();
        }


        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                poolExample.CreateBullet(cannon, forse);
            }
        }
    }
}

