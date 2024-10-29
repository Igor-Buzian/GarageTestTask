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
    /// <summary>
    /// A method that determines who can use the open or closed method at that moment
    /// </summary>
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
    /// <summary>
    /// Open method which call Trigger Open 
    /// </summary>
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
    /// <summary>
    /// Close method which call Trigger Close after 2 seconds 
    /// (inside the Coroutine)
    /// </summary>
    private void Close()
    {
        StartCoroutine(WaitCloseTrime());
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