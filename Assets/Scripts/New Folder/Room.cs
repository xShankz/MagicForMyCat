using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject Camera;
    public List<GameObject> entrances;

    private void OnEnable()
    {
        Camera.SetActive(true);
        entrances.ForEach(e => 
        {
            if (e != null) e.SetActive(true);
        });
    }

    private void OnDisable()
    {
        entrances.ForEach(e =>
        {
            if (e != null) e.SetActive(false);
        });
    }
}
