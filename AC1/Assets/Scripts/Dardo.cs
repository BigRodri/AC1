using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dardo : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(transform.right * 5f, ForceMode2D.Impulse);
        Destroy(gameObject, 3f);
    }
}
