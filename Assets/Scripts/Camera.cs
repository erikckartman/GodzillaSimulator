using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y + 35f, target.position.z - 75f);
        transform.position = Vector3.Slerp(transform.position, newPos, Time.deltaTime);
    }
}
