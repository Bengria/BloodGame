using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lift : MonoBehaviour
{
    private Text textTime;
    private int timeGame;
    private bool gostart;
    public GameObject portal;

    void Start()
    {
        textTime = GetComponent<Text>();
        
    }

    public void Go()
    {
        gostart = true;
        timeGame = 0;
    }
    
    void Update()
    {
        if (gostart)
        {
            timeGame++;
            if (timeGame == 1)
            {
                textTime.text = "Нужно подождать...";
            }
            if (timeGame == 1000)
            {
                textTime.text = "А вот и он!";
                portal.SetActive(true);
            }
        }
        
    }
}
