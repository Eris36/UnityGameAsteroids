using System;
using System.Collections;
using System.Collections.Generic;
using Asteroids;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids
{
    public class PoolBullletExample : MonoBehaviour
    {
        [SerializeField] private int poolCount =3;
        [SerializeField] private bool autoExpand = false;
        [SerializeField] private Bullet bulletPrefab;
        private Rigidbody2D _rb;

        public PoolBulllet<Bullet> pool;

        private void Start()
        {
            this.pool = new PoolBulllet<Bullet>(this.bulletPrefab, this.poolCount, this.transform);
            this.pool.autoExpand = this.autoExpand;
        }

        /*private void Update()
        {
            if (Input.GetMouseButtonDown(1))
                this.CreateBullet();
        }*/

        public void CreateBullet(Transform cannon, int force)
        {
            var Position = new Vector2(Random.Range(-3, 3), Random.Range(-3, 3));
            var bullet = this.pool.GetFreeElement();
            _rb = bullet.GetComponent<Rigidbody2D>();
            bullet.transform.position = cannon.position;
            _rb.AddForce(cannon.up * force);
            
        }
    }
}









