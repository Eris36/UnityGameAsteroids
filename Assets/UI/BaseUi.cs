using UnityEngine;
namespace Asteroids

{
    internal abstract class BaseUi : MonoBehaviour
    {
        public abstract void Execute();
        public abstract void Cancel();
    }
}
