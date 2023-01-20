using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    private Vector2 _moveVector = Vector2.zero;

    public Vector2 MoveVector
    {
        set => _moveVector = value;
    }

    void Update()
    {
        transform.Translate(_moveVector.x * Time.deltaTime * speed, _moveVector.y * Time.deltaTime * speed, 0, Space.World);
    }
    
    public void OnBecameInvisible() {
        // После выхода объекта за границы экрана возвращаем его в пул
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        gameObject.SetActive(false);
    }
}
