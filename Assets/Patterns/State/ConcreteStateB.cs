using UnityEngine;

namespace Asteroids
{
    public sealed class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
        
        public override string IsSmoke()
        {
            return "HP меньше 50, Перехожу в аварийный режим";
        }

    }
}