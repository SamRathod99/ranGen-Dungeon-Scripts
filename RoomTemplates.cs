using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject wall;

    public List<GameObject> rooms;

    public float waittime;
    private bool spawnboss;
    public GameObject boss;

    private void Update()
    {
        if (waittime <= 0 && spawnboss == false) 
        {
            for (int i =0; i < rooms.Count; i++)
            {
                if(i == rooms.Count - 1)
                {
                    Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
                    spawnboss = true;
                }
            }

        }
        else
        {
            waittime -= Time.deltaTime;
        }
    }

}
