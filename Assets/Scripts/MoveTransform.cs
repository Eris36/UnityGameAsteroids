using UnityEngine;

namespace Asteroids
{
    internal class MoveTransform: IMove
    {
        private readonly Transform _transform;
        private Vector3 _move;
        private Rigidbody2D _rb;
        
        public  float Speed { get; protected set; }
        
            public MoveTransform(Transform transform, float speed, Rigidbody2D rb)
            {
                _transform = transform;
                Speed = speed;
                _rb = rb;
            }
            public void Move(float horizontal, float vertical, float deltaTime)
            {
                var _speed = deltaTime * Speed;
                Vector3 movement = new Vector3(horizontal,vertical, 0.0f);
                _rb.AddForce(movement * _speed);
            }
    }
}
