using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float OnScreenDelay = 3f;

    private void Start()
    {
        Destroy(this.gameObject, OnScreenDelay);
    }
}
