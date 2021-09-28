using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float force = 10;
    public float Forcaup = 50;
    Animator animator;
    Rigidbody2D rb;
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	

	void Update ()
    {
        float hor = Input.GetAxis("Horizontal");
        Vector2 direction = transform.right;
        rb.AddForce(direction * force * hor);
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            GameManager.Instance.AddPoint();
            Destroy(collision.gameObject, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Cave"))
        {
            GameManager.Instance.GanhouJogo();
            Time.timeScale = 0;
        }
        if (collision.collider.CompareTag("Shell"))
        {
            animator.SetFloat("yVelocity", +1);
            rb.AddForce(transform.up * Forcaup);
        }
        if (collision.collider.CompareTag("Ground"))
        {
            animator.SetFloat("yVelocity", -1);
        }
    }

}
