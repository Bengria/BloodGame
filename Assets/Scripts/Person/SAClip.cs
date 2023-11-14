using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAClip : MonoBehaviour
{

    public string clipName;
    public Sprite[] frames;
    [Range(0.1f, 30f)]
    public float fps = 10f;
    public bool loop = true;


}
