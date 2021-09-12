using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreenManager : MonoBehaviour
{
    
    public void OnMapClick()
    {
        Debug.Log("On Map click!");
        SceneManager.LoadScene("Map");
    }

    public void OnQuizClick()
    {
        SceneManager.LoadScene("Quiz");
    }

    public void OnStatsClick()
    {
        
    }
}
