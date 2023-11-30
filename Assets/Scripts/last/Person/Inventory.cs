using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Inventory : MonoBehaviour
{

    public InventoryObject[] objects;
    public static List<string> store = new List<string>();
    public bool sixname;
    public bool cat;
    public bool flesh;
    public bool me;

    private void Awake()
    {
        foreach (InventoryObject o in objects)
        {
            if (store.Contains(o.name)) TakeObject(o.name);
        }
    }
    
    public InventoryObject GetObjectByName(string name)
    {
        foreach(InventoryObject o in objects)
        {
            if(o.name == name)
            {
                return o;
            }
        }
        return null;
    }

    public InventoryObject[] GetFoundObjects()
    {
        List<InventoryObject> foundObjects = new List<InventoryObject>();
        foreach (InventoryObject o in objects)
        {
            if (o.found) foundObjects.Add(o);
        }
        return foundObjects.ToArray();
    }

    public void TakeObject(string name)
    {
        InventoryObject obj = GetObjectByName(name);
        if (obj != null)
        {
            if (name=="six") sixname = true;
            if (name == "cat") cat = true;
            if (name == "usb") flesh = true;
            if (name == "me") me = true;
            obj.found = true;
            store.Add(obj.name);
        }
        InventoryGenerator ig = FindObjectOfType<InventoryGenerator>();
        if (ig != null) ig.Redraw();
    }

    
}

[System.Serializable]
public class InventoryObject
{
    public string name;
    public bool found;
    public Sprite sprite;
}
