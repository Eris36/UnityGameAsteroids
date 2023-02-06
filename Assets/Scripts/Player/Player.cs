using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _forceFire;
        private Camera _camera;
        private IMove _moveTransform;
        private IRotation _rotation;
        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _camera = Camera.main;
            _moveTransform = new AccelerationMove(transform, _speed, _acceleration, _rb);
            _rotation = new RotationShip(transform);
        }
        private void Update()
        {
            var direction = Input.mousePosition -
                            _camera.WorldToScreenPoint(transform.position);
            _rotation.Rotation(direction);
            
            
        _moveTransform.Move(Input.GetAxis("Horizontal"),
                Input.GetAxis("Vertical"), Time.deltaTime);
            
        
        if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                if (_moveTransform is AccelerationMove accelerationMove)
                {
                    accelerationMove.RemoveAcceleration();
                }
            }
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
        }
        public void Damage(int damage)
        {

            _hp = _hp - damage;
        }

    
        //Данный модификар выполнен для шаблона Цепочки зависимостей
        public void AcceleratorSpeed(float value)
        {
            _speed = _speed + value;
            _hp = _hp + value;
        }
        
        
        
    }
}