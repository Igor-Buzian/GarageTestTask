using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Platform[] platform; 
    public OpenCloseDoors openDoors;
    public OpenCloseDoors closeDoors;
    private void Start()
    {
        for (int i=0;i< 2;i++)
        {
            platform[i].OnPlayerEnter += openDoors.Toggle;
            platform[i].OnPlayerExit += openDoors.Toggle;
            platform[i].OnPlayerEnter += closeDoors.Toggle;
            platform[i].OnPlayerExit += closeDoors.Toggle;
        }
      
    }
    
}