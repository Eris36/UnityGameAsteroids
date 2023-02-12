namespace Asteroids
{
    public sealed class ConcreteStateA : State
    {

        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }

        public override string IsSmoke()
        {
            return "HP больше 50, режим стандартный";
        }
    }
}
