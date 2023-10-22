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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            contador_cuartos++; //aumentar el valor 1
            PrenderCuarto(contador_cuartos);
        }
    }

    public void PrenderCuarto(int nuevo_cuarto)
    {
        Rooms[cuarto_actual].SetActive(false);

        Rooms[nuevo_cuarto].SetActive(true);

        cuarto_actual = nuevo_cuarto;
    }
}
