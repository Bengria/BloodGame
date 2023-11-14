using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public List<Item> items = new List<Item>();
}

[System.Serializable]

public class Item
{

    //public ;
    public Sprite img;
}