using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    /*
     *1-> bottom door
     *2-> top door
     *3-> left door
     *4-> right door
    */

    private RoomTemplates template;
    private int random;
    private bool spawned = false;

    private void Start()
    {
        template = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
    }


    private void Spawn()
    {
        if(spawned == false)
        {
            if (openingDirection == 1)
            {
                random = Random.Range(0, template.BottomRooms.Length);
                Instantiate(template.BottomRooms[random], transform.position, template.BottomRooms[random].transform.rotation);
            }
            else if (openingDirection == 2)
            {
                random = Random.Range(0, template.TopRooms.Length);
                Instantiate(template.TopRooms[random], transform.position, template.TopRooms[random].transform.rotation);
            }
            else if (openingDirection == 3)
            {
                random = Random.Range(0, template.leftRooms.Length);
                Instantiate(template.leftRooms[random], transform.position, template.leftRooms[random].transform.rotation);
            }
            else if (openingDirection == 4)
            {
                random = Random.Range(0, template.RightRooms.Length);
                Instantiate(template.RightRooms[random], transform.position, template.RightRooms[random].transform.rotation);
            }

            spawned = true;
        } 
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("SpawnPoint") && collision.GetComponent<RoomSpawner>().spawned == true)
        {
            Destroy(gameObject);
        }
    }
}
