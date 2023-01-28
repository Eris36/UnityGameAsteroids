using System.Collections;
using UnityEngine;

namespace Asteroids
{
    public class ManageEnemy : MonoBehaviour
    {

        [SerializeField] private PoolAsteroidExample poolExampleAsteroid;
        [SerializeField] private int forse = 100000;
        [SerializeField] private Transform[] pointRespawn;
        [SerializeField] private GameObject XION;
        

        private Rigidbody2D _rb;
        
        void Start()
        {
            StartCoroutine(AddAsteroids());
            StartCoroutine(AddXION());
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
        
        IEnumerator AddXION()
        {
            while(true)
            {
                yield return new WaitForSeconds(3f);
                int point = Random.Range(0, pointRespawn.Length);
                XION.GetComponent<Spawner>().GetMaket(pointRespawn[point]);
            }
        }
    }
}

