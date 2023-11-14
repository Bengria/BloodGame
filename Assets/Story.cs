using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour
{
    public GameObject text0;
    public GameObject text1;
    public GameObject text2;
    public GameObject portal;
    public int ai = 0;

   

    public void NewGame()
    {
        if(ai == 0)
        {
            text0.SetActive(false);
            text1.SetActive(true);
        }
        if (ai == 1)
        {
            text1.SetActive(false);
            text2.SetActive(true);
            portal.SetActive(true);
        }
        ai++;
    }
    
}
