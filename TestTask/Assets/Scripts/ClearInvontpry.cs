using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ClearInvontpry : MonoBehaviour
{
   [SerializeField] GameObject ChoosePopup;
   [SerializeField] GameObject WinPopup;
    CloseCanvas shelfItemSlot;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ChoosePopup.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void NoButton()
    {
        Time.timeScale = 1.0f;
        ChoosePopup.SetActive(false);
    }
    public void YesButton()
    {  
        ChoosePopup.SetActive(false);
        PlayerPrefs.DeleteAll();
        shelfItemSlot = FindAnyObjectByType<CloseCanvas>();
        if (shelfItemSlot == null ) 
        {
            WinPopup.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

}
