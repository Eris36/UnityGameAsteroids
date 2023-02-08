using Asteroids;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public void Add(GameStarter _gameStarter)
    {
        _gameStarter.PlayerDestroyMine += Test;
        Debug.Log("Слушатель подписался");
    }

    private void Test()
    {
        Debug.Log("Сработало!");
    }

}
