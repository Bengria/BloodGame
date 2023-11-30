using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{

    private Text textTime;

    public int minutes;
    private int seconds;
    public int x;

    private void Start()
    {
        textTime = GetComponent<Text>();
    }
   
    void Update()
    {
        minutes = (int)(Time.time / 60) ;
        seconds = (int)(Time.time - minutes * 60);
        textTime.text = minutes.ToString("00") + ":" + (seconds-x).ToString("00");
    }

    
}
