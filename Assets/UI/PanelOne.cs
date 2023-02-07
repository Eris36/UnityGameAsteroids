using System;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids
{
    internal sealed class PanelOne : BaseUi
    {
        [SerializeField] private Text _text;

        public override void Execute()
        {
            gameObject.SetActive(true);
        }
        public override void Cancel()
        {
            gameObject.SetActive(false);
        }
    }
}