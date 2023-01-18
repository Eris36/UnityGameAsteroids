using UnityEngine;
namespace Asteroids
{
    internal sealed class MineFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy =
                Object.Instantiate(Resources.Load<Mine>("Enemy/Mine"));
            enemy.DependencyInjectHealth(hp);
            return enemy;
        }
    }
}