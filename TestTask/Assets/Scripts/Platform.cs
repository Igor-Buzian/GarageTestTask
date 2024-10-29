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
            OnPlayerEnter?.Invoke(); // �������� ������� ��� ����� ������
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnPlayerExit?.Invoke(); // �������� ������� ��� ������ ������
        }
    }
}