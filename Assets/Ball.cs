using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool flag = false;
    private Vector2 vector2 = Vector2.up;
    private void OnCollisionEnter2D(Collision2D collision)
    {


        flag = true;
        
    }


    void Update()
    {
        transform.Translate(vector2 * Time.deltaTime);
        if (flag == true)
        {
            vector2 = Vector2.down;
        }
    }
}
