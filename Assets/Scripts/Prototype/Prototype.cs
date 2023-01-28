using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prototype : MonoBehaviour
{
    public T Instantiate<T>() where T : Component
    {
        Prototype instance = null;
        instance = Instantiate(this, transform.localPosition, transform.localRotation);
        instance.transform.localScale = transform.localScale;
        instance.gameObject.SetActive(true);

        return instance.GetComponent<T>();
    }
}
