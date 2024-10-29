using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName;
    public int itemCount;

    public void IncreaseCount()
    {
        itemCount++;
    }

    public void DecreaseCount()
    {
        if (itemCount > 0)
            itemCount--;
    }
}