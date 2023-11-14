using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class StartGame : MonoBehaviour
{
    public void NewPlay() => SceneManager.LoadScene("scena 2");
    public void ExitGame()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #elif UNITY_STANDALONE
              Application.Quit();  
        #endif
    }
}
