using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    public class ManageEnemy : MonoBehaviour
    {

        [SerializeField] private PoolAsteroidExample poolExampleAsteroid;
        [SerializeField] private int forse = 10000;
        [SerializeField] private Transform[] pointRespawn;
        
        void Start()
        {
            StartCoroutine(AddAsteroids());
        }

        IEnumerator AddAsteroids()
        {
            while(true)
            {
                yield return new WaitForSeconds(3f);
                if (poolExampleAsteroid.HasFreeElement())
                {
                    int point = Random.Range(0, pointRespawn.Length);
                    poolExampleAsteroid.CreateAsteroid(pointRespawn[point], forse);
                }
            }
        }
    }
}

