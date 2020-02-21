using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Briks : MonoBehaviour
{
    public GameObject Brik;
    void Start()
    {
        for (float y = 0; y<6; y++)
        {
            for (float x = -6; x <= 6; x++)
            {
                var vect = new Vector3(x,y);
                Instantiate(Brik, vect,Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
