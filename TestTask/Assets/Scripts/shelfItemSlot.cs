using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class shelfItemSlot : MonoBehaviour
{
    Button CharacterSlot;
    [SerializeField] TextMeshProUGUI ItemName;
    [SerializeField] Text CharacterCount;
    [SerializeField] Text ShelfCount;
    [SerializeField] string Name;
    [SerializeField] ShelfController shelfController;
    [SerializeField] GameObject PlusMinus;

    public int count;
    int characterCount;
    public int whichSlotNow;

    private void Start()
    {
        Time.timeScale = 0;
        CharacterSlot = GetComponent<Button>();
        characterCount = PlayerPrefs.GetInt($"characterCount{whichSlotNow}", 0);
        CharacterCount.text = characterCount.ToString();
        
    }
    public void ChandeItemName()
    {
        PlusMinus.SetActive(true);
        ItemName.text = Name;
        shelfController.WhichSlotNow = whichSlotNow;
    }
    public void IncreaseCharacterCount(int count)
    {
        if (this.count == 0)
        {
            PlusMinus.SetActive(false);
            return;
        }
        characterCount = PlayerPrefs.GetInt($"characterCount{whichSlotNow}", 0);
        characterCount += count;
        this.count -= count;
        CharacterCount.text = characterCount.ToString();
        ShelfCount.text = this.count.ToString();
        PlayerPrefs.SetInt($"characterCount{whichSlotNow}", characterCount);
    }
    public void DecreaseCharacterCount(int count)
    {
        characterCount = PlayerPrefs.GetInt($"characterCount{whichSlotNow}", 0);
        if (characterCount == 0)
        {
            PlusMinus.SetActive(false);
            return;
        }
        characterCount -= count;
        this.count += count;
        CharacterCount.text = characterCount.ToString();
        ShelfCount.text = this.count.ToString();
        PlayerPrefs.SetInt($"characterCount{whichSlotNow}", characterCount);
    }
}