using System;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids
{
    public class AddScore:MonoBehaviour
    {
        private Vector3 startPosition;
        [SerializeField] private Text _text;
        

        public void Add(GameStarter _gameStarter)
        {
            _gameStarter.PlayerDestroyMine += ViewOn;
        }

        private void ViewOn()
        {
            /*_text.enabled = true;*/
            Debug.Log("Сообщение из Наблюдателя: Мина уничтоже");
        }

        void Remove(GameStarter _gameStarter)
        {
            _gameStarter.PlayerDestroyMine -= ViewOn;
        }
    }
}

