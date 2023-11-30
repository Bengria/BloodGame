using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private float max;
    private float min;
    private Vector3 positionPlatf;
    public int di;

    // Start is called before the first frame update
    void Start()
    {
        positionPlatf = gameObject.transform.position;
        min = positionPlatf.x - 2f;
        max = positionPlatf.x + 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (positionPlatf.x >= max) di = -1;
        if (positionPlatf.x <= min) di = 1;

        positionPlatf.x += di * 0.01f;

        gameObject.transform.position = positionPlatf;
    }
}
