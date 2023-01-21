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

        public Pool<Bullet> pool;

        private void Start()
        {
            this.pool = new Pool<Bullet>(this.bulletPrefab, this.poolCount, this.transform);
            this.pool.autoExpand = this.autoExpand;
        }

        public void CreateBullet(Transform cannon, int force)
        {
            var bullet = this.pool.GetFreeElement();
            _rb = bullet.GetComponent<Rigidbody2D>();
            bullet.transform.rotation = cannon.rotation;
            bullet.transform.position = cannon.position;
            _rb.AddForce(cannon.up * force);
        }
    }
}









