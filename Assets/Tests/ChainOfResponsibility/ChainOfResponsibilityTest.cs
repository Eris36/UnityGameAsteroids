using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public sealed class ChainOfResponsibilityTest : MonoBehaviour
    {
        [SerializeField] private List<GameHandler> _gameHandlers;
        
        public void ExecuteChain()
        {
            _gameHandlers[0].Handle();
            for (var i = 1; i < _gameHandlers.Count; i++)
            {
                _gameHandlers[i - 1].SetNext(_gameHandlers[i]);
            }
        }
    }
}