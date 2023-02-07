using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.Interpreter
{
    internal sealed class ScoreInterpreter : MonoBehaviour
    {
        private Text _text;
        
        public string ToRoman(int number)
        {
            string text = number.ToString();
            if (number >= 1000000 && number < 10000000)
            {
                Debug.Log(text);
                text = text[..^6] + "M";
                return text;
            }
            if (number >= 1000 && number < 1000000)
            {
                Debug.Log(text);
                text = text[..^3] + "k";
                return text;
            }
            return text;
            
            /*if (number < 1) return string.Empty;
            if (number >= 1000) return "1K" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);*/
            throw new ArgumentOutOfRangeException(nameof(number));
        }
    }
}
