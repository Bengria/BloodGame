using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject[] cups;
    private int cupInCup =0;
    void Update()
    {
        if (cups[0].GetComponent<Cup>().isGruz) cupInCup++;
        if (cups[1].GetComponent<Cup>().isGruz) cupInCup++;
        if (cups[2].GetComponent<Cup>().isGruz) cupInCup++;

        Vector3 pos = gameObject.transform.position;
        if(cupInCup == 0)
            gameObject.transform.position = new Vector3(pos.x, -2.53f, pos.z);
        if (cupInCup == 1)
            gameObject.transform.position = new Vector3(pos.x, 0.08f, pos.z);
        if (cupInCup == 2)
            gameObject.transform.position = new Vector3(pos.x, 1.08f, pos.z);
        if(cupInCup == 3)
            gameObject.transform.position = new Vector3(pos.x, 2.08f, pos.z);
        cupInCup = 0;
    }
}
