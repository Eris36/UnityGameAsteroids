using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
    public void OnBecameInvisible() {
        // После выхода объекта за границы экрана возвращаем его в пул
       Destroy(gameObject);
    }
    
}
