using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rSpeed = 1f;
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rSpeed, 0, 0 * Time.deltaTime);
     
    }
}
