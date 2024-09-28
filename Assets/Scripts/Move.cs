using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Vector3 pointA;
    public Vector3 pointB;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * moveSpeed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
