using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
   public GameObject player;
   public bool isDestroyed = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
        else if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

    }
}
