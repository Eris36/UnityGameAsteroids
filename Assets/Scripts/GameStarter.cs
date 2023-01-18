using UnityEngine;
namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));
            
            Enemy.CreateMinaEnemy(new Health(50.0f, 50.0f));
            
            IEnemyFactory factoryAsteroid = new AsteroidFactory();
            factoryAsteroid.Create(new Health(100.0f, 100.0f));
            
            IEnemyFactory factoryMine = new MineFactory();
            factoryMine.Create(new Health(100.0f, 100.0f));
            
            Enemy.Factory = factoryAsteroid;
            Enemy.Factory.Create(new Health(100.0f, 100.0f));
            
            Enemy.Factory = factoryMine;
            Enemy.Factory.Create(new Health(20.0f, 120.0f));
            
        }

    }
}