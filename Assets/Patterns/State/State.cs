using UnityEngine;

namespace Asteroids
{
    public abstract class State
    {
        public abstract void Handle(Context context);
        public abstract string IsSmoke();
    }
}