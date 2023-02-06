using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class LogText : GameHandler
    {
        
        private IEnumerator StartRotating()
        {
            Debug.Log("Сработал следующий модификатор");
            yield return null;
            base.Handle();
        }
        public override IGameHandler Handle()
        {
            StartCoroutine(StartRotating());
            return this;
        }
        
    }
 
}
