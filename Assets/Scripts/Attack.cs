using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Attack: MonoBehaviour
    {
        public static void AttackNow(Rigidbody2D  _bullet, Transform _barrel, float _force)
        {
            var temAmmunition = Instantiate(_bullet, _barrel.position,
                _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }
    }
}