using UnityEngine;

namespace Asteroids
{
    public abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public Health Health { get; protected set; }
        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemyAsteroid = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemyAsteroid.Health = hp;
            return enemyAsteroid;
        }
        
        public static Mine CreateMinaEnemy(Health hp)
        {
            var enemyMine = Instantiate(Resources.Load<Mine>("Enemy/Mine"));
            enemyMine.Health = hp;
            return enemyMine;
        }
        
        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }
    }
}