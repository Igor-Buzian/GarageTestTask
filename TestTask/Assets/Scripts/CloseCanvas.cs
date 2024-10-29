using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCanvas : MonoBehaviour
{
    public shelfItemSlot[] slots;
    public GameObject Panel;

    public void CanselPanel()
    {
        if(slots[0].count == 0 && slots[1].count == 0 && slots[2].count == 0)
        {
            Destroy(gameObject);
        }
        else
        {
            Panel.SetActive(false);
        }
    }
}
