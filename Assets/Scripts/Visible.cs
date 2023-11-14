using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visible : MonoBehaviour
{
    public GameObject but;
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    public GameObject but4;
    public GameObject but5;
    public GameObject but6;
    
    private bool isSee;
    
    public void see()
    {
        if (isSee == false)
        {
            gameObject.SetActive(true);
            isSee = true;
            but.SetActive(false); but1.SetActive(false); 
            but2.SetActive(false); but3.SetActive(false);
            but4.SetActive(false); but5.SetActive(false); 
            but6.SetActive(false);
        }
        
    }
    public void Nosee()
    {
        gameObject.SetActive(false);
        isSee = false;
        but.SetActive(true); but1.SetActive(true);
        but2.SetActive(true); but3.SetActive(true);
        but4.SetActive(true); but5.SetActive(true);
        but6.SetActive(true);
    }


}
