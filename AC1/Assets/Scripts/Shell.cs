using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    Animator animator;
    bool open = false;
	void Start ()
    {
        animator = GetComponent<Animator>();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            animator.SetBool("Open", open);
            open = true;
        }
    }
}
