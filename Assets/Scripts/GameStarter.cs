using System;
using Asteroids.Interpreter;
using Asteroids.Object_Pool;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids
{
    public sealed class GameStarter : MonoBehaviour
    {
        [SerializeField] private int summMines = 10;
        [SerializeField] private Text textScore;
        [SerializeField] private ScoreInterpreter numberInterpreter;

        public event Action PlayerDestroyMine; 
        
        private string score;
        private int oldResult;
        private void Start()
        {
            oldResult = 0;
            score = "0";
            UpdateScore();
            
            EnemyPool enemyPoolMine = new EnemyPool(summMines);
            
            for (int i = 0; i < summMines; i++)
            {
                var enemy = enemyPoolMine.GetEnemy("Mine");
                enemy.transform.position = Vector3.one;
                enemy.gameObject.SetActive(true);
            }
        }

        void UpdateScore()
        {
            textScore.text = "Счёт: " + score;
        }

        public void AddScore(int newScoreValue)
        {
            int newResult = oldResult + newScoreValue;
            oldResult = newResult;
            score = numberInterpreter.ToRoman(newResult);
            UpdateScore();
        }

        public void DestroyMine()
        {
            PlayerDestroyMine?.Invoke();
        }
    }
}