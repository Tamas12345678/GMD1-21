using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyKillCounter : MonoBehaviour
{
    private List<Enemy> _enemies = new List<Enemy>();


    private void OnEnable()
    {
        
        _enemies.AddRange(FindObjectsOfType<Enemy>());
    }

    
    void Update()
    {
       
        if(_enemies.Where(enemy => enemy != null).ToList().Count == 0)
        {
            Scenarios.winScenarios = 5;
            SceneManager.LoadScene(3);
        }
        
    }
   



}
