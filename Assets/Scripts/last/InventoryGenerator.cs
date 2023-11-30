using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGenerator : MonoBehaviour
{
    public Image[] cells;
    private void OnEnable()
    {
        Redraw();
    }

    public void Redraw()
    {
        Inventory inventory = FindObjectOfType<Inventory>();
        if (inventory != null)
        {
            InventoryObject[] objects = inventory.GetFoundObjects();
            for (int i = 0; i < cells.Length; i++)
            {
                if (i < objects.Length)
                {
                    cells[i].sprite = objects[i].sprite;
                    cells[i].color = Color.white;
                }
                else
                {
                    cells[i].sprite = null;
                    cells[i].color = new Color(77f / 255, 77f / 255, 77f / 255, 1);
                }

            }
        }
    }

}
