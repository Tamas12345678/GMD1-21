using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerShooting : MonoBehaviour
{
    public GameObject hitEffect;

    void Update()
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
