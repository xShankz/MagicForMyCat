using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarRoom : MonoBehaviour
{
    public int RoomDestino;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("RoomManager").GetComponent<RoomManager>().PrenderCuarto(RoomDestino);
        }
    }
}
