using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject line;
    public GameObject lamp;
    public int num =0;
    public GameObject[] tuman;

    private void Update()
    {
        if (line.GetComponent<ActivLampBlood>().lineindex >= num)
        {
            Debug.Log("rar");
            ActivLamp();
            //SomeCoroutine();
        }
            
    }
    private void ActivLamp()
    {
        for (int j = 0; j < tuman.Length; j++)
        {
            tuman[j].SetActive(false);
        }
        for (int i = 0; i < 3; i++)
        {
            if (lamp.GetComponent<Light>().intensity <= 5)
            {
                lamp.GetComponent<Light>().intensity += 1;
                
            }
        }
    }
    
}
