using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAnimate : MonoBehaviour
{
    public Animator animator;
    public AudioSource Roar;
    public GameObject walk;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            walk.SetActive(true);
            animator.SetBool("isGo", true);
            if (Input.GetKey(KeyCode.Space))
            {
                walk.SetActive(false);
                animator.SetBool("isGo", false);
            }
        }
        else
        {
            walk.SetActive(false);
            animator.SetBool("isGo", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Roar.Play();
        }
    }
}
