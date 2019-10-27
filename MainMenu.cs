using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1. WHY ARE WE ADDED ON LINE 6?
// WRITE YOUR ANSWER HERE
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // 2. WHAT IS HAPPENING IN THIS METHOD FROM LINE 13 thru 16?
    // WRITE YOUR ANSWER HERE
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // 3. WHAT IS HAPPENING IN THIS METHOD FROM LINE 20 thru 25?
    // WRITE YOUR ANSWER HERE
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
