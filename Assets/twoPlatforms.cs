using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class twoPlatforms : MonoBehaviour
{
    public GameObject twoPlatf;

    public Vector3 selfPos;
    public Vector3 twoPos;

    public Vector3 razn;
    public Vector3 top = new Vector3(0,00001f,0);

    private void Start()
    {
        selfPos = transform.position;
        twoPos = twoPlatf.transform.position;
    }

    private void Update()
    {
        
        Vector3 razn = transform.position - selfPos;
        twoPlatf.transform.position = twoPos - razn;
    }
    private void FixedUpdate()
    {
        Vector3 pos = gameObject.transform.position;
        if (transform.position.y < -2f)
            gameObject.transform.position = new Vector3(pos.x, pos.y + 0.01f, pos.z);
    }
}
