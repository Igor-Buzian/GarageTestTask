using TMPro;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item Slot", menuName = "Inventory/Item Slot")]
public class ItemSlot : ScriptableObject
{
    public Item item;
    public TextMeshProUGUI itemNameText;
    public Text itemCountShelfText;
    public Text itemCountCharacterText;
    public GameObject PanelPlusMinus;
    public void UpdateSlotUI()
    {
        itemNameText.text = item.itemName;
        itemCountShelfText.text = item.itemCount.ToString();
        itemCountCharacterText.text = item.itemCount.ToString();
        if (item.itemCount == 0)
        {
            itemNameText.text = "";
            PanelPlusMinus.SetActive(false);
        }
    }
}