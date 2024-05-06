using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class RoomCell
{
    RoomCell(GameObject owningRoom, Vector3 camPos)
    {
        room = owningRoom;
        this.camPos = camPos;
        roomPos = owningRoom.transform.position;
    }

    public GameObject room;
    public GameObject[] neighbourRooms;
    public Vector3 roomPos;
    public Vector3 camPos;
}

public class mapGen : MonoBehaviour
{
    [SerializeField]
    GameObject roomPrefab;

    [SerializeField]
    int roomWidth = 10, roomHight = 10;

    List<List<RoomCell>> grid;

    // Start is called before the first frame update
    void Start()
    {
        grid = new List<List<RoomCell>>();

        for(int i = 0; i < roomWidth; i++)
        {
            grid[i] = new List<RoomCell>(roomHight);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
