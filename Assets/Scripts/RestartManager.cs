using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    
    public bool isPaused;
    public GameObject dialogCanvas;

    void Start()
    {
        Time.timeScale = 1;
    }
    public void enableRestartDialog()
    {
        dialogCanvas.SetActive(true);
        PauseGame();
    }
   
    public void RestartScene()
    {
        // ResumeGame(); 
       
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
         isPaused = true;
         Time.timeScale = 0;
    }
    public void ResumeGame()
    {
         Time.timeScale = 1;
    }
}
