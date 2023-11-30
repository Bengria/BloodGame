using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsWithGruz : MonoBehaviour
{
    public bool is4cup = false;
    private void Update()
    {
        Vector3 pos = gameObject.transform.position;
        if(pos.y < -3 )
            gameObject.transform.position = new Vector3 (pos.x, pos.y+0.001f, pos.z);
        if(is4cup && pos.y < -1)
            gameObject.transform.position = new Vector3(pos.x, pos.y + 0.01f, pos.z);
    }


}
