using System.Collections;
using UnityEngine;

namespace Asteroids
{
    public sealed class RotateAFewSeconds : GameHandler
    {
        [SerializeField] private float _rotationSpeed = 20.0f;
        [SerializeField] private float _rotationDuration = 30.0f;
        private IEnumerator StartRotating()
        {
            var t = 0.0f;
            while ( t < _rotationDuration )
            {
                t += Time.deltaTime;
                transform.Rotate(Vector3.forward * (_rotationSpeed * Time.deltaTime));
                yield return null;
            }
            base.Handle();
        }
        public override IGameHandler Handle()
        {
            StartCoroutine(StartRotating());
            return this;
        }
    }
}
