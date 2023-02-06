using UnityEngine;

namespace Asteroids
{
    public sealed class PointRepair: GameHandler
    {
        [SerializeField] private GameObject player;
        [SerializeField] private GameObject Chain;
        
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Bullet")
            {
                Chain.GetComponent<ChainOfResponsibilityTest>().ExecuteChain();
            }
        }
    }
}
