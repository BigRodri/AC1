using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject dardo;
    public float tamanho;

    public bool facingRight = true;

    public float spawnCooldown = 5f;

    public LayerMask playerLayer;

    void Start()
    {

    }

    void Update()
    {
        if (spawnCooldown > 0)
         spawnCooldown -= Time.deltaTime;

        if (facingRight)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * tamanho);

            if (hit.collider.CompareTag("Player") && spawnCooldown <= 0)
            {
                Instantiate(dardo, transform.position, Quaternion.identity);
                spawnCooldown = 5f;
            }
        }
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, (Vector2.right * -1) * tamanho);

            if (hit.collider.CompareTag("Player") && spawnCooldown <= 0)
            {
                Instantiate(dardo, transform.position, Quaternion.Euler(0f, 0f, 180f));
                spawnCooldown = 5f;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if (facingRight)
            Gizmos.DrawRay(transform.position, Vector2.right * tamanho);
        else
            Gizmos.DrawRay(transform.position, (Vector2.right * -1) * tamanho);
    }
}
