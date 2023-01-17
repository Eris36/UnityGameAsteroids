using UnityEngine;

namespace Asteroids
{
    public interface IAttack 
    {
        void AttackNow(Rigidbody2D _bullet, Transform _barrel, float _force);
    }  
}

