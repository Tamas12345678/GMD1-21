using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyKillCounter : MonoBehaviour
{
    private Enemy[] _enemies;


    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if(enemy != null)
            {
               
                return;
                
            } else
            {
                Scenarios.winScenarios = 5;
                SceneManager.LoadScene(3);
            }
            
        }

        
    }
   



}
