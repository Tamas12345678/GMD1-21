using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerMoveSpeed = 5f;
    public Camera cam;

    public Rigidbody2D rb;

    Vector2 movement;
   // Vector2 mousePosition;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
     
  

    }

    private void FixedUpdate()
    {
     rb.MovePosition(rb.position + movement * PlayerMoveSpeed * Time.fixedDeltaTime);
    }
}
