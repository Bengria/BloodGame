using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -7f)
        {
            Vector3 pose = gameObject.transform.position;
            gameObject.transform.position = new Vector3(pose.x, 5.84f, pose.x);
        }
    }
}
