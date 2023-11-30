using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OllVisible : MonoBehaviour
{
    public void see()
    {
        gameObject.SetActive(true);

    }
    public void delete()
    {
        Destroy(gameObject);
        

    }
}
