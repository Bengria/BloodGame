using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pomidor : MonoBehaviour
{
    private float max;
    private float min;
    private Vector3 positionPlatf;
    public int di;
    public GameObject activ;

    // Start is called before the first frame update
    void Start()
    {
        positionPlatf = gameObject.transform.position;
        min = positionPlatf.y - 13f;
        max = positionPlatf.y + 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (positionPlatf.y >= max)
        {
            gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            activ.SetActive(true);
            di = -1;
        }
        if (positionPlatf.y <= min)
        {
            activ.SetActive(false);
            gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            di = 1;
        }

        positionPlatf.y += di * 0.01f;

        gameObject.transform.position = positionPlatf;
    }
}
