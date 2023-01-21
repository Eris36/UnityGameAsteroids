using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public void OnBecameInvisible() {
        // После выхода объекта за границы экрана возвращаем его в пул
        gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Enemy" :
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
                break;
        }
    }
}
