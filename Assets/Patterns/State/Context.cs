using UnityEngine;
namespace Asteroids
{
    public sealed class Context
    {
        private State _state;
     
        public Context(State state)
        {
            State = state;
            
        }
        public State State
        {
            set
            {
                _state = value;
                Debug.Log("Smoke: " + _state.IsSmoke());
            }
        }
        public void Request()
        {
            _state.Handle(this);
        }
    }
}