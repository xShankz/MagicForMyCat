using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Roomprueba : MonoBehaviour
{
    public GameObject camaraCuarto;
    public CinemachineVirtualCamera virtualCamera;

    public void OnEnable()
    {
        //cambiar camara
        camaraCuarto.SetActive(true);
        //mover jugador
        GameObject.Find("Player").transform.position = new Vector3(camaraCuarto.transform.position.x, camaraCuarto.transform.position.y, 0);
        virtualCamera.Follow = GameObject.Find("Player").transform;
    }
}
