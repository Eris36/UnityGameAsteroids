using UnityEngine;


namespace Asteroids
{
    internal sealed class GameObjectPhysicsBuilder : GameObjectBuilder
    {
        public GameObjectPhysicsBuilder(GameObject gameObject) :
            base(gameObject) {}
        public GameObjectPhysicsBuilder BoxCollider2D()
        {
            var component =GetOrAddComponent<BoxCollider2D>();
            component.isTrigger = true;
            component.size = new Vector2(1,3);
            return this;
        }
        public GameObjectPhysicsBuilder Rigidbody2D(float mass, float graviti)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.gravityScale = graviti;
            component.mass = mass;
            return this;
        }
        private T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }
            return result;
        }
    }
}
