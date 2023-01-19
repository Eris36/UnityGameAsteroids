using UnityEngine;

namespace Asteroids
{
    internal class MoveTransform: IMove
    {
        private readonly Transform _transform;
        private Vector2 _move;
        private Rigidbody2D _rb;
        
        private Vector2 moveVector;
        
        public  float Speed { get; protected set; }
        
            public MoveTransform(Transform transform, float speed, Rigidbody2D rb)
            {
                _transform = transform;
                Speed = speed;
                _rb = rb;
            }
            public void Move(float horizontal, float vertical, float deltaTime)
            {

                Vector2 movement = new Vector2(horizontal,vertical);
                _rb.AddForce(movement * Speed);
            }
    }
}
