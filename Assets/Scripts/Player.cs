using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public GameObject player;

    private Rigidbody2D _rb;
    private float _move;

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
        _move = Input.GetAxis("Horizontal");
    }
    private void Move()
    {
        Vector2 movement = transform.right * _move * Speed * Time.fixedDeltaTime;
        _rb.MovePosition(_rb.position + movement);
    }
}
