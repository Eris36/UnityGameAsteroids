using UnityEngine;

namespace Asteroids
{
    public class Observer : MonoBehaviour
    {
        [SerializeField] private GameStarter _gamestarter;
        [SerializeField] private AddScore _addScore;
        private Camera mainCamera;
        void Start()
        {
            mainCamera = Camera.main;
            _addScore = new AddScore();
            
            _addScore.Add(_gamestarter);
        }

    }
 
}
