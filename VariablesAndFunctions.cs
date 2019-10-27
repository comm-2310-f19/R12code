using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour
{   

// 1. WHAT IS THE NAME OF THE VARIABLE IN LINE 8?
    int myInt = 5;
    
// 2. DESCRIBE WHAT IS HAPPENING IN THIS METHOD.     
    void Start ()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }
    
 // 3. WHY DOES THIS METHOD NOT HAVE THE WORD VOID?   
    int MultiplyByTwo (int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }
}
