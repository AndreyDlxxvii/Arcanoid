using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public GameObject player;

    private Rigidbody2D _rb;
    private float move;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");
    }
    private void Move()
    {
        Vector2 movement = transform.right * move * speed * Time.deltaTime;
        _rb.MovePosition(_rb.position + movement);
    }
}
