using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public GameObject extraBullets;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.collider.gameObject)
        {


            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }

        
        
    }
}
