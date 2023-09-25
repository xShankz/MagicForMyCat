using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour
{
    public GameObject parentRoom;
    public int definedRoom;

    public bool isX = true;
    public int direction;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;
        StartCoroutine(init());
    }

    private IEnumerator init()
    {
        float time = 0;

        GameObject room = getRooms()[definedRoom];
        room.SetActive(true);

        while (time < 2)
        {
            time += Time.deltaTime;
            yield return null;
        }

        GameObject.Find("Player").transform.position = getEntranceDirection(room);
        parentRoom.SetActive(false);
    }

    private List<GameObject> getRooms()
    {
        return GameObject.FindAnyObjectByType<ManagerRooms>().Rooms;
    }

    private Vector3 getEntranceDirection(GameObject room)
    {
        GameObject Camera = room.GetComponent<Room>().Camera;

        float x = Camera.transform.position.x, y = Camera.transform.position.y;
        Vector3 vector;

        int modifier = isX ? -7 : -3;

        switch (direction)
        {
            case 0:
            default:
                vector = new Vector3(x, y + modifier, 0);
                break;
            case 1:
                vector = new Vector3(x + modifier, y, 0);
                break;
            case 2:
                vector = new Vector3(x, y - modifier, 0);
                break;
            case 3:
                vector = new Vector3(x - modifier, y, 0);
                break;

        }

        return vector;
    }
}