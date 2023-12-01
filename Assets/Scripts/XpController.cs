using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class XpController : MonoBehaviour
{
    public float  playerXP = 100;
    public GameObject xpLine;
    public GameObject xpSphare;
    public GameObject[] xpWeights;

    private Vector3 maxLenghtXP;
    private Vector3 maxLenXP;

    private void Start()
    {
        maxLenghtXP = xpLine.transform.localScale;
        maxLenXP = xpSphare.transform.localScale;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerXP<=0) SceneManager.LoadScene("scena 2");
        Vector3 scaleXP = xpLine.transform.localScale;
        Vector3 scaXP = xpSphare.transform.localScale;
        scaXP.y = maxLenXP.x * playerXP / 100;
        scaleXP.x = maxLenghtXP.x * playerXP / 100;
        xpLine.transform.localScale = scaleXP;
        xpSphare.transform.localScale = scaXP;
    }
}
