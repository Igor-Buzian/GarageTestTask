using UnityEngine;

public delegate void PlayerAction();

public class Platform : MonoBehaviour
{
    public event PlayerAction OnPlayerEnter;
    public event PlayerAction OnPlayerExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnPlayerEnter?.Invoke(); // Вызываем событие при входе игрока
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnPlayerExit?.Invoke(); // Вызываем событие при выходе игрока
        }
    }
}