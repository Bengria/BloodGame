using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivLampBlood : MonoBehaviour
{
    public GameObject[] lineLamp;

    public GameObject pers;
    public int lineindex = 0;
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(pers != null) 
            { 
            if (lineindex == 0) 
                LenghtLineLampX(lineLamp[0]);
            if (lineindex == 1)
                LenghtLineLampX(lineLamp[1]);
            if(lineindex == 2 )
                LenghtLineLampY(lineLamp[2]);
            if (lineindex == 3 && lineLamp.Length>3)
                    LenghtLineLampX(lineLamp[3]);
            if (lineindex == 4 && lineLamp.Length > 3)
                    LenghtLineLampX(lineLamp[4]);
            }
        }

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<XpController>()) pers = collision.gameObject;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<XpController>()) pers = null;
    }

    private void LenghtLineLampX(GameObject line)
    {
        if (line.transform.localScale.x >= 1)
            lineindex++;
        if (line.transform.localScale.x != 1) 
        { 
        Vector3 scal = line.transform.localScale;
        line.transform.localScale = new Vector3(scal.x + 0.1f, scal.y, scal.x);
        pers.GetComponent<XpController>().playerXP -= 1;
        }
    }
    private void LenghtLineLampY(GameObject line)
    {
        if (line.transform.localScale.y >= 1)
            lineindex++;
        else 
        { 
        Vector3 scal = line.transform.localScale;
        line.transform.localScale = new Vector3(scal.x , scal.y+ 0.1f, scal.x);
        pers.GetComponent<XpController>().playerXP -= 1;
        }
    }
}
