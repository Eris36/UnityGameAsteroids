using UnityEngine;
namespace Asteroids.Decorator
{
    internal sealed class ModificationMuffler : ModificationWeapon
    {
        private readonly AudioSource _audioSource;
        private readonly IMuffler _muffler;
        public ModificationMuffler(AudioSource audioSource, IMuffler muffler,
            Vector3 mufflerPosition)
        {
            _audioSource = audioSource;
            _muffler = muffler;
        }
        protected override Weapon AddModification(Weapon weapon)
        {
            _audioSource.volume = _muffler.VolumeFireOnMuffler;
            weapon.SetAudioClip(_muffler.AudioClipMuffler);
            weapon.SetBarrelPosition(_muffler.BarrelPositionMuffler);
            return weapon;
        }
    }
}