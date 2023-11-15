using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpController : MonoBehaviour
{
    public float  playerXP = 100;
    public GameObject xpLine;
    public GameObject[] xpWeights;

    private Vector3 maxLenghtXP;

    private void Start()
    {
        maxLenghtXP = xpLine.transform.localScale;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 scaleXP = xpLine.transform.localScale;
        scaleXP.x = maxLenghtXP.x * playerXP / 100;
        xpLine.transform.localScale = scaleXP;
    }
}
