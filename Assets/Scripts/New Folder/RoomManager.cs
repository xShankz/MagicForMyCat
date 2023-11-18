using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public List<GameObject> Rooms; //un grupo que guarda el GameObject

    public int cuarto_actual = 0;

    int contador_cuartos = 0;

    private void Start()
    {
        //PrenderCuarto(2);//manda el valor 1
    }


    public void PrenderCuarto(int nuevo_cuarto)
    {
        Rooms[cuarto_actual].SetActive(false);

        Rooms[nuevo_cuarto].SetActive(true);

        cuarto_actual = nuevo_cuarto;
    }
}
