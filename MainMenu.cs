using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1. WHY ARE WE ADDED ON LINE 5?
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // 2. WHAT IS HAPPENING IN THIS METHOD FROM LINE 11 thru 14?
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // 3. WHAT IS HAPPENING IN THIS METHOD FROM LINE 17 thru 22?
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
