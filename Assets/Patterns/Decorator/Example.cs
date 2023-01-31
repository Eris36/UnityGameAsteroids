using Unity.VisualScripting;
using UnityEngine;
namespace Asteroids.Decorator
{
    internal sealed class Example : MonoBehaviour
    {
        private IFire _fire;
        [Header("Start Gun")]
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrelPosition;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioClip _audioClip;
        [Header("Muffler Gun")]
        [SerializeField] private AudioClip _audioClipMuffler;
        [SerializeField] private float _volumeFireOnMuffler;
        [SerializeField] private Transform _barrelPositionMuffler;
        [SerializeField] private GameObject _muffler;

        private bool IsOn_muffler = false;
        
        private void Start()
        {
            _muffler.SetActive(false);
            IAmmunition ammunition = new Bullet(_bullet, 3.0f);
            _fire = new Weapon(ammunition, _barrelPosition, 999.0f,
                _audioSource, _audioClip);
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _fire.Fire();
            }
            if (Input.GetMouseButtonDown(1))
            {
                Is_muffler();
            }


            void Is_muffler()
            {
                IsOn_muffler = !IsOn_muffler;
                if (IsOn_muffler)
                {
                    _muffler.SetActive(false);
                    IAmmunition ammunition = new Bullet(_bullet, 3.0f);
                    _fire = new Weapon(ammunition, _barrelPosition, 999.0f,
                        _audioSource, _audioClip);
                }
                else
                { 
                    _muffler.SetActive(true);
                    IAmmunition ammunition = new Bullet(_bullet, 3.0f);
                    var weapon = new Weapon(ammunition, _barrelPosition, 500.0f,
                        _audioSource, _audioClip);
                    var muffler = new Muffler(_audioClipMuffler, _volumeFireOnMuffler,
                        _barrelPosition, _muffler);
                    ModificationWeapon modificationWeapon = new
                        ModificationMuffler(_audioSource, muffler, _barrelPositionMuffler.position);
                    modificationWeapon.ApplyModification(weapon);
                    _fire = modificationWeapon;
                }
            }
        }
    }
}
