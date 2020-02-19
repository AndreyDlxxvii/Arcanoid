using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    public Rigidbody2D _rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.name);
    }

    private void Start()
    {
       _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float movePlayer = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(movePlayer, 0f);
        transform.Translate(movement * speed * Time.fixedDeltaTime);
        //_rb.AddForce(movement * speed);
    }
}
