using Asteroids.Object_Pool;
using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {

        [SerializeField] private int summMines = 10;
        
        private void Start()
        {
            
            /*Enemy.CreateMinaEnemy(new Health(100.0f, 100.0f));*/
           
            EnemyPool enemyPoolMine = new EnemyPool(summMines);
            


            for (int i = 0; i < summMines; i++)
            {
                var enemy = enemyPoolMine.GetEnemy("Mine");
                enemy.transform.position = Vector3.one;
                enemy.gameObject.SetActive(true);
            }
            
            
            /*IEnemyFactory factoryAsteroid = new AsteroidFactory();
            factoryAsteroid.Create(new Health(100.0f, 100.0f));
            
            IEnemyFactory factoryMine = new MineFactory();
            factoryMine.Create(new Health(100.0f, 100.0f));
            
            Enemy.Factory = factoryAsteroid;
            Enemy.Factory.Create(new Health(100.0f, 100.0f));
            
            Enemy.Factory = factoryMine;
            Enemy.Factory.Create(new Health(20.0f, 120.0f));*/
            
        }

    }
}