using UnityEngine;
namespace Asteroids.Bridge
{
    internal sealed class Example : MonoBehaviour
    {
        private void Start()
        {
            var enemy_1 = new Enemy(new MagicalAttack(), new InfantryMove());
            var enemy_2 = new Enemy(new SwordAttack(), new FastRunning());
        }
    }
}