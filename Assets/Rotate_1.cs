using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_1 : MonoBehaviour
{
    public float speed = 1f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0 * Time.deltaTime);

    }
}
