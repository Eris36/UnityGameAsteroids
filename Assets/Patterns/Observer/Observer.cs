using System.Collections;
using System.Collections.Generic;
using Asteroids;
using UnityEngine;

namespace Asteroids
{
    public class Observer : MonoBehaviour
    {
        private GameStarter _gamestarter;
        private AddScore _addScore;
        private Camera mainCamera;
        void Start()
        {
            mainCamera = Camera.main;
            _gamestarter = new GameStarter();
            _addScore = new AddScore();
            
            _addScore.Add(_gamestarter);
            Debug.Log("Наблюдатель создался");
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
 
}
