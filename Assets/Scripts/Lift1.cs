using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lift1 : MonoBehaviour
{
    private Text textTime;
    private int timeGame;
    private bool gostart;
    public GameObject portal;

    void Start()
    {
        textTime = GetComponent<Text>();
        gostart = true;
        timeGame = 0;
    }

    
    void Update()
    {
        if (gostart)
        {
            timeGame++;
            if (timeGame == 1000)
            {
                textTime.text = " Выходите";
                portal.SetActive(true);
            }
        }
        
    }
}
