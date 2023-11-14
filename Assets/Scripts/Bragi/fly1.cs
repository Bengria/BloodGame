using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly1 : MonoBehaviour
{
    private float max;
    private float min;
    private Vector3 positionPlatf;
    public int di;

    // Start is called before the first frame update
    void Start()
    {
        positionPlatf = gameObject.transform.position;
        min = positionPlatf.y - 2f;
        max = positionPlatf.y + 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (positionPlatf.y >= max) di = -1;
        if (positionPlatf.y <= min) di = 1;

        positionPlatf.y += di * 0.01f;

        gameObject.transform.position = positionPlatf;
    }
}
