using System.Collections;
using UnityEngine;

public class OpenCloseDoors : MonoBehaviour
{
    public Animator doorAnimator; // Аниматор для ворот
    private bool isOpen = false; // Состояние ворот

    private void Start()
    {
        isOpen = false; // Устанавливаем состояние на "закрыто"
        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Close"); // Запускаем анимацию закрытия
        }
        else
        {
            Debug.LogWarning("Animator не установлен!");
        }
    }

    public void Toggle()
    {
        if (isOpen)
        {
            Close(); // Закрываем ворота
        }
        else
        {
            Open(); // Открываем ворота
        }
    }

    private void Open()
    {
        isOpen = true; // Устанавливаем состояние на "открыто"
        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Open"); // Запускаем анимацию открытия
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
        yield return new WaitForSeconds(2);
        isOpen = false; // Устанавливаем состояние на "закрыто"
        if (doorAnimator != null)
        {
            doorAnimator.SetTrigger("Close"); // Запускаем анимацию закрытия
        }
        else
        {
            Debug.LogWarning("Animator не установлен!");
        }
    }
}