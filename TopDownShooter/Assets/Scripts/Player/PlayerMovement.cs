using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerMoveSpeed = 5f;
   //public Camera cam;

    public Rigidbody2D rb;

    Vector2 movement;
   // Vector2 mousePosition;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //secret win
        if(Input.GetKeyDown(KeyCode.F))
        {
            Scenarios.winScenarios = 4;
            SceneManager.LoadScene(3);
        }
     
  

    }

    private void FixedUpdate()
    {
     rb.MovePosition(rb.position + movement * PlayerMoveSpeed * Time.fixedDeltaTime);
    }
}
