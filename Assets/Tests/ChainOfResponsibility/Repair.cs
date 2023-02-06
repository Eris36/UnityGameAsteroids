using System.Collections;
using UnityEngine;

namespace Asteroids
{
    public sealed class Repair : GameHandler
    {
        [SerializeField] private GameObject player;
        private IEnumerator StartRotating()
        {
            player.GetComponent<Player>().AcceleratorSpeed(10);
            yield return null;
            base.Handle();
        }
        public override IGameHandler Handle()
        {
            StartCoroutine(StartRotating());
            return this;
        }
    }
}