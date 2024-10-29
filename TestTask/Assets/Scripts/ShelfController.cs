using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfController : MonoBehaviour
{
    public shelfItemSlot[] shelfSlots;
    public int WhichSlotNow;
    public void IncreaseCharacterCount()
    {

        shelfSlots[WhichSlotNow].IncreaseCharacterCount(1);

    }

    public void DecreaseCharacterCount()
    {

        shelfSlots[WhichSlotNow].DecreaseCharacterCount(1);
    }
}
