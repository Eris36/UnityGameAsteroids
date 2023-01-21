using Asteroids.Object_Pool;
using UnityEngine;

namespace Asteroids
{
    public abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        private Transform _rotPool;
        private Health _health;

        public Health Health
        {
            get
            {
                return _health;
            }
            protected set => _health = value;
        }

        public Transform RotPool
        {
            get
            {
                if (_rotPool == null)
                {
                    var find = GameObject.Find(GameManager.POOL_ENEMY);
                    _rotPool = find == null ? null : find.transform;
                }
                return _rotPool;
            }
        }

        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemyAsteroid = Instantiate((Resources.Load<Asteroid>("Enemy/Asteroid")));
            enemyAsteroid.Health = hp;
            return enemyAsteroid;
        }
        
        
        public static Mine CreateMinaEnemy(Health hp)
        {
            var enemyMine = Instantiate(Resources.Load<Mine>("Enemy/Mine"));
            enemyMine.Health = hp;
            return enemyMine;
        }

        public void ActeveEnemy(Vector3 position, Quaternion rotation)
        {
            transform.localPosition = position;
            transform.localRotation = rotation;
            gameObject.SetActive(true);
            transform.SetParent(null);
        }

        protected void ReturnToPool()
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            gameObject.SetActive(false);
            transform.SetParent(RotPool);

            if (!RotPool)
            {
                Destroy(gameObject);
            }
        }
        
        
        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }
    }
}