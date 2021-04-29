using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
  public Transform firePoint;
  public Transform laserPoint;

  public GameObject bulletPrefab;
  public GameObject lazerPrefab;

  public float bulletForce = 20f;


    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            ShootLaser();
        }
    }

    private void ShootLaser()
    {
        GameObject lazerShooting = Instantiate(lazerPrefab, laserPoint.position, laserPoint.rotation);
        Rigidbody2D rb = lazerShooting.GetComponent<Rigidbody2D>();
        rb.AddForce(laserPoint.up * bulletForce, ForceMode2D.Impulse);
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
