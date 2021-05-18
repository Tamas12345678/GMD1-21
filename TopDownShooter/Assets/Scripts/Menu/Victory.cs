using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{

    public TMPro.TextMeshProUGUI victoryText;

    
    public void TryAgain()
    {
        
        SceneManager.LoadScene(0);
    }
    public void BackToMainMenu()
    {
        
        SceneManager.LoadScene(2);
    }
    
    private void Start()
    {
        Debug.Log(Scenarios.winScenarios);

        if (Scenarios.winScenarios == 1)
        {
            victoryText.text = "Homerunner.";
            Scenarios.winScenarios = 0;

        } else if(Scenarios.winScenarios == 2)
        {
            victoryText.text = "Prison breaker.";
            Scenarios.winScenarios = 0;
        }
        else if (Scenarios.winScenarios == 3)
        {
            victoryText.text = "Treasure hunter";
            Scenarios.winScenarios = 0;
        }
        else if (Scenarios.winScenarios == 4)
        {
            victoryText.text = "Respectful boyo.";
            Scenarios.winScenarios = 0;
        }
        else if (Scenarios.winScenarios == 5)
        {
            victoryText.text = "Monster hunter.";
            Scenarios.winScenarios = 0;
        }

    }


   
        
}
