using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController : MonoBehaviour
{
    Rigidbody2D rb;
    public float hitForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 direction = collision.GetContact(0).point - new Vector2(transform.position.x, transform.position.y);
        // rb.AddForce(direction * hitForce, ForceMode2D.Impulse);
       // rb.MovePosition(direction * hitForce);
    }
}
