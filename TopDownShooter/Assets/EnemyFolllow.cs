using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFolllow : MonoBehaviour
{
    public float speed;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;

    //before first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
        movement = direction;
    }

    private void FixedUpdate()
    {
        Enemy_move(movement);
    }

    private void Enemy_move(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
}
