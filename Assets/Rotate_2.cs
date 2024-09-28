using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotate_2 : MonoBehaviour
{
    public float motion = 1f;

    // Update is called once per frame
    void Update()
    {
       
        transform.Rotate( 0, 0, motion *Time.deltaTime);
    }
}
