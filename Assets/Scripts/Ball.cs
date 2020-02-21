using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float power;
    private void Start()
    {
        var vect = new Vector2(1.1f, 1.2f);
        var force = GetComponent<Rigidbody2D>();
        force.AddForce(vect * Time.deltaTime * power);
    }


}
