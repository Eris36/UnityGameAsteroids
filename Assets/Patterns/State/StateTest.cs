using UnityEngine;
namespace Asteroids
{
    public sealed class StateTest : MonoBehaviour
    {
        [SerializeField] ParticleSystem ps;
        [SerializeField] GameObject player;
        private void Start()
        {
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }
    }
}

        