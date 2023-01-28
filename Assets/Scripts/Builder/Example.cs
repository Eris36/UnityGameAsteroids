using UnityEngine;


namespace Asteroids
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        private Rigidbody2D _rb;
        [SerializeField] private GameObject cannon;
        [SerializeField] private GameObject bullet;

        private int massa = 5;
        private int graviti = 0;

        

         public void FireConnon2()
        {
            var gameObjectBuilder = new GameObjectBuilder();
            bullet =
                gameObjectBuilder.Visual.Name("BulletOutBuilder").Sprite(_sprite).Physics.Rigidbody2D(massa, graviti)
                    .BoxCollider2D();
            bullet.tag = "Bullet";
            _rb = bullet.GetComponent<Rigidbody2D>();
            bullet.transform.localRotation = cannon.transform.rotation;
            Debug.Log(cannon.transform.rotation);
            bullet.transform.position = cannon.transform.position;
            _rb.AddForce(cannon.transform.up * 10000); 
        }
    }
}