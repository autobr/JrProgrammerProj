using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class ExitToMenu : MonoBehaviour
{
    
    private void Start()
    {

    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
