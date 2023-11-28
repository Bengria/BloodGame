using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gruses : MonoBehaviour
{
    public GameObject[] gruses;
    public GameObject player;
    private float xp;

    private Color col = new Color(0.4f, 0.4f, 0.4f, 1.0f);

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
       //xp = player.GetComponent<XpController>().playerXP;
       // if (xp >= 100)
       // {
       //     for (int i = 0; i < gruses.Length; i++) { gruses[i].GetComponent<SpriteRenderer>().color = Color.red; }
       // }
       // if (xp < 100 && xp >= 90) gruses[9].GetComponent<SpriteRenderer>().color = col;
       // if (xp < 90 && xp >= 80) gruses[8].GetComponent<SpriteRenderer>().color = col;
       // if (xp < 80 && xp >= 70) gruses[7].GetComponent<SpriteRenderer>().color = col;
       // if (xp < 70 && xp >= 60) gruses[6].GetComponent<SpriteRenderer>().color = col;
       // if (xp < 60 && xp >= 50) gruses[5].GetComponent<SpriteRenderer>().color = col;
       // if (xp < 50 && xp >= 40) gruses[4].GetComponent<SpriteRenderer>().color = col;
       // if (xp < 40 && xp >= 30) gruses[3].GetComponent<SpriteRenderer>().color = col;
       // if (xp < 30 && xp >= 20) gruses[2].GetComponent<SpriteRenderer>().color = col;
       // if (xp < 20 && xp >= 10) gruses[1].GetComponent<SpriteRenderer>().color = col;
       // if (xp < 10 && xp >= 0) gruses[0].GetComponent<SpriteRenderer>().color = col;
    }
}
