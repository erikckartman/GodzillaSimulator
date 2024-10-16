using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : ScoreManager
{
    public GameObject explosion;
    public AudioSource boom;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Unarmed Idle (1)" || collision.gameObject.name == "Laser")
        {
            boom.Play();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
