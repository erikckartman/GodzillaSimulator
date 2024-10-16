using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject laser;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            laser.SetActive(true);
        }
        else
        {
            laser.SetActive(false);
        }
    }
}
