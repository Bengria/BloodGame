using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Portal nextLevel = collision.GetComponent<Portal>();
        if(nextLevel != null)
        {
            SceneManager.LoadScene(nextLevel.index);
        }
    }
}
