using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lenghtGorGruz : MonoBehaviour
{
    public GameObject gruz;
    public float umn=1;

    public Vector3 posGruz;
    public Vector3 razn;

    void Start()
    {
        posGruz = gruz.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        razn = gruz.transform.position - posGruz;
        if (razn.y > 0 && razn.y < 0) Debug.Log("rar");
            gameObject.transform.localScale = new Vector3(1, 1 - (razn.y*umn), 1);
    }
}
