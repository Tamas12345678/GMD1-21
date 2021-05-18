using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    [SerializeField] private GameObject _cloudParticlePrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Enemy enemy = collision.collider.GetComponent<Enemy>();
        


        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            return;
        } else if(enemy != null)
        {
            return;
        }
    }


}
