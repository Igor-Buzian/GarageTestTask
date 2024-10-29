using System.Collections;
using UnityEngine;

public class OpenCloseDoors : MonoBehaviour
{
    public Animator doorAnimator; 
    private bool isOpen = false;
    bool corotineIsDone = true;
    private void Start()
    {
        isOpen = false; 
        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Close"); 
        }
        else
        {
            Debug.LogWarning("Animator не установлен!");
        }
    }

    public void Toggle()
    {
        if(corotineIsDone)
        {
            if (isOpen)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
        
    }

    private void Open()
    {
        isOpen = true;
        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Open"); 
        }
        else
        {
            Debug.LogWarning("Animator не установлен!");
        }
    }

    private void Close()
    {
        StartCoroutine(WaitCloseTrime());
      /*  isOpen = false; // Устанавливаем состояние на "закрыто"
        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Close"); // Запускаем анимацию закрытия
        }
        else
        {
            Debug.LogWarning("Animator не установлен!");
        }*/
    }
    IEnumerator WaitCloseTrime()
    {
        corotineIsDone = false;
        yield return new WaitForSeconds(2);
        corotineIsDone = true;
        isOpen = false; 
        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Close"); 
        }
        else
        {
            Debug.LogWarning("Animator не установлен!");
        }
    }
}