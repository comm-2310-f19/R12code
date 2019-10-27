using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    // 1. WHAT IS THE ITEM IN LINE 9?
    public string SceneName;

    // 2. WHAT IS HAPPENING IN THE METHOD FROM LINE 12 thru 19?
    private void OnTriggerEnter(Collider other)
    {
        // In the console, it will appear that the character hit the trigger saying that the character entered the public variable string name
        Debug.Log("Entered " + SceneName);
        // 3. WHICH LINE IS LINE 17 GETTING THE INFORMATION FROM?
        SceneManager.LoadScene(SceneName);
    }
}
