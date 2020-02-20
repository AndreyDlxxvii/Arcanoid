using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public GameObject player;





        void Update()
    {
        float i = Input.GetAxis("Horizontal");
        print(i);
  
        float xPos = speed * i * Time.deltaTime;

        player.transform.position = new Vector2(xPos, -4.53f);


    }
}
