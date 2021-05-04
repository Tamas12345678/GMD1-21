using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follows : MonoBehaviour
{

    public Transform player;

    public Vector3 offset;


    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
